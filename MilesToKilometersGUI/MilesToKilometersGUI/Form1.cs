using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilesToKilometersGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_convert_Click(object sender, EventArgs e)
        {
            
            double kilometersTotal;

            kilometersTotal = Convert.ToDouble(txtMiles.Text) * 1.6;

            txtKilometers.Text = ""+kilometersTotal;
        

        }
    }
}
