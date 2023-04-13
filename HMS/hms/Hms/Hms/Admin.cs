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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           if(radioButton1.Checked)
            {
                addDoctor myForm = new addDoctor();
                myForm.ShowDialog();
            }
            else if(radioButton2.Checked)
            {
                viewDoctor myForm = new viewDoctor();
                myForm.ShowDialog();
            }
            else if(radioButton3.Checked)
            {
                deleteDoctor myForm = new deleteDoctor();
                myForm.ShowDialog();
            }
            else if(radioButton4.Checked)
            {
                updateDoctor myForm = new updateDoctor();
                myForm.ShowDialog();
            }
            else if(radioButton5.Checked)
            {
                viewPatient myform = new viewPatient();               
                myform.ShowDialog();
            }
            else if(radioButton6.Checked)
            {
                deletePatient myform = new deletePatient();
                myform.ShowDialog();
            }
            else if(radioButton7.Checked)
            {
                testDetail myform = new testDetail();
                myform.ShowDialog();
            }
            else if(radioButton8.Checked)
            {
                viewAppointment myForm = new viewAppointment();
                myForm.ShowDialog();
            }
            else if(radioButton9.Checked)
            {
                viewInstructions myform = new viewInstructions();
                myform.ShowDialog();
            }
            else if(radioButton10.Checked)
            {
                this.Close();
                this.Hide();
                subMainPage myForm = new subMainPage();
                myForm.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
