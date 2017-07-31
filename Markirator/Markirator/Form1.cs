using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Markirator
{
    public partial class Form1 : Form
    {
        private Mkr m;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Mkr m = new Mkr();

            if (m.IsOK) MessageBox.Show("done");
            if (!m.IsOK) MessageBox.Show(m.Ex.Message);

        }

        private void btnOpenMkr_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.ShowDialog();
            m = new Mkr(op.FileName);

            if (m.IsOK) MessageBox.Show("done");
            if (!m.IsOK) MessageBox.Show(m.Ex.Message);

            ShowMkr();
        }

        private void ShowMkr()
        {
            for (int k = 0; k < m.RowsCount; k++)
            {

                object[] par = new object[8];

                par[0] = m.Num(k);
                par[2] = m.Model(k);
                par[3] = m.Type(k);
                par[4] = m.FurType(k);
                par[5] = m.FurColor(k);
                par[6] = IsChecked(m.IsPainted(k));
                par[7] = m.Size(k);


                dataGridView1.Rows.Insert(0, par);
                
            }
        }

        private CheckState IsChecked(bool token)
        {
            if (token) return CheckState.Checked;
            return CheckState.Unchecked;
        }
    }
}
