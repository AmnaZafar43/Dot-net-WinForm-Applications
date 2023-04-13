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
    public partial class Doctor : Form
    {
        public Doctor()
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
                addPatient myForm = new addPatient();
                myForm.ShowDialog();
            }
            else if(radioButton2.Checked)
            {
                viewPatient myForm = new viewPatient();
                myForm.ShowDialog();
            }
            else if(radioButton3.Checked)
            {
                deletePatient myf = new deletePatient();
                myf.ShowDialog();
            }
            else if(radioButton4.Checked)
            {
                updatePatient myForm = new updatePatient();
                myForm.ShowDialog();
            }
            else if(radioButton6.Checked)
            {
                prescription myForm = new prescription();
                myForm.ShowDialog();
            }
            else if(radioButton7.Checked)
            {
                viewAppointment myForm = new viewAppointment();
                myForm.ShowDialog();
            }
            else if(radioButton8.Checked)
            {
                testDetail myForm = new testDetail();
                myForm.ShowDialog();
            }
            else if(radioButton9.Checked)
            {
                viewInstructions myForm = new viewInstructions();
                myForm.ShowDialog();
            }
            else if(radioButton10.Checked)
            {
                this.Close();
                this.Hide();
                subMainPage myForm = new subMainPage();
                myForm.ShowDialog();
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
