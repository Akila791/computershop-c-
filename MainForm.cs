using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Techfix_App
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Order orderForm = new Order();


            orderForm.Show();


            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Inventory inventoryForm = new Inventory();

            inventoryForm.Show();


            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Report reportForm = new Report();


            reportForm.Show();

            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Quote quoteForm = new Quote();

            quoteForm.Show();


            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
