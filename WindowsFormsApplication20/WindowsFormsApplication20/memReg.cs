using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace CSC330_CSharp_Midterm
{
    public partial class memReg : Form
    {
        public memReg()
        {
            InitializeComponent();
        }

        private void buttonReg_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int id = rnd.Next();
            SqlConnection conn = new SqlConnection(@"Data Source=KA-CHENG\SQLEXPRESS;Initial Catalog=MemDB;Integrated Security=True");
            conn.Open();
            string cmd = "INSERT INTO MemData (Id,Full_Name,Date_of_Birth,Address,Height,Weight,Fitness_Aspirations) VALUES ('"+ id + "','" + textBox1.Text + "','" + dateTimePicker1.Text + "','" +  textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + richTextBox1.Text + "')";
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn);
            da.SelectCommand.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Register Succeed");
            textBox1.Clear();
            dateTimePicker1.ResetText();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            richTextBox1.Clear();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
