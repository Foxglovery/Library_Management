using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void usernameTxtBox_MouseEnter(object sender, EventArgs e)
        {
           
        }

        private void usernameTxtBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (usernameTxtBox.Text == "Username")
            {
                usernameTxtBox.Clear();
            }
        }

        private void passwordTxtBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (passwordTxtBox.Text == "Password")
            {
                passwordTxtBox.Clear();
                passwordTxtBox.PasswordChar = '*';
            }
        }
    }
}
