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
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
        }

        private void Update_Load(object sender, EventArgs e)
        {

        }

        private void button_update_Click(object sender, EventArgs e)
        {
            if (textBox_BusNo.Text.Equals("") || textBox_routeName.Text.Equals("") || textBox_newRouteName.Text.Equals(""))
            {
                MessageBox.Show("Please fill all the boxes ");
            }
            else
            {
                string path = textBox_BusNo.Text + ".txt";
                if (!File.Exists(path))
                    {

                    MessageBox.Show("There is no Bus with that Number");
                }
                else
                {
                    if (!File.ReadAllText(path).Contains(textBox_routeName.Text))
                    {
                        MessageBox.Show("There no route named " + textBox_routeName.Text + " in the bus ");
                    }
                    else
                    {
                        string text = File.ReadAllText(path);
                        //text = text.Replace(textBox_routeName.Text, textBox_newRouteName.Text);
                        bus.routeName = textBox_newRouteName.Text;

                        File.WriteAllText(path, text);
                        MessageBox.Show("Route Updated !");
                    }


                }
            }
        }

        
    }
}

