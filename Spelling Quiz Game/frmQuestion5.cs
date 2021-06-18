using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spelling_Quiz_Game
{
    public partial class frmQuestion5 : Form
    {
        public frmQuestion5()
        {
            InitializeComponent();
        }

        private void lblNext_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblcheck.Text = "You are correct! Click finish to return to levels page.";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblcheck.Text = "You are incorrect! Click finish to return to levels page.";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lblcheck.Text = "You are correct! Click finish to return to levels page.";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lblcheck.Text = "You are incorrect! Click finish to return to levels page.";
        }
    }
}
