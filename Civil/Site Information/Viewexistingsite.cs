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
    public partial class Viewexistingsite : Form
    {
        public Viewexistingsite()
        {
            InitializeComponent();
        }

        private void Viewexistingsite_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cividatanewDataSet8.newsite' table. You can move, or remove it, as needed.
            this.newsiteTableAdapter1.Fill(this.cividatanewDataSet8.newsite);
            // TODO: This line of code loads data into the 'cividatanewDataSet.newsite' table. You can move, or remove it, as needed.
            this.newsiteTableAdapter.Fill(this.cividatanewDataSet.newsite);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            info inf = new info();
            inf.Show();
        }
    }
}
