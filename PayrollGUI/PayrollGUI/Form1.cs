using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btcCalculate_Click(object sender, EventArgs e)
        {
            double newSalary;

            newSalary = Convert.ToDouble(txtEntry1.Text) * 1.04;

            txtResult.Text = "" +newSalary;

        }

        private void txtResult_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
