using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace IgniteFitnessTracker
{
    
    public partial class Login : Form
    {
        private int loginAttempts = 0;

        public Login()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Open sign up form
            Signup signup = new Signup();
            signup.Show();
            this.Close();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            // Checks number of login attempts and locks user with too many failed attempts
            loginAttempts++;
            if (loginAttempts < 3)
            {
                StreamReader input;
                string filename = "users.txt";
                string path = Path.Combine(Environment.CurrentDirectory.Remove(Environment.CurrentDirectory.Length - 9), filename);

                input = new StreamReader(path);
                string name = input.ReadLine();
                string username = input.ReadLine();
                string password = input.ReadLine();

                
                   if (username == usernameText.Text && password == passwordText.Text)
                    {
                    MessageBox.Show("Login Successful");
                    Dashboard dashboard = new Dashboard();
                        dashboard.Show();
                    
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Credentials");
                    }



                input.Close();
            }
            else
            {
                MessageBox.Show("Account Locked");
            }


        }



        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
