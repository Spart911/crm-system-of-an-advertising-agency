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
    public partial class Form17 : Form
    {
        public Form17()
        {
            InitializeComponent();
        }

        private void места_расположенияBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.места_расположенияBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._БД_Рекламного_агентства_DataSet);

        }

        private void Form17_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_БД_Рекламного_агентства_DataSet.Места_расположения". При необходимости она может быть перемещена или удалена.
            this.места_расположенияTableAdapter.Fill(this._БД_Рекламного_агентства_DataSet.Места_расположения);

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
                        dataGridViewTextBoxColumn6;
                        break;
                }
                if (radioButton1.Checked)
                {
                    места_расположенияDataGridView.Sort(Col, System.ComponentModel.ListSortDirection.Ascending);
                }
                else
                {
                    места_расположенияDataGridView.Sort(Col, System.ComponentModel.ListSortDirection.Descending);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            места_расположенияBindingSource.Filter = "[Наименование]='" + comboBox1.Text + "'";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            места_расположенияBindingSource.Filter = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int i = 0;
            int j = 0;

            for (i = 0; i < места_расположенияDataGridView.ColumnCount; i++)
            {
                for (j = 0; j < места_расположенияDataGridView.RowCount; j++)
                {
                    места_расположенияDataGridView.Rows[j].Cells[i].Style.BackColor = Color.White;
                    места_расположенияDataGridView.Rows[j].Cells[i].Style.ForeColor = Color.Black;
                }
            }
            for (i = 0; i < места_расположенияDataGridView.ColumnCount; i++)
            {
                for (j = 0; j < места_расположенияDataGridView.RowCount; j++)
                {
                    var value = места_расположенияDataGridView.Rows[j].Cells[i].Value;
                    if (value != null)
                    {
                        string baseStr = value.ToString();
                        if (baseStr.IndexOf(textBox1.Text) > -1)
                        {
                            места_расположенияDataGridView.Rows[j].Cells[i].Style.BackColor = Color.Aqua;
                            места_расположенияDataGridView.Rows[j].Cells[i].Style.ForeColor = Color.Blue;


                        }
                    }
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
