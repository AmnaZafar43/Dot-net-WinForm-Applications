﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SignApplication.BL;
using SignApplication.DL;
using System.Windows.Forms;

namespace SignApplication
{
    public partial class SignInSignUp : Form
    {
        public SignInSignUp()
        {
            InitializeComponent();
            string path = "sign.txt";
            if(mUserDL.loadFromFile(path))
            {
                MessageBox.Show("Data loaded successfully.");
            }
            else
            {
                MessageBox.Show("Not loaded successfully.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                signIn myForm = new signIn();
                myForm.ShowDialog();
            }
            else if(radioButton2.Checked)
            {
                signUp myf = new signUp();
                myf.ShowDialog();
            }
            else if(radioButton3.Checked)
            {
                this.Close();
            }
        }
    }
}
