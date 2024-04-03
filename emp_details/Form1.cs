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
            SqlConnection con = new SqlConnection("");
            con.Open();
            SqlConnection Command = new SqlCommand("insert into employee_detail values("+int.Parse(txtempid.text)+"','" int.Parse(txtname.text)'"')");
            MessageBox.Show("Successfully Inserted");
            con.Close();
        }
    }
}
