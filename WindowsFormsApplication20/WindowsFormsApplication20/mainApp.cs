// https://stackoverflow.com/questions/3005732/showing-a-hidden-form
// https://stackoverflow.com/questions/13233451/how-to-show-a-form-again-after-hiding-it
// https://www.youtube.com/watch?v=cbGLRlkHoMg - Using sql database to class

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
    public partial class mainApp : Form
    {
        public mainApp()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //guestReg guestForm = new guestReg();
            //guestForm.Show();
            //this.Hide();

            this.Hide();
            using (guestReg guestForm = new guestReg())
                guestForm.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //memReg memForm = new memReg();
            //memForm.Show();

            this.Hide();
            using (memReg memForm = new memReg())
                memForm.ShowDialog();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (admLogin admLog = new admLogin())
                admLog.ShowDialog();
            this.Show();
        }
    }
}
