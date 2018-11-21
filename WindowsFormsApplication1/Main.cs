using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CityBusManagement
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form add = new Form1();

            add.Owner = this;
            add.Show();
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Form add = new addDriver();

            add.Owner = this;
            add.Show();
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form add = new DeleteBus();

            add.Owner = this;
            add.Show();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form add = new Update();

            add.Owner = this;
            add.Show();
           
        }

        private void button5_Click(object sender, EventArgs e)
        {

            Form add = new Recent();

            add.Owner = this;
            add.Show();
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form add = new showAll();

            add.Owner = this;
            add.Show();
        }
    }
}
