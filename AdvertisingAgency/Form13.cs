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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void заказыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.заказыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._БД_Рекламного_агентства_DataSet);

        }

        private void Form13_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_БД_Рекламного_агентства_DataSet.Заказы". При необходимости она может быть перемещена или удалена.
            this.заказыTableAdapter.Fill(this._БД_Рекламного_агентства_DataSet.Заказы);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                System.Windows.Forms.DataGridViewColumn
                Col = default(System.Windows.Forms.DataGridViewColumn);
                switch (listBox1.SelectedIndex)
                {
                    case 0:
                        Col =
                        dataGridViewTextBoxColumn9;
                        break;

                    case 1:
                        Col =
                        dataGridViewTextBoxColumn10;
                        break;
                }
                if (radioButton1.Checked)
                {
                    заказыDataGridView.Sort(Col, System.ComponentModel.ListSortDirection.Ascending);
                }
                else
                {
                    заказыDataGridView.Sort(Col, System.ComponentModel.ListSortDirection.Descending);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
           заказыBindingSource.Filter = "[Дата_заказа]='" + comboBox1.Text + "'";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int i = 0;
            int j = 0;

            for (i = 0; i < заказыDataGridView.ColumnCount; i++)
            {
                for (j = 0; j < заказыDataGridView.RowCount; j++)
                {
                    заказыDataGridView.Rows[j].Cells[i].Style.BackColor = Color.White;
                    заказыDataGridView.Rows[j].Cells[i].Style.ForeColor = Color.Black;
                }
            }
            for (i = 0; i < заказыDataGridView.ColumnCount; i++)
            {
                for (j = 0; j < заказыDataGridView.RowCount; j++)
                {
                    var value = заказыDataGridView.Rows[j].Cells[i].Value;
                    if (value != null)
                    {
                        string baseStr = value.ToString();
                        if (baseStr.IndexOf(textBox1.Text) > -1)
                        {
                            заказыDataGridView.Rows[j].Cells[i].Style.BackColor = Color.Aqua;
                            заказыDataGridView.Rows[j].Cells[i].Style.ForeColor = Color.Blue;


                        }
                    }
                }
            }
    }

        private void button1_Click(object sender, EventArgs e)
        {
            заказыBindingSource.Filter = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
