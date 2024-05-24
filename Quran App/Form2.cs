using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using WMPLib;

namespace القرأن_الكريم
{
    public partial class ListeningForm : Form
    {
        public ListeningForm()
        {
            InitializeComponent();


        }

        private void ListeningForm_Load(object sender, EventArgs e)
        {

        }

        private void guna2ControlBox3_Click(object sender, EventArgs e)
        {

        }

        private void guna2ControlBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton1_Click_1(object sender, EventArgs e)
        {
            string filePath = @"D:\New folder\Problem Splving\file_example_MP3_700KB.wav";
            WindowsMediaPlayer player = new WindowsMediaPlayer();
            player.URL = filePath;
            player.controls.play();
        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void browsebtn_Click(object sender, EventArgs e)
        {
            string filePath = @"C:\Users\ahmed\Downloads\سورة يس كاملة بصوت الشيخ هيثم الدخين Haitham Aldokhin Surah Yasin.mp3";
            WindowsMediaPlayer player = new WindowsMediaPlayer();
            player.URL = filePath;
            player.controls.play();
        }
    }
}
