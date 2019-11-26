using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EggsInteractive
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int eggsTotal;
            int dozenEggs = 12;
            int numDozen;
            int numEggsRemaining;

            eggsTotal = Convert.ToInt32(txt1.Text) + Convert.ToInt32(txt2.Text) +
                Convert.ToInt32(txt3.Text) + Convert.ToInt32(txt4.Text) +
                Convert.ToInt32(txt5.Text);

            numDozen = eggsTotal / dozenEggs;
            numEggsRemaining = eggsTotal % dozenEggs;

            lblResult.Text = eggsTotal + " eggs is " + numDozen + " dozen with " + numEggsRemaining + " eggs left over. ";
       
        }
    }
}
