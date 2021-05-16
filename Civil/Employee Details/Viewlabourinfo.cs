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
    public partial class Viewlabourinfo : Form
    {
        public Viewlabourinfo()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            addemployee ae = new addemployee();
            ae.Show();

  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            addfabricator af = new addfabricator();
            af.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            addelectricioan aele = new addelectricioan();
            aele.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            info asd =new info();
            asd.Show();


 
        }
    }
}
