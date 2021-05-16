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
    public partial class addsite : Form
    {
        public addsite()
        {
            InitializeComponent();
        }

        private void addsite_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=BHUSHAN-PC;Initial Catalog=cividatanew;User ID=sa;Password=sa";
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into newsite values ("+textBox6.Text+",'" + textBox1.Text + "', '" + textBox2.Text + "' ,"+textBox3.Text+  " ,'"+textBox4.Text+  "','"+comboBox1.Text  +"',"+comboBox2.Text  +" ,"+textBox5.Text  +" ,'"+dateTimePicker1.Text  +"' ,'"+comboBox3.Text  +"' ) ", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("recored inserted");
                con.Close();
 
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection();
            //con.ConnectionString = "Data Source=BHUSHAN-PC;Initial Catalog=cividatanew;User ID=sa;Password=sa";
            //con.Open();
            //SqlCommand cmd = new SqlCommand("upadte newsite set ( '" + textBox2.Text + "' ," + textBox3.Text + " ,'" + textBox4.Text + "','" + comboBox1.Text + "'," + comboBox2.Text + " ," + textBox5.Text + " ,'" + dateTimePicker1.Text + "' ,'" + comboBox3.Text + "'  where sitename= '"textBox1.Text"' ) , con);
            //cmd.ExecuteNonQuery();
            //MessageBox.Show("recored inserted");
            //con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            info inf = new info();
            inf.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=BHUSHAN-PC;Initial Catalog=cividatanew;User ID=sa;Password=sa";
            con.Open();
            SqlCommand cmd = new SqlCommand("delete from newsite where siteid= (" + textBox6.Text + ")", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("recored deleted");
            con.Close();
 
        }
    }
}
