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
    public partial class Form24 : Form
    {
        public Form24()
        {
            InitializeComponent();
        }

        private void Form24_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_БД_Рекламного_агентства_DataSet.Виды_рекламы". При необходимости она может быть перемещена или удалена.
            this.виды_рекламыTableAdapter.Fill(this._БД_Рекламного_агентства_DataSet.Виды_рекламы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_БД_Рекламного_агентства_DataSet.Список_мест". При необходимости она может быть перемещена или удалена.
            this.список_местTableAdapter.Fill(this._БД_Рекламного_агентства_DataSet.Список_мест);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            список_местBindingSource.Filter = "[Виды_рекламы_Наименование]='" + comboBox1.Text + "'";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            список_местBindingSource.Filter = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
