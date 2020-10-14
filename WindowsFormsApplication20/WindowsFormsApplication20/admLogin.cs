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
    public partial class admLogin : Form
    {
        public admLogin()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if ((tboxName.Text == string.Empty) || (tboxPassword.Text == string.Empty))
            {
                MessageBox.Show("Please enter data in both fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlConnection conn = new SqlConnection(@"Data Source=KA-CHENG\SQLEXPRESS;Initial Catalog=OwnDB;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");
                string cmd = "Select * from OwnerData where Username='" + tboxName.Text + "' and Password = '" + tboxPassword.Text + "'";
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd,conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    tboxName.Clear();
                    tboxPassword.Clear();
                    this.Hide();
                    using (admDBs admDBshow = new admDBs())
                        admDBshow.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Uncorrect username or password");
                }
            }

        }

        private void tboxName_TextChanged(object sender, EventArgs e)
        {


        }

        private void tboxPassword_TextChanged(object sender, EventArgs e)
        {
            tboxPassword.PasswordChar = '*';
        }
    }
}
