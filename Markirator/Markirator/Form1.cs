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
                
                object[] par = { m.Num(k), m.Model(k), m.Type(k), m.FurType(k),m.FurColor(k),m.Size(k),m.IsPainted(k)};
                dataGridView1.Rows.Insert(0, par);
            }
        }
    }
}
