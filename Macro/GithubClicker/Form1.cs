using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GithubClicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void cyberButton1_Click(object sender, EventArgs e)
        {
            MainForm MainForm= new MainForm();

            // Abra o formulário "Click1"
            MainForm.Show();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            foreach (Control currentControl in Controls) /* for each Control that we get in Controls */
            {
                currentControl.Dispose(); /* dispose all Control that are in Conrols */
            }

            Task.Delay(100).Wait();

            Dispose();
            Environment.Exit(0); /* exit */
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
