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
    public partial class viewDoctor : Form
    {
        public viewDoctor()
        {
            InitializeComponent();
            gvView.DataSource = DL.doctorDL.doctorList; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void viewDoctor_Load(object sender, EventArgs e)
        {

        }

        private void gvView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
