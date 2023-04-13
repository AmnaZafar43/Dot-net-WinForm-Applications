using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hms
{
    public partial class signIn : Form
    {
        public signIn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {           
            string userName = textBox1.Text;
            string password = textBox2.Text;           
            if (userName == "admin" && password == "321")
            {
                DialogResult result = MessageBox.Show("You are logged in as Admin", "Message", MessageBoxButtons.OKCancel);
                if(result == DialogResult.OK)
                {
                    Admin myForm = new Admin();
                    myForm.ShowDialog();
                }               
            }
            else if (userName == "doctor" && password == "321")
            {
                DialogResult result = MessageBox.Show("You are logged in as Doctor", "Message", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    Doctor myForm = new Doctor();
                    myForm.ShowDialog();
                }
            }
            else if(userName == "patient" && password == "321")
            {
                DialogResult result = MessageBox.Show("You are logged in as Patient", "Message", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    Patient myForm = new Patient();
                    myForm.ShowDialog();
                }
            }
            else
            {
                DialogResult result = MessageBox.Show("Invalid User", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);               
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }

        private void signIn_Load(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
