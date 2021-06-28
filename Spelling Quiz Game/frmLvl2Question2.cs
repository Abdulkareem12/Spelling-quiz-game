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
    public partial class frmLvl2Question2 : Form
    {
        public frmLvl2Question2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblcheck.Text = "You are correct! Click next to continue.";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblcheck.Text = "You are incorrect! Click next to continue.";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lblcheck.Text = "You are incorrect! Click next to continue.";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lblcheck.Text = "You are incorrect! Click next to continue.";
        }

        private void lblNext_Click(object sender, EventArgs e)
        {
            frmLvl2Question3 f2 = new frmLvl2Question3();
            f2.ShowDialog();
        }
    }
}
