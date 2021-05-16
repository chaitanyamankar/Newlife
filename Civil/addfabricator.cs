using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Civil
{
    public partial class addfabricator : Form
    {
        public addfabricator()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Viewlabourinfo vli = new Viewlabourinfo();
            vli.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=BHUSHAN-PC;Initial Catalog=cividatanew;User ID=sa;Password=sa";
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into fabricator values ("+textBox6.Text+",'" + textBox1.Text + "', '" + textBox2.Text + "' ," + textBox3.Text + " ," + textBox4.Text + "," + textBox5.Text + " ) ", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("recored inserted");
            con.Close();
        }

        private void addfabricator_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cividatanewDataSet7.fabricator' table. You can move, or remove it, as needed.
            this.fabricatorTableAdapter1.Fill(this.cividatanewDataSet7.fabricator);
            // TODO: This line of code loads data into the 'cividatanewDataSet5.fabricator' table. You can move, or remove it, as needed.
            this.fabricatorTableAdapter.Fill(this.cividatanewDataSet5.fabricator);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=BHUSHAN-PC;Initial Catalog=cividatanew;User ID=sa;Password=sa";
            con.Open();
            SqlCommand cmd = new SqlCommand("delete from  fabricator where fabricatorid= (" + textBox6.Text + " ) ", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("recored Deleted");
            con.Close();
        }
    }
}
