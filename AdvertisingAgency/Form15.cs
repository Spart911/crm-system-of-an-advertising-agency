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
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
        }

        private void виды_рекламыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.виды_рекламыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._БД_Рекламного_агентства_DataSet);

        }

        private void Form15_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_БД_Рекламного_агентства_DataSet.Виды_рекламы". При необходимости она может быть перемещена или удалена.
            this.виды_рекламыTableAdapter.Fill(this._БД_Рекламного_агентства_DataSet.Виды_рекламы);

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
                        dataGridViewTextBoxColumn2;
                        break;

                    case 1:
                        Col =
                        dataGridViewTextBoxColumn3;
                        break;
                }
                if (radioButton1.Checked)
                {
                    виды_рекламыDataGridView.Sort(Col, System.ComponentModel.ListSortDirection.Ascending);
                }
                else
                {
                    виды_рекламыDataGridView.Sort(Col, System.ComponentModel.ListSortDirection.Descending);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            виды_рекламыBindingSource.Filter = "[Наименование]='" + comboBox1.Text + "'";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            виды_рекламыBindingSource.Filter = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int i = 0;
            int j = 0;

            for (i = 0; i < виды_рекламыDataGridView.ColumnCount; i++)
            {
                for (j = 0; j < виды_рекламыDataGridView.RowCount; j++)
                {
                    виды_рекламыDataGridView.Rows[j].Cells[i].Style.BackColor = Color.White;
                    виды_рекламыDataGridView.Rows[j].Cells[i].Style.ForeColor = Color.Black;
                }
            }
            for (i = 0; i < виды_рекламыDataGridView.ColumnCount; i++)
            {
                for (j = 0; j < виды_рекламыDataGridView.RowCount; j++)
                {
                    var value = виды_рекламыDataGridView.Rows[j].Cells[i].Value;
                    if (value != null)
                    {
                        string baseStr = value.ToString();
                        if (baseStr.IndexOf(textBox1.Text) > -1)
                        {
                            виды_рекламыDataGridView.Rows[j].Cells[i].Style.BackColor = Color.Aqua;
                            виды_рекламыDataGridView.Rows[j].Cells[i].Style.ForeColor = Color.Blue;


                        }
                    }
                }
            }
        }

        private void виды_рекламыDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
