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
        int[,] AP_rocol = new int[100, 100];
        int[,] IM_rocol = new int[100, 100]; //rocol=row, column, IM= identity matrix
        int[] oo, idset, idro = new int[100];// original objective, identity set, identity row
        int irc; //oc = one counter, irc = identity row columns
        int ro, col,col_i=1, ro_i=1, icc=1, tv=0;
        int[] icro = new int[100]; //icro = identity column rows
        String all_values=" ";

        private void button1_Click(object sender, EventArgs e)
        {
            int x, y;
            tabControl1.SelectedIndex = 0;
            listView1.Items.Clear();
            listView1.Columns.Clear();
            for (x = 0; x <= 100; x++)
            {
                for (y = 0; y <= 100; y++)
                {
                    AP_rocol[x, y] = 0;
                    IM_rocol[x, y] = 0;
                }
            }
            ro = 0; col = 0;
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
            inputs.Text = "";
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
            int x2, x3, x4;
            string fff="";
            ro = (int)rowUD.Value;
            col = (int)columnUD.Value;
            irc = ro;
            tabControl1.SelectedIndex = 1;
            if (ro_i > ro)
            {
                label4.Visible = false;
                rinp.Visible = false;
            }
            else
            {
                rinp.Text = ro_i.ToString();
            }
            Set_nMatrix();
            // multiply rows with -1 if b is negative
            // change the original objective function to zero
            for (x4 = 1; x4 <= icc; x4++)
            {
                fff = fff + idro[x4].ToString();
            }
            listView1.Items.Clear();
            MessageBox.Show(fff);
            for (x3 = 1; x3 <= ro; x3++)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = AP_rocol[x3, 1].ToString();
                for (x2 = 2; x2 <= col; x2++)
                {
                    lvi.SubItems.Add(AP_rocol[x3, x2].ToString());
                }
                listView1.Items.Add(lvi);
            }
        }
        private void Set_nMatrix()
        {
            int x4,x5,x6;
            for (x5 = 2; x5 <= ro; x5++)
            {
                if (AP_rocol[x5, 1] < 0)
                {
                    for (x6 = 1; x6 <= col; x6++)
                    {
                        AP_rocol[x5, x6] = (AP_rocol[x5, x6]) * (-1);
                    }
                }
            }
            // look for parts of designated identity matrix
            Identity_Finder();
            for (x4 = 1; x4 <= col; x4++)
            {
                //oo[x4] = AP_rocol[1, x4];
                AP_rocol[1, x4] = 0;
            }
        }
        private void Identity_Finder()
        {
            int x, x2=0, y, oc=0;
            for (y = 1; y <= col; y++)
            {
                if (AP_rocol[1, y] == 0)
                {
                    for (x = 2; x <= ro; x++)
                    {
                        if (AP_rocol[x, y] == 1 && oc == 0)
                        {
                            oc = 1;
                            x2 = x;
                        }
                        else if (AP_rocol[x,y] != 0 && oc == 1)
                        {
                            oc = 0;
                        }
                        else if (x == ro && oc == 1)
                        {
                            idro[icc] = x2;
                            icc++;
                        }
                    }
                }
            }
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
            rinp.Text = ro_i.ToString();
            for (int x = 1; x <= (col-1); x++)
            {
                listView1.Columns.Add("x"+x);
            }
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
                if (col_i <= col)
                {
                    tv = (int)values_UD.Value;
                    inputs.Text = inputs.Text + tv.ToString() + "     ";
                    AP_rocol[ro_i, col_i] = tv;
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
