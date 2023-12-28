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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void должностиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.должностиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._БД_Рекламного_агентства_DataSet);

        }

        private void Form12_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_БД_Рекламного_агентства_DataSet.Должности". При необходимости она может быть перемещена или удалена.
            this.должностиTableAdapter.Fill(this._БД_Рекламного_агентства_DataSet.Должности);

        }

        private void должностиDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int i = 0;
            int j = 0;

            for (i = 0; i < должностиDataGridView.ColumnCount; i++)
            {
                for (j = 0; j < должностиDataGridView.RowCount; j++)
                {
                    должностиDataGridView.Rows[j].Cells[i].Style.BackColor = Color.White;
                    должностиDataGridView.Rows[j].Cells[i].Style.ForeColor = Color.Black;
                }
            }
            for (i = 0; i < должностиDataGridView.ColumnCount; i++)
            {
                for (j = 0; j < должностиDataGridView.RowCount; j++)
                {
                    var value = должностиDataGridView.Rows[j].Cells[i].Value;
                    if (value != null)
                    {
                        string baseStr = value.ToString();
                        if (baseStr.IndexOf(textBox1.Text) > -1)
                        {
                            должностиDataGridView.Rows[j].Cells[i].Style.BackColor = Color.Aqua;
                            должностиDataGridView.Rows[j].Cells[i].Style.ForeColor = Color.Blue;


                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            должностиBindingSource.Filter = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            должностиBindingSource.Filter = "[Наименование_должности]='" + comboBox1.Text + "'";
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
                        dataGridViewTextBoxColumn5;
                        break;
                }
                if (radioButton1.Checked)
                {
                    должностиDataGridView.Sort(Col, System.ComponentModel.ListSortDirection.Ascending);
                }
                else
                {
                    должностиDataGridView.Sort(Col, System.ComponentModel.ListSortDirection.Descending);
                }
            }
        }
    }
}
