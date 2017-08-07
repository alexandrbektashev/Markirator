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
            m = new Mkr();
            if (m.IsOK)
            {
                MessageBox.Show("done");
                btnAddRow.Enabled = true;
                btnDeleteRows.Enabled = true;
                btnSave.Enabled = true;
                dataGridView1.Enabled = true;
                textBox1.Enabled = true;

            }
            if (!m.IsOK) MessageBox.Show(m.Ex.Message);

        }

        private void btnOpenMkr_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.ShowDialog();
            m = new Mkr(op.FileName);

            if (m.IsOK) 
            {
                MessageBox.Show("done");
                btnAddRow.Enabled = true;
                btnDeleteRows.Enabled = true;
                btnSave.Enabled = true;
                dataGridView1.Enabled = true;
                textBox1.Enabled = true;
                ShowMkr();
            }
            if (!m.IsOK) MessageBox.Show(m.Ex.Message);
        }

        private void ShowMkr()
        {
            for (int k = 0; k < m.RowsCount; k++)
            {

                object[] par = m.ObjRow(k);

                dataGridView1.Rows.Add(par);
                
            }
        }

        private void AddLastRowMkr()
        {

            object[] par = m.ObjRow(m.RowsCount - 1);
            dataGridView1.Rows.Add(par);
        }

        private CheckState IsChecked(bool token)
        {
            if (token) return CheckState.Checked;
            return CheckState.Unchecked;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            m.Save();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        

        private void AddRow(string row)
        {

            m.SetNewRow(row);
            if (!m.IsOK) MessageBox.Show(m.Ex.Message, "Fuck!");
           else AddLastRowMkr();
            
        }

        private void btnAddRow_Click(object sender, EventArgs e)
        {
            AddRow(textBox1.Text);
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddRow(textBox1.Text);
            }
        }

        private void btnAcceptChanges_Click(object sender, EventArgs e)
        {

        }

     

        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            int ind = e.RowIndex;
            m.RemoveRow(ind);
            
        }
    }
}
