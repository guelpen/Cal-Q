﻿using System;
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
        int[,] AP_rocol = new int[100,100]; //rocol=row, column
        int[,] IM_rocol = new int[100, 100]; //IM= identity matrix
        int[] IC = new int[100];
        int ro, col,col_i, ro_i, icc;
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
            icc = 1;
            btn_Add.Enabled = true;
            btn_Confirm.Enabled = false;
            solve.Enabled = false;
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void solve_Click(object sender, EventArgs e)
        {
            int x2, x3;
            int zf;
            string im = "", im2= "";
            ro = (int)rowUD.Value;
            col = (int)columnUD.Value;
            tabControl1.SelectedIndex = 1;
            //dummy code
            rinp.Text = ro_i.ToString();
            for (x2 = 1; x2 <= ro; x2++)
            {
                for (x3 = 1; x3 <= col; x3++)
                {
                    if (x3 == col)
                        im = im + AP_rocol[x2, x3].ToString() + "\n";
                    else
                        im = im + AP_rocol[x2, x3].ToString() + "   ";
                }
            }
            //MessageBox.Show(im);
            for (zf = 1; zf <= col; zf++)
            {
                if (AP_rocol[1, zf] == 0)
                {
                    IC[icc] = zf;
                    if (zf!=col)
                    {
                        icc++;
                    }
                }
            }
            for (zf = 1; zf <= icc; zf++) { im2 = im2 + IC[zf].ToString() + "    "; }
            MessageBox.Show(im2);
        }

        private void btn_Proceed_Click(object sender, EventArgs e)
        {
            int imx, imy, x2,x3;
            string im="";
            lbl_inputValue.Text = "Input the value of b: ";
            listView1.Columns.Add("b");
            ro = (int)rowUD.Value;
            col= (int)columnUD.Value;
            tabControl1.SelectedIndex = 1;
            //dummy code
            rinp.Text = ro_i.ToString();
            for (int x = 1; x <= (col-1); x++)
            {
                listView1.Columns.Add("x"+x);
            }
            for ( imy = 1; imy <= ro; imy++ )
            {
                for ( imx = 1; imx <= ro-1; imx++ )
                {
                    if (imx == imy-1) { IM_rocol[imy, imx] = 1; }
                    else IM_rocol[imx, imy] = 0;
                }
            }
            for (x2 = 1; x2 <= ro; x2++)
            {
                for (x3 = 1; x3 <= ro-1; x3++)
                {
                    if( x3 == ro-1 )
                        im = im + IM_rocol[x2, x3].ToString() + "\n";
                    else
                        im = im + IM_rocol[x2, x3].ToString() + "   ";
                }
            }
            MessageBox.Show(im);
        }
        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            int ctr;
            if (ro_i <= ro)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = AP_rocol[ro_i, 1].ToString();
                for (ctr = 2; ctr <= col; ctr++)
                {
                    lvi.SubItems.Add(AP_rocol[ro_i,ctr].ToString());
                }
                listView1.Items.Add(lvi);
                btn_Add.Enabled = true;
                btn_Confirm.Enabled = false;
                col_i = 1;
                ro_i=ro_i+1;
                all_values = "";
                inputs.Text = "";
                rinp.Text = ro_i.ToString();
            }
            if (ro_i > ro)
            {
                btn_Add.Enabled = false;
                btn_Confirm.Enabled = false;
                solve.Enabled = true;
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (ro_i <= ro)
            {
                int tv = (int)values_UD.Value;
                if (col_i <= col)
                {
                    all_values = all_values + tv.ToString() + "    ";
                    AP_rocol[ro_i, col_i] = tv;
                    inputs.Text = all_values;
                    col_i++;
                }
                if (col_i > col)
                {
                    btn_Add.Enabled = false;
                    btn_Confirm.Enabled = true;
                }
            }
        }
    }
}
