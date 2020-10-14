using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CSC330_CSharp_Midterm
{
    public partial class guestReg : Form
    {
        public guestReg()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonTrial_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=KA-CHENG\SQLEXPRESS;Initial Catalog=GuestDB;Integrated Security=True");
            conn.Open();
            string cmd = "INSERT INTO GuestData (Full_Name,Date_of_Birth,Address) VALUES ('" + textBox1.Text + "','" + dateTimePicker1.Text + "','" + textBox2.Text + "')";
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn);
            da.SelectCommand.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Register Succeed");
            textBox1.Clear();
            dateTimePicker1.ResetText();
            textBox2.Clear();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
