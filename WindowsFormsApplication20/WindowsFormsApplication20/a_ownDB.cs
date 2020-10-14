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
    public partial class a_ownDB : Form
    {
        private SqlConnection conn;
        private SqlDataAdapter da;
        private DataTable dt;

        public a_ownDB()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(@"Data Source=KA-CHENG\SQLEXPRESS;Initial Catalog=OwnDB;Integrated Security=True");
            conn.Open();
            string cmd = "Select * from OwnerData";
            da = new SqlDataAdapter(cmd, conn);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
