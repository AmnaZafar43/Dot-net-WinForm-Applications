using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SignApplication.BL;
using SignApplication.DL;

namespace SignApplication
{
    public partial class signIn : Form
    {
        public signIn()
        {
            InitializeComponent();
            string path = "sign.txt";
            DL.mUserDL.loadFromFile(path);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            for (int i = 0; i < DL.mUserDL.mUserList.Count; i++)
            {
                if (username == mUserDL.mUserList[i].UserName && password == mUserDL.mUserList[i].Password)
                {
                    MessageBox.Show("You are " + mUserDL.mUserList[i].Role);
                    break;
                }
                else
                {
                    MessageBox.Show("Invalid user");
                    break;
                }
            }
        }
    }
}
