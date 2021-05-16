using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Civil
{
    public partial class addemployee : Form
    {
        public addemployee()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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
            SqlCommand cmd = new SqlCommand("insert into employee values (" + textBox1.Text + ", '" + textBox2.Text + "' ,'" + textBox3.Text + "' ,'" + textBox4.Text + "','" + textBox5.Text+ "','" + dateTimePicker1.Text + "' ," + textBox7.Text + " ) ", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("recored inserted");
            con.Close();
        }

        private void addemployee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cividatanewDataSet1.employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.cividatanewDataSet1.employee);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            string eID = textBox1.Text;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=BHUSHAN-PC;Initial Catalog=cividatanew;User ID=sa;Password=sa";
                con.Open();
                SqlCommand cmd = new SqlCommand("delete from  employee where employeeid=('" + textBox1.Text + "')", con);
                //   
                cmd.ExecuteNonQuery();
                MessageBox.Show("recored deleted");
                con.Close();
            
        }
    }
}
