using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CityBusManagement  
{
    public partial class DeleteBus : Form
    {
        public DeleteBus()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals(""))
            {
                MessageBox.Show("Please enter Bus Number ");


            }
            else
            {
                string path = textBox1.Text + ".txt";

                if (!File.Exists((path)))
                {
                    MessageBox.Show("There is no bus of this number !");
                }
                else
                {
                    File.Delete(path);
                    MessageBox.Show("Bus deleted Successfully !");
                }
            }
        }

        private void DeleteBus_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


    }
}


