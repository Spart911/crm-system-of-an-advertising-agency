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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        private void заказчикиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.заказчикиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._БД_Рекламного_агентства_DataSet);

        }

        private void Form14_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_БД_Рекламного_агентства_DataSet.Заказчики". При необходимости она может быть перемещена или удалена.
            this.заказчикиTableAdapter.Fill(this._БД_Рекламного_агентства_DataSet.Заказчики);

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
                        dataGridViewTextBoxColumn3;
                        break;

                    case 1:
                        Col =
                        dataGridViewTextBoxColumn4;
                        break;
                }
                if (radioButton1.Checked)
                {
                    заказчикиDataGridView.Sort(Col, System.ComponentModel.ListSortDirection.Ascending);
                }
                else
                {
                    заказчикиDataGridView.Sort(Col, System.ComponentModel.ListSortDirection.Descending);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            заказчикиBindingSource.Filter = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int i = 0;
            int j = 0;

            for (i = 0; i < заказчикиDataGridView.ColumnCount; i++)
            {
                for (j = 0; j < заказчикиDataGridView.RowCount; j++)
                {
                    заказчикиDataGridView.Rows[j].Cells[i].Style.BackColor = Color.White;
                    заказчикиDataGridView.Rows[j].Cells[i].Style.ForeColor = Color.Black;
                }
            }
            for (i = 0; i < заказчикиDataGridView.ColumnCount; i++)
            {
                for (j = 0; j < заказчикиDataGridView.RowCount; j++)
                {
                    var value = заказчикиDataGridView.Rows[j].Cells[i].Value;
                    if (value != null)
                    {
                        string baseStr = value.ToString();
                        if (baseStr.IndexOf(textBox1.Text) > -1)
                        {
                            заказчикиDataGridView.Rows[j].Cells[i].Style.BackColor = Color.Aqua;
                            заказчикиDataGridView.Rows[j].Cells[i].Style.ForeColor = Color.Blue;


                        }
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            заказчикиBindingSource.Filter = "[ФИО]='" + comboBox1.Text + "'";
        }
    }
}
