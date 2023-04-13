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
    public partial class deleteDoctor : Form
    {
        public deleteDoctor()
        {
            InitializeComponent();
            gvDelete.DataSource = DL.doctorDL.doctorList;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gvDelete_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gvDelete_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete", "Message", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                if (gvDelete.Columns["Delete"].Index == e.ColumnIndex)
                {
                    int index = gvDelete.CurrentCell.RowIndex;
                    doctor user = (doctor)gvDelete.CurrentRow.DataBoundItem;
                    gvDelete.DataSource = null;
                    DL.doctorDL.deleteDoctor(index);
                    DL.doctorDL.storeinFile();
                    gvDelete.DataSource = doctorDL.doctorList;
                    gvDelete.Refresh();
                }
            }
            else
            {

            }
            
        }

        private void deleteDoctor_Load(object sender, EventArgs e)
        {

        }
    }
}
