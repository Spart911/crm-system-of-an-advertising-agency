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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void адресLabel_Click(object sender, EventArgs e)
        {

        }

        private void телефонLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void заказчикиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.заказчикиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._БД_Рекламного_агентства_DataSet);

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_БД_Рекламного_агентства_DataSet.Заказчики". При необходимости она может быть перемещена или удалена.
            this.заказчикиTableAdapter.Fill(this._БД_Рекламного_агентства_DataSet.Заказчики);

        }

        private void код_заказчикаTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.заказчикиBindingSource.MoveFirst();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.заказчикиBindingSource.MovePrevious();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.заказчикиBindingSource.AddNew();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.заказчикиBindingSource.MoveLast(); 
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.заказчикиBindingSource.MoveNext();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.заказчикиBindingSource.RemoveCurrent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.заказчикиBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this._БД_Рекламного_агентства_DataSet);

                MessageBox.Show("Update Successful");
            }
            catch (System.Exception)
            {
                MessageBox.Show("Update failed");
            }
        }
    }
}
