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
    public partial class Form20 : Form
    {
        public Form20()
        {
            InitializeComponent();
        }

        private void Form20_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_БД_Рекламного_агентства_DataSet.Список_заказов". При необходимости она может быть перемещена или удалена.
            this.список_заказовTableAdapter.Fill(this._БД_Рекламного_агентства_DataSet.Список_заказов);

        }

        private void код_заказчикаLabel_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.список_заказовBindingSource.MoveFirst();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.список_заказовBindingSource.MoveLast();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.список_заказовBindingSource.MovePrevious();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.список_заказовBindingSource.MoveNext();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.список_заказовBindingSource.AddNew();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.список_заказовBindingSource.RemoveCurrent();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.список_заказовBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this._БД_Рекламного_агентства_DataSet);

                MessageBox.Show("Update Successful");
            }
            catch (System.Exception)
            {
                MessageBox.Show("Update failed");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }
    }
}
