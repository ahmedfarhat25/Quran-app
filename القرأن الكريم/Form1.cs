using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
namespace القرأن_الكريم
{
    public partial class SIgninandupform : Form
    {
        public SIgninandupform()
        {
            InitializeComponent();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
        private void ShowPass(Guna2TextBox txtxpassword)
        {
            if (txtxpassword is null)
            {
                throw new ArgumentNullException(nameof(txtxpassword));
            }

            if (txtpassword.UseSystemPasswordChar == true)
            {
                txtpassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtpassword.UseSystemPasswordChar = true;
            }
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox3_Click(object sender, EventArgs e)
        {
            ShowPass(passtextboxsignin);
        }

        private void guna2CirclePictureBox5_Click(object sender, EventArgs e)
        {
            ShowPass(repasswordtextboxsignup);
        }

        private void guna2CirclePictureBox4_Click(object sender, EventArgs e)
        {
            ShowPass(passwordtextboxsignup);
        }
     
    }
}
