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
    public partial class addDoctor : Form
    {
        public addDoctor()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string doctorName, doctorAddress,doctorBlood,doctorMobile,doctorMail, doctorGender, doctorSpecialization;
            int doctorAge,doctorId;
            doctorName = textBox1.Text;
            doctorAge = int.Parse(textBox2.Text);
            doctorGender = textBox3.Text;
            doctorSpecialization = textBox4.Text;
            doctorId = int.Parse(textBox5.Text);
            doctorBlood = textBox6.Text;
            doctorMobile = textBox7.Text;
            doctorMail = textBox8.Text;
            doctorAddress = textBox9.Text;
            doctor obj = new doctor(doctorName, doctorAge, doctorGender, doctorSpecialization, doctorId, doctorAddress, doctorBlood, doctorMail, doctorMobile);
            DL.doctorDL.addDoctorInList(obj);
            DL.doctorDL.addDoctorInFile();
            if (obj != null)
            {
                DialogResult result = MessageBox.Show("Doctor added Successfully", "Message", MessageBoxButtons.OKCancel);
                if(result == DialogResult.OK)
                {
                    this.Close();
                }
            }
            else
            {
                DialogResult result = MessageBox.Show("Invalid Credentials", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addDoctor_Load(object sender, EventArgs e)
        {

        }
    }
}
