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
    public partial class Form19 : Form
    {
        public Form19()
        {
            InitializeComponent();
        }

        private void Form19_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_БД_Рекламного_агентства_DataSet.Список_мест". При необходимости она может быть перемещена или удалена.
            this.список_местTableAdapter.Fill(this._БД_Рекламного_агентства_DataSet.Список_мест);

        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.список_местBindingSource.MoveFirst();
        }

  





        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.список_местBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this._БД_Рекламного_агентства_DataSet);

                MessageBox.Show("Update Successful");
            }
            catch (System.Exception)
            {
                MessageBox.Show("Update failed");
            }
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            this.список_местBindingSource.MoveLast();
        }

        private void button16_Click_1(object sender, EventArgs e)
        {
            this.список_местBindingSource.MovePrevious();
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            this.список_местBindingSource.MoveNext();
        }

        private void button15_Click_1(object sender, EventArgs e)
        {
            this.список_местBindingSource.AddNew();
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            this.список_местBindingSource.RemoveCurrent();
        }
    }
}
