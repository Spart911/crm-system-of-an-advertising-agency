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
    public partial class Form16 : Form
    {
        public Form16()
        {
            InitializeComponent();
        }

        private void дополнительные_услугиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.дополнительные_услугиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._БД_Рекламного_агентства_DataSet);

        }

        private void Form16_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_БД_Рекламного_агентства_DataSet.Дополнительные_услуги". При необходимости она может быть перемещена или удалена.
            this.дополнительные_услугиTableAdapter.Fill(this._БД_Рекламного_агентства_DataSet.Дополнительные_услуги);

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
                    дополнительные_услугиDataGridView.Sort(Col, System.ComponentModel.ListSortDirection.Ascending);
                }
                else
                {
                    дополнительные_услугиDataGridView.Sort(Col, System.ComponentModel.ListSortDirection.Descending);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            дополнительные_услугиBindingSource.Filter = "[Наименование]='" + comboBox1.Text + "'";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            дополнительные_услугиBindingSource.Filter = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int i = 0;
            int j = 0;

            for (i = 0; i < дополнительные_услугиDataGridView.ColumnCount; i++)
            {
                for (j = 0; j < дополнительные_услугиDataGridView.RowCount; j++)
                {
                    дополнительные_услугиDataGridView.Rows[j].Cells[i].Style.BackColor = Color.White;
                    дополнительные_услугиDataGridView.Rows[j].Cells[i].Style.ForeColor = Color.Black;
                }
            }
            for (i = 0; i < дополнительные_услугиDataGridView.ColumnCount; i++)
            {
                for (j = 0; j < дополнительные_услугиDataGridView.RowCount; j++)
                {
                    var value = дополнительные_услугиDataGridView.Rows[j].Cells[i].Value;
                    if (value != null)
                    {
                        string baseStr = value.ToString();
                        if (baseStr.IndexOf(textBox1.Text) > -1)
                        {
                            дополнительные_услугиDataGridView.Rows[j].Cells[i].Style.BackColor = Color.Aqua;
                            дополнительные_услугиDataGridView.Rows[j].Cells[i].Style.ForeColor = Color.Blue;


                        }
                    }
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void дополнительные_услугиDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    
}
