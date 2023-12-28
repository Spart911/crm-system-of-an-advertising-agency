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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form18 frm = new Form18();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form19 frm = new Form19();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form20 frm = new Form20();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
