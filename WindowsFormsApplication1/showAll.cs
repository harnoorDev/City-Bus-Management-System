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
    public partial class showAll : Form
    {
        public showAll()
        {
            InitializeComponent();
        }

       

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            textBox_details.Text = "";
            progressBar1.Value = 0;
            if (txtBox_busNo.Text.Equals(""))
            {
                MessageBox.Show("Please fill  the box ");
            }
            else
            {
                    string path = txtBox_busNo.Text + ".txt";
                    if (!File.Exists(path))
                    {

                        MessageBox.Show("There is no Bus with that Number");
                    }
                    else
                    {
                    progressBar1.Value = 100;
                    string readtext = File.ReadAllText(path);
                        textBox_details.Text = readtext;

                    }
                }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
          
        }
    }
}
