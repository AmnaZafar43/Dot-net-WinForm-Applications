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
    public partial class viewAppointment : Form
    {
        public viewAppointment()
        {
            InitializeComponent();
            gvAppoint.DataSource = DL.patientDL.patientList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
