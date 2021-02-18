using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RatingApp
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (Username.Text.Equals("NEYMARJR") && Password.Text.Equals("bikram802"))
            {
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
                ShowMessage();
            }
            else
                MessageBox.Show("Please enter valid Usernmae or Password");
        }

        public void ShowMessage()
        {
            MessageBox.Show("You have enter right UserName and Password, please process to main page");
        }

        private void Username_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
