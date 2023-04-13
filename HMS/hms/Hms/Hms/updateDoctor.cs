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
    public partial class updateDoctor : Form
    {
        public updateDoctor()
        {
            InitializeComponent();
            gvUpdate.DataSource = DL.doctorDL.doctorList;        
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gvUpdate_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            bool edited = false;
            DialogResult result = MessageBox.Show("Are you sure you want to edit", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(result == DialogResult.OK)
            {
               // edited = DL.doctorDL.updateDoctor();
            }
        }
    }
}
