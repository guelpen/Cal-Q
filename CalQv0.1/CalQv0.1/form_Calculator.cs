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
        int[,] AP_rocol = new int[100,100]; //rocol=row, column
        int[,] IM_rocol = new int[100, 100]; //IM= identity matrix
        int[] oo = new int[100];// original objective
        int oc, irc; //oc = one counter, irc = identity row counter
        int ro, col,col_i, ro_i, icc;
        int[] icro = new int[100]; //icro = identity column rows
        String all_values;

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
            icc = 0;
            btn_Add.Enabled = true;
            btn_Confirm.Enabled = false;
            solve.Enabled = false;
            oc = 0;
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
            int zf;
            string im = "";
            ro = (int)rowUD.Value;
            col = (int)columnUD.Value;
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
            // multiply rows with -1 if b is negative
            /* for (zf = 1; zf <= col; zf++)
             {
                 if (AP_rocol[1, zf] == 0)
                 {
                     for (irc = 2; irc <= ro; irc++)
                     {
                         if (AP_rocol[irc, zf] == 1)
                         {
                             oc++;
                             icro[icc] = irc;
                             icc++;
                         }
                         else if (AP_rocol[irc, zf] > 1 || AP_rocol[irc, zf] < 0)
                         {
                             oc--;
                         }
                     }
                     if ( oc == 1 )
                     {
                         int icc2 = 0, newx, newy=1, anewy;
                         while (icc2 <= icc)
                         {
                             for (newy = 1; newy <= col; newy++)
                             {
                                 anewy = newy;
                                 if (IM_rocol[icro[icc2], newy] == 1)
                                 {
                                     up:
                                     for (newx = 1; newx <= ro; newx++)
                                     {
                                         IM_rocol[newx, anewy] = IM_rocol[newx + 1, anewy + 1];
                                     }
                                     anewy++;
                                     if (anewy <= ro) { goto up; }
                                 }
                             }
                         }
                     }
                 }
             }
             for (x2 = 1; x2 <= ro; x2++)
             {
                 for (x3 = 1; x3 <= ro - 1; x3++)
                 {
                     if (x3 == ro - 1)
                         im = im + IM_rocol[x2, x3].ToString() + "\n";
                     else
                         im = im + IM_rocol[x2, x3].ToString() + "   ";
                 }
             }
             MessageBox.Show(im);*/ // This part will be subjected to analysis and overhauls
             // change the original objective function to zero
            for (x4 = 1; x4 <= col; x4++)
            {
                oo[x4] = AP_rocol[1, x4];
                AP_rocol[1, x4] = 0; 
            }
            listView1.Items.Clear();
            for (x3 = 1; x3 <= ro; x3++)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = AP_rocol[x3, 1].ToString();
                for (x4 = 2; x4 <= col; x4++)
                {
                    lvi.SubItems.Add(AP_rocol[x3, x4].ToString());
                }
                listView1.Items.Add(lvi);
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
