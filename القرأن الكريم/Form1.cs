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
    public partial class Signinandupform : Form
    {
        public Signinandupform()
        {
            InitializeComponent();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
        private void ShowPass(Guna2TextBox txtpassword)
        {
            if (txtpassword is null)
            {
                throw new ArgumentNullException(nameof(txtpassword));
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
// audio form 
// play sound finction for any quran audio in user pc 
// reading form 
// categories the mushaf to 30 part and n quartares and  

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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void signupbutton_Click(object sender, EventArgs e)
        {

        }

        private void signupbtn_Click(object sender, EventArgs e)
        {
            if(panel.Dock== DockStyle.Right)
            {
                panel.Dock = DockStyle.Left;
                slidebtn.Text = " SIGN IN";

            }
            else
            {
                panel.Dock = DockStyle.Right;
                slidebtn.Text = " SIGN UP";
            }
        }
    }
}
