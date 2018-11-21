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
    public partial class addDriver : Form
    {
        public addDriver()
        {
            InitializeComponent();
            driver drive = new driver();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text.Equals("") || textBox2.Text.Equals("") || textBox3.Text.Equals("") || textBox4.Text.Equals(""))
            {

                MessageBox.Show("Please fill in all the boxes !");
            }
            else
            {
                string path = textBox4.Text + ".txt";
                if (!File.Exists(path))
                {
                    MessageBox.Show("the bus number does not exist ");
                    textBox4.Text = " ";


                }
                else
                {
                    driver drive = new driver();
                    drive.setID(textBox1.Text);
                    drive.setFirstName(textBox3.Text);
                    drive.setLastName(textBox2.Text);
                    using (StreamWriter sw = File.AppendText(path))
                    {   
                        sw.WriteLine("\n");
                        sw.WriteLine("Driver ");
                        sw.WriteLine("ID : " +textBox1.Text);
                        sw.WriteLine(" First Name : " + textBox3.Text);
                        sw.WriteLine("Last Name :" + textBox2.Text);
                        MessageBox.Show("Driver added Successfully ");
                        textBox1.Text = "";
                        textBox2.Text = "";
                        textBox3.Text = "";


                       
                    }
                    

                }

            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
                
            Form add = new Main();

            add.Owner = this;
            add.Show();
            this.Hide();
        }
    }
}
