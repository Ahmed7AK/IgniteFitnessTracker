﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IgniteFitnessTracker
{
    
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }


        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Form1_Shown(object sender, EventArgs e)
        {

            
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
        }

        private void signupButton_Click(object sender, EventArgs e)
        {
            Signup signup = new Signup();
            signup.Show();
        }

        private void closeProgram_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
