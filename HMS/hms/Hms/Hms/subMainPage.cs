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
    public partial class subMainPage : Form
    {
        public subMainPage()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                signIn myForm = new signIn();
                myForm.ShowDialog();
            }
            else if(radioButton2.Checked)
            {
                signIn myForm = new signIn();
                myForm.ShowDialog();
            }
            else if(radioButton3.Checked)
            {
                signIn myForm = new signIn();
                myForm.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
