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
            string name = txtname.Text;
            string pan = txtpan.Text;
            string address = txtadd.Text;
            string email = txtemailid.Text;
            int contact = int.Parse(txtcontact.Text);

          
            SqlConnection con = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=master;Integrated Security=True;TrustServerCertificate=True");
            try
            {
              
            con.Open();

            
            SqlCommand cmd = new SqlCommand();

            String qry = "insert into emp_details values(" + empid + ",'" + name + "','" + pan + "','" + address + "','" + email + "'," + contact + ")";
            cmd.Connection = con;
            cmd.CommandText = qry;
            cmd.CommandType = CommandType.Text;

            int n = cmd.ExecuteNonQuery();
            if (n > 0)
            {
                MessageBox.Show("Record inserted successfully....");
            }
            else
            {
                MessageBox.Show("Record NOT inserted .....");
            }
        }
            catch (Exception ex) 
            {
                MessageBox.Show("Exception :" + ex.Message);
            }
            finally
            {
                
                con.Close();
            }


        }
    }
}
