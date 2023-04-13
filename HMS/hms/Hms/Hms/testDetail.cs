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
    public partial class testDetail : Form
    {
        public testDetail()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                CBC myForm = new CBC();
                myForm.ShowDialog();
            }
            if(radioButton2.Checked)
            {
                prothomTest myForm = new prothomTest();
                myForm.ShowDialog();
            }
            if(radioButton3.Checked)
            {
                metabollic myForm = new metabollic();
                myForm.ShowDialog();
            }
            if(radioButton4.Checked)
            {
                lapid myForm = new lapid();
                myForm.ShowDialog();
            }
            if(radioButton5.Checked)
            {
                cultures myForm = new cultures();
                myForm.ShowDialog();
            }
        }
    }
}
