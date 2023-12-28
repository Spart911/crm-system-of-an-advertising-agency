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
    public partial class Form22 : Form
    {
        public Form22()
        {
            InitializeComponent();
        }

        private void Form22_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_БД_Рекламного_агентства_DataSet.Список_заказов". При необходимости она может быть перемещена или удалена.
            this.список_заказовTableAdapter.Fill(this._БД_Рекламного_агентства_DataSet.Список_заказов);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            список_заказовBindingSource.Filter = "[Дата_заказа]='" + dateTimePicker1.Text + "'";
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }



        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            список_заказовBindingSource.Filter = "";
        }

        private void список_заказовDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
