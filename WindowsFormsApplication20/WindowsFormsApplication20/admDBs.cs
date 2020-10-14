using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSC330_CSharp_Midterm
{
    public partial class admDBs : Form
    {
        public admDBs()
        {
            InitializeComponent();
        }

        private void buttonOwnerDB_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (a_ownDB ownDB = new a_ownDB())
                ownDB.ShowDialog();
            this.Show();
        }

        private void buttonEmpDB_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (a_empDB empDB = new a_empDB())
                empDB.ShowDialog();
            this.Show();
        }

        private void buttonGuestDB_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (a_guestDB guestDB = new a_guestDB())
                guestDB.ShowDialog();
            this.Show();
        }

        private void buttonMemDB_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (a_memDB memDB = new a_memDB())
                memDB.ShowDialog();
            this.Show();
        }

        private void buttonEquipDB_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (a_equDB equDB = new a_equDB())
                equDB.ShowDialog();
            this.Show();
        }
    }
}
