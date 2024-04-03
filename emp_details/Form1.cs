using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace emp_details
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblpan_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            int empid = int.Parse(txtempid.Text);
            string empname = txtname.Text;
            string PAN = txtpan.Text;
            string address = txtadd.Text;
            string email = txtemailid.Text;
            int contact = int.Parse(txtcontact.Text);
            SqlConnection con;
            try
            {
                con = new SqlConnection("Data Source=.\\sqlexpress;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
                con.Open();
                string qry = "insert into employee_detail values(" + empid + ",'" + empname + "','" + PAN + "','" + address + "','" + email + "'," + contact + ")";

                SqlCommand Command = new SqlCommand(qry,con);
                int n=Command.ExecuteNonQuery();
                if (n > 0)
                {
                    MessageBox.Show("Successfully Inserted.........");
                }
                else
                {
                    MessageBox.Show("Not Inserted!!!!!!!!");
                }
                con.Close();
            }
            catch (Exception ex)
            {
                 MessageBox.Show(ex.Message);
            }
            
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            int empid = int.Parse(txtempid.Text);
            
            SqlConnection con;
            try
            {
                con = new SqlConnection("Data Source=.\\sqlexpress;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
                con.Open();
                string qry = "delete from employee_detail where emp_id="+empid;

                SqlCommand Command = new SqlCommand(qry, con);
                int n = Command.ExecuteNonQuery();
                if (n > 0)
                {
                    MessageBox.Show("Successfully Deleted.........");
                }
                else
                {
                    MessageBox.Show("Not Deleted!!!!!!!!");
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
