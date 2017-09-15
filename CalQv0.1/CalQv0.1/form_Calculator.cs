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
    public partial class form_Calculator : Form
    {
        //variables
        int[,] AP_rocol; //rocol=row, column
        int ro, col,col_i, ro_i , col_ctr, ro_ctr;
        String all_values;

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        public form_Calculator()
        {
            InitializeComponent();
            all_values = "";
            ro_i = 1;
            col_i = 1;
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Proceed_Click(object sender, EventArgs e)
        {
            lbl_inputValue.Text = "Input the value of b: ";
            listView1.Columns.Add("b");
            ro = (int)rowUD.Value;
            col= (int)columnUD.Value;
            tabControl1.SelectedIndex = 1;
            //dummy code
            
            for (int x = 1; x <= (col-1); x++)
            {
                listView1.Columns.Add("x"+x);
            }
        }
        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            int tv = (int)values_UD.Value;
            if (col_i<=col)
            {
                all_values = all_values + tv.ToString() + "    ";
                col_i++;
            }
            
        }
    }
}
