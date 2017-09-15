using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalQv0._1
{
    // tangina mo migel
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            int x = 2;
            x = x + 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form_Calculator frm = new form_Calculator();
            frm.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            form_Help frm = new form_Help();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            form_Tutorials frm = new form_Tutorials();
            frm.Show();
        }
        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
