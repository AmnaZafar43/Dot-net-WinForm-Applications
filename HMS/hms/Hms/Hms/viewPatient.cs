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

namespace Hms
{
    public partial class viewPatient : Form
    {
        public viewPatient()
        {
            InitializeComponent();
            gvDelete.DataSource = DL.patientDL.patientList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gvDelete_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void viewPatient_Load(object sender, EventArgs e)
        {

        }
    }
}
