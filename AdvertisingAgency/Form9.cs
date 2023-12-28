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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void места_расположенияBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.места_расположенияBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._БД_Рекламного_агентства_DataSet);

        }

        private void Form9_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_БД_Рекламного_агентства_DataSet.Места_расположения". При необходимости она может быть перемещена или удалена.
            this.места_расположенияTableAdapter.Fill(this._БД_Рекламного_агентства_DataSet.Места_расположения);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.места_расположенияBindingSource.MoveFirst();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.места_расположенияBindingSource.MovePrevious();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.места_расположенияBindingSource.AddNew();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.места_расположенияBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.места_расположенияBindingSource.MoveNext();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.места_расположенияBindingSource.RemoveCurrent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.места_расположенияBindingSource.EndEdit();
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
