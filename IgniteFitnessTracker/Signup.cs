using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IgniteFitnessTracker
{
    public partial class Signup : Form
    {
        

        public Signup()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Open login form
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void signupButton_Click(object sender, EventArgs e)
        {
            // Guard conditions for user input
            if (nameText.Text == "")
            {
                MessageBox.Show("Enter a valid name");
            }
            if (usernameText.Text == "")
            {
                MessageBox.Show("Enter a valid username");
            }
            if (passwordText.Text == "" || passwordText.Text.Length < 12 || passwordText.Text.ToLower() == passwordText.Text || passwordText.Text.ToUpper() == passwordText.Text)
            {
                MessageBox.Show("Password must be of length 12 characters and contain 1 lowercase and 1 uppercase letter");
            }
            if (ageText.Value < 18)
            {
                MessageBox.Show("Must be at least 18 years old");
            }
            if (genderText.Text == "")
            {
                MessageBox.Show("Enter a valid gender");
            }

            if (nameText.Text != "" && usernameText.Text != "" && passwordText.Text != "" && passwordText.Text.Length >= 12 && passwordText.Text.ToLower() != passwordText.Text && passwordText.Text.ToUpper() != passwordText.Text && ageText.Value >= 18 && genderText.Text != "")
            {

                // Creates a new user and path for saving the user
                User user = new User(nameText.Text, usernameText.Text, passwordText.Text, Decimal.ToInt32(ageText.Value), genderText.Text);
                StreamWriter output;
                string filename = "users.txt";
                string path = Path.Combine(Environment.CurrentDirectory.Remove(Environment.CurrentDirectory.Length - 9), filename);

                // Saves user data in .txt file 
                output = new StreamWriter(path);
                output.WriteLine(user.Name);
                output.WriteLine(user.Username);
                output.WriteLine(user.Password);
                output.WriteLine(user.Age.ToString());
                output.WriteLine(user.Gender);
                output.Close();

                // Clear activities for new user
                filename = "activities.txt";
                path = Path.Combine(Environment.CurrentDirectory.Remove(Environment.CurrentDirectory.Length - 9), filename);
                output = new StreamWriter(path);
                output.WriteLine(string.Empty);
                output.Close();

                // Clear calorie goal for new user
                filename = "calorieGoal.txt";
                path = Path.Combine(Environment.CurrentDirectory.Remove(Environment.CurrentDirectory.Length - 9), filename);
                output = new StreamWriter(path);
                output.WriteLine("0");
                output.Close();

                // Open login form
                MessageBox.Show("Account created successfully");
                Login login = new Login();
                login.Show();
                this.Close();
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
