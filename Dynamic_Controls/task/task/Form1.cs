using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task
{
    public partial class Form1 : Form
    {
        public int total = 0;

        public Form1()
        {
            InitializeComponent();
        }

        public void addTextBox(int input)
        {
            int y = 48;
            for (int i = 1; i <= input; i++)
            {
                TextBox obj = new TextBox();
                obj.Name = "txtsubMarks" + i;
                obj.Location = new Point(418, (100 + y));
                obj.Size = new Size(100, 30);
                obj.Font = new Font("Times New Roman", 13, FontStyle.Italic);
                this.Controls.Add(obj);
                y += 48;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            total = int.Parse(txtInput.Text);
            addTextBox(total);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for (int i = 1; i <= total; i++)
            {
                sum = sum + int.Parse(this.Controls["txtsubMarks" + i].Text);
            }
            MessageBox.Show("Sum is " + sum.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
