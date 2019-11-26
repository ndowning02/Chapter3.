using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloVisualWorld
{
    public partial class HelloVisualWorld : Form
    {
        public HelloVisualWorld()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HelloLabel.Text = "Goodbye";
        }

        private void HelloLabel_Click(object sender, EventArgs e)
        {

        }

        private void btn_goodBye_Click(object sender, EventArgs e)
        {
            HelloLabel.Visible = false;
        }
    }
}
