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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.textBox1.Text) || string.IsNullOrEmpty(this.textBox2.Text))
            {
                MessageBox.Show("provide User Name and Password");
            }

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=ANONYMOUS\\SQLEXPRESS;Initial Catalog=cdb;Integrated Security=True";
            con.Open();
            string username = textBox1.Text;
            string password = textBox2.Text;
            SqlCommand cmd = new SqlCommand("SELECT * FROM login WHERE username = '" + textBox1.Text + "' and password = '" + textBox2.Text + "' ", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            System.Data.SqlClient.SqlDataReader dr = null;
            dr = cmd.ExecuteReader();


            if (dr.Read())
            {
                if (this.textBox1.Text == dr["username"].ToString() && this.textBox2.Text == dr["password"].ToString())
                {
                    //MessageBox.Show("*** Login Successful ***");
                    this.Visible=false;
                   
                    info frm = new info();
                    frm.Show();

                }


            }

            else
            {
               // MessageBox.Show("Invalid UserName or Password", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show("Access Denied!!");

            }

            con.Close(); 
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'civildataDataSet.login' table. You can move, or remove it, as needed.
            this.loginTableAdapter.Fill(this.civildataDataSet.login);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
