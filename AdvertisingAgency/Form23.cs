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
    public partial class Form23 : Form
    {
        public Form23()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form23_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_БД_Рекламного_агентства_DataSet.Список_заказов". При необходимости она может быть перемещена или удалена.
            this.список_заказовTableAdapter.Fill(this._БД_Рекламного_агентства_DataSet.Список_заказов);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            список_заказовBindingSource.Filter = "[Отметка_об_оплате] = " + checkBox1.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            список_заказовBindingSource.Filter = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
