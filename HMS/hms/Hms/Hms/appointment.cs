using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hms.BL;
using Hms.DL;

namespace Hms
{
    public partial class appointment : Form
    {
        public appointment()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string patientName, patientDisease, patientBlood, patientCnic, patientGender, patientAddress;
            int patientAge, patientId;
            patientName = textBox2.Text;
            patientAge = int.Parse(textBox1.Text);
            patientDisease = textBox3.Text;
            patientGender = textBox4.Text;
            patientCnic = textBox5.Text;
            patientId = int.Parse(textBox6.Text);
            patientBlood = textBox7.Text;
            patientAddress = textBox8.Text;
            patient obj = new patient(patientName, patientAge, patientDisease, patientBlood, patientCnic, patientId, patientGender, patientAddress);
            DL.patientDL.addPatientInList(obj);
            DL.patientDL.addPatientInFile();
            if (obj != null)
            {
                DialogResult result = MessageBox.Show("Appointment booked Successfully", "Message", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    this.Close();
                }
            }
            else
            {
                DialogResult result = MessageBox.Show("Invalid Credentials", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
