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
    public partial class Recent : Form
    {
        public Recent()
        {
            InitializeComponent();
        }

        private void Recent_Load(object sender, EventArgs e)
        {
            busno.Text = bus.busNo;
            route.Text = bus.routeName;
            id.Text = driver.ID;
            firstname.Text = driver.firstname;
            lastname.Text = driver.lastname;
        }
    }
}
