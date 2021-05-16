using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Civil
{
    public partial class info : Form
    {
        public info()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false; 
            addsite asd = new addsite();
            asd.Show(); 
 

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Viewexistingsite ves = new Viewexistingsite();
            ves.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Viewlabourinfo vli = new Viewlabourinfo();
            vli.Show(); 

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Viewvendorinfo vvi = new Viewvendorinfo();
            vvi.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
