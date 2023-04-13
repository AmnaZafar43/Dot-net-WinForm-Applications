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
    public partial class Patient : Form
    {
        public Patient()
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
                appointment myForm = new appointment();
                myForm.ShowDialog();
            }
            else if(radioButton2.Checked)
            {
                viewAppointment myForm = new viewAppointment();
                myForm.ShowDialog();
            }
            else if(radioButton3.Checked)
            {
                viewDoctor myForm = new viewDoctor();
                myForm.ShowDialog();
            }
            else if(radioButton4.Checked)
            {
                viewInstructions myForm = new viewInstructions();
                myForm.ShowDialog();
            }
            else if(radioButton5.Checked)
            {
                prescription myForm = new prescription();
                myForm.ShowDialog();
            }
            else if(radioButton6.Checked)
            {
                testDetail myForm = new testDetail();
                myForm.ShowDialog();
            }
            else if(radioButton7.Checked)
            {
                this.Close();
                this.Hide();
                subMainPage myForm = new subMainPage();
                myForm.ShowDialog();
            }
        }
    }
}
