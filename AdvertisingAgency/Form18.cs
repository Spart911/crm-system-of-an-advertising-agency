using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdvertisingAgency
{
    public partial class Form18 : Form
    {
        public Form18()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void Form18_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_БД_Рекламного_агентства_DataSet.Отдел_кадров". При необходимости она может быть перемещена или удалена.
            this.отдел_кадровTableAdapter.Fill(this._БД_Рекламного_агентства_DataSet.Отдел_кадров);

        }

        private void фИОTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.отдел_кадровBindingSource.MoveFirst();
        }

 


        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            this.отдел_кадровBindingSource.MoveLast();
        }

        private void button16_Click_1(object sender, EventArgs e)
        {
            this.отдел_кадровBindingSource.MovePrevious();
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            this.отдел_кадровBindingSource.MoveNext();
        }

        private void button15_Click_1(object sender, EventArgs e)
        {
            this.отдел_кадровBindingSource.AddNew();
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            this.отдел_кадровBindingSource.RemoveCurrent();
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.отдел_кадровBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this._БД_Рекламного_агентства_DataSet);

                MessageBox.Show("Update Successful");
            }
            catch (System.Exception)
            {
                MessageBox.Show("Update failed");
            }
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
