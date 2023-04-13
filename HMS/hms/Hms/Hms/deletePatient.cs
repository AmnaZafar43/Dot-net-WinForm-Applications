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
    public partial class deletePatient : Form
    {
        public deletePatient()
        {
            InitializeComponent();
            gvDel.DataSource = DL.patientDL.patientList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gvDel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete", "Message", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                if (gvDel.Columns["Delete"].Index == e.ColumnIndex)
                {
                    int index = gvDel.CurrentCell.RowIndex;
                    patient user = (patient)gvDel.CurrentRow.DataBoundItem;
                    gvDel.DataSource = null;
                    DL.patientDL.deletePatient(index);
                    DL.patientDL.storePatientInFile();
                    gvDel.DataSource = DL.patientDL.patientList;
                    gvDel.Refresh();
                }
            }
            else
            {

            }   
        }
    }
}
