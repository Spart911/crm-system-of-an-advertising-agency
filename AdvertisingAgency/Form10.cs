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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void заказыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.заказыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._БД_Рекламного_агентства_DataSet);

        }

        private void Form10_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_БД_Рекламного_агентства_DataSet.Заказы". При необходимости она может быть перемещена или удалена.
            this.заказыTableAdapter.Fill(this._БД_Рекламного_агентства_DataSet.Заказы);

        }

        private void код_услуги_2TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.заказыBindingSource.MoveFirst();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.заказыBindingSource.MovePrevious();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.заказыBindingSource.AddNew();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.заказыBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.заказыBindingSource.MoveNext();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.заказыBindingSource.RemoveCurrent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.заказыBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this._БД_Рекламного_агентства_DataSet);

                MessageBox.Show("Update Successful");
            }
            catch (System.Exception)
            {
                MessageBox.Show("Update failed");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void код_сотрудникаTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
