﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MadLibsGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string madLib;

            madLib = "The " + "Dragon is the " + (txtEst.Text) + " Dragon of all. It has " + (txtNum1.Text) + " " + (txtBodyPartPlural.Text) + ", and a " + (txtAnimal.Text) + " shaped like a  " + (txtNoun.Text) + ". It loves to eat " + (txtPluralNoun.Text) +
                 " , although it will feast on nearly anything. ";

         

            lblResult.Text = madLib;
        }
    }
}
