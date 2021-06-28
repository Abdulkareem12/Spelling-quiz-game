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
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLevel1_Click(object sender, EventArgs e)
        {
            frmQuestion1 f1 = new frmQuestion1();
            f1.ShowDialog();
        }

        private void btnLevel2_Click(object sender, EventArgs e)
        {
            frmLvl2Question1 f2 = new frmLvl2Question1();
            f2.ShowDialog();
        }

        private void btnLevel3_Click(object sender, EventArgs e)
        {
            frmLvl3Question1 f3 = new frmLvl3Question1();
            f3.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Splashscreen splashform = new Splashscreen();
            splashform.ShowDialog();
        }
    }
}
