using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hms.DL;
using Hms.BL;

namespace Hms
{
    public partial class mainPage : Form
    {
        public mainPage()
        {
            InitializeComponent();
            if(DL.doctorDL.loadDoctorFromFile())
            {
                if(DL.patientDL.loadPatientFromFile())
                {
                    
                }
            }
            else
            {
                MessageBox.Show("Data not loaded successfully");
            }
            DialogResult result = MessageBox.Show("Welcome to Service Hospital Management System", "Message", MessageBoxButtons.OK);
        }

        private void mainPage_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            viewInstructions myForm = new viewInstructions();
            myForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are yo sure you want to exit", "Messaage", MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                this.Close();
            }
            else
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            subMainPage myform = new subMainPage();
            myform.ShowDialog();
        }
    }
}
