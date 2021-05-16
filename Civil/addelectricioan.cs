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
    public partial class addelectricioan : Form
    {
        public addelectricioan()
        {
            InitializeComponent();
        }

        private void addelectricioan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cividatanewDataSet6.electricion' table. You can move, or remove it, as needed.
            this.electricionTableAdapter1.Fill(this.cividatanewDataSet6.electricion);
            // TODO: This line of code loads data into the 'cividatanewDataSet2.electricion' table. You can move, or remove it, as needed.
            this.electricionTableAdapter.Fill(this.cividatanewDataSet2.electricion);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=BHUSHAN-PC;Initial Catalog=cividatanew;User ID=sa;Password=sa";
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into electricion values ("+textBox5.Text+",'" + textBox1.Text + "', '" + textBox2.Text + "' ," + textBox3.Text + " ," + textBox4.Text + " ) ", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("recored inserted");
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Viewlabourinfo vli = new Viewlabourinfo();
            vli.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=BHUSHAN-PC;Initial Catalog=cividatanew;User ID=sa;Password=sa";
            con.Open();
            SqlCommand cmd = new SqlCommand("delete from electricion where electricionid= (" + textBox5.Text + " ) ", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("recored Deleted");
            con.Close();
        }
    }
}
