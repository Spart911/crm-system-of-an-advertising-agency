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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void возрастLabel_Click(object sender, EventArgs e)
        {

        }

        private void виды_рекламыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.виды_рекламыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._БД_Рекламного_агентства_DataSet);

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_БД_Рекламного_агентства_DataSet.Виды_рекламы". При необходимости она может быть перемещена или удалена.
            this.виды_рекламыTableAdapter.Fill(this._БД_Рекламного_агентства_DataSet.Виды_рекламы);

        }

        private void код_видаTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.виды_рекламыBindingSource.MoveFirst();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.виды_рекламыBindingSource.MovePrevious();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.виды_рекламыBindingSource.AddNew();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.виды_рекламыBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.виды_рекламыBindingSource.MoveNext();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.виды_рекламыBindingSource.RemoveCurrent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.виды_рекламыBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this._БД_Рекламного_агентства_DataSet);

                MessageBox.Show("Update Successful");
            }
            catch (System.Exception)
            {
                MessageBox.Show("Update failed");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
