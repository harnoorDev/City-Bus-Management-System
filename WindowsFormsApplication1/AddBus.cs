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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox5.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox2.Text.Equals("") || textBox1.Text.Equals("") || textBox3.Text.Equals("") || textBox4.Text.Equals("") || textBox5.Text.Equals(""))

            {
                MessageBox.Show("Please fill all boxes!");
            }
            else
            {
                string path = textBox5.Text+".txt";

                if (!File.Exists((path)))
                {
                    
                    bus buses = new bus();
                    buses.setBusNo(textBox5.Text);
                    buses.setTransit(textBox4.Text);
                    buses.setFare(textBox3.Text);
                    buses.setRoute(textBox2.Text);
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        
                        sw.WriteLine("BUS NUMBER : "+    textBox5.Text);
                        sw.WriteLine("TRANSIT  : "+textBox4.Text);
                        sw.WriteLine("FARE   : "+textBox3.Text);
                        sw.WriteLine("ROUTE NAME : "+textBox2.Text);
                        sw.WriteLine("TIME : FROM:"+textBox1.Text+"  TO: "+textBox0.Text);
                        MessageBox.Show("Record Added");
                        textBox4.Text = " ";
                        textBox5.Text = " ";
                        textBox3.Text = " ";
                        textBox1.Text = " ";
                        textBox2.Text = " ";
                        textBox0.Text = " ";

                        Form ad = new addDriver();
                        ad.Owner = this;
                        ad.Show();
                        this.Hide();

                            
                       
                    }
                }

                else
                {
                    MessageBox.Show("Record already added !");

                }
                        

                }
                
            }
        


      

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
       
    
