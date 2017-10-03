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
        decimal[,] AP_rocol = new decimal[17, 17];
        decimal[] oo = new decimal[9];
        decimal[,] ida = new decimal[9, 9];
        int[] idro = new int[9];// original objective, identity set, identity row
        decimal irc; //oc = one counter, irc = identity row columns
        decimal[] toadd = new decimal[9];
        int ro, col ,ncol,col_i=1, ro_i=1, icc=1, tv=0;
        string[] icro = new string[9]; //icro = identity column rows
        string[] ids = new string[9];
        string[] mids = new string[9];
        decimal[] frmIdGen = new decimal[9];
        int[] exclude = new int[9];
        int strCounter,strCounter2;
        string tempstr,tempstr2;
        string strk2 = "";
        string[] addedId = new string[9];
        string[] txtString = new string[9];
        public static ListViewItem lvi;

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
            listView1.Items.Clear();
            listView1.Columns.Clear();
            ro = 0; col = 0;
        }

        public form_Calculator()
        {
            InitializeComponent();
            ro_i = 1;
            col_i = 1;
            icc = 1;
            btn_Add.Enabled = true;
            btn_Confirm.Enabled = false;
            solve.Enabled = false;
            inputs.Text = "";
            tempstr = ""; tempstr2 = "";
            strCounter = 1;
            strCounter2 = 1;

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
        private void Identity_maker()
        {
            int x, y;
            for (x = 1; x < ro; x++)
            {
                for (y = 1; y < ro; y++)
                {
                    if (x != y)
                    {
                        tempstr = tempstr + "0";
                    }
                    else if (x == y)
                    {
                        tempstr = tempstr + "1";
                    }
                }
                ids[x] = tempstr;
                tempstr = "";
            }
            for (x = 1; x < ro; x++)
            {
                tempstr2 = tempstr2 + ids[x] + "\n";
            }
        }
        private void solve_Click(object sender, EventArgs e)
        {
            int x2, x3;
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
            for (int i = 1; i < listView1.Items.Count;)
            {
                listView1.Items[i].Remove();
            }
            for (x3 = 1; x3 <= ro; x3++)
            {
                 lvi = new ListViewItem();
                if (x3 != 1)
                {
                    lvi.Text = AP_rocol[x3, 1].ToString();
                    for (x2 = 2; x2 <= col; x2++)
                    {
                        lvi.SubItems.Add(Math.Round(AP_rocol[x3, x2],2).ToString());
                    }
                    listView1.Items.Add(lvi);
                }
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
            identity_Generator();
            for (x4 = 1; x4 <= col; x4++)
            {
                AP_rocol[1, x4] = 0;
            }
            Solve_identity();
        }
        private void Identity_Finder()
        {
            int  x,y,z;
            for (y = 1; y <= col; y++)
            {
                if (AP_rocol[1, y] == 0)
                {
                    idro[icc] = y;
                    icc++;
                }
            }
            for (z = 1; z <= icc - 1; z++)
            {
                for (x = 2; x <= ro; x++)
                {
                    icro[z] = icro[z] + AP_rocol[x, idro[z]].ToString();
                }
            }

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            erase_Values();
        }

   

        private void inputs_Click(object sender, EventArgs e)
        {

        }
        
        private void identity_Generator()
        {
            int indx, indxc;
            for(indx = 1; indx < icc; indx++)
            {
                for (indxc = 1; indxc <= ro; indxc++)
                {
                    if (icro[indx].Equals(ids[indxc]))
                    {
                        frmIdGen[strCounter] = indxc;
                        strCounter++;
                    }
                   
                }
            }
            exclude_equal();
        }
        private void exclude_equal()
        {
            int x, y = 1;
            
            for (x = 1; x < ro; x++)
            {
                if (x == frmIdGen[y])
                {
                    y++;
                    continue;
                }
                else
                {
                    exclude[strCounter2] = x;
                    strCounter2++;
                }
            }
            for (x = 1; x <=strCounter2; x++)
            {
                strk2 = strk2 + exclude[x].ToString();
            }
            add_identity();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }

        private void add_identity()
        {
            int x,y;
            ncol= col + strCounter2 - 1;
            for (x = 1; x <= ro; x++)
            {
                for (y = 1; y <= ncol; y++)
                {
                    if (y > col)
                    {
                        AP_rocol[exclude[y-col]+1,y]= 1;
                        AP_rocol[1, y] = 1;
                    }
                }
            }
        }
        private void Solve_identity()
        {
            int x, y, flag = 0;
            for (x = 1; x < strCounter2; x++)
            {
                for (y = 1; y <= ncol; y++)
                {
                    AP_rocol[1, y] = AP_rocol[1, y] - AP_rocol[(exclude[x] + 1), y];
                }
            }
            Main_solution();
            for (y = 1; y <= col; y++)
            {
                if (AP_rocol[1, y] != 0)
                { flag++; }
            }
            if (flag != 0)
            {
                Main_solution();
            }
        }
        private void Main_solution()
        {
            int x1, x2, y1, y2, fy = 0, fx = 0;
            decimal mosneg, fmosneg = 0, leastpos, fleastpos = 500000;
            decimal[] temppr = new decimal[17];
            decimal[] temppr2 = new decimal[17];
            decimal rfy;
            int unboundedCounter=0;
            for (y1 = 2; y1 <= ncol; y1++)
            {
                mosneg = AP_rocol[1, y1];
                if (mosneg < 0)
                {
                    if (mosneg < fmosneg)
                    {
                        fy = y1;
                        fmosneg = mosneg;
                    }
                }
            }
            for (x1 = 2; x1 <= ro; x1++)
            {
                if (AP_rocol[x1, fy] > 0)
                {

                    leastpos = AP_rocol[x1, 1] / AP_rocol[x1, fy];
                    if (leastpos < fleastpos && leastpos > 0)
                    {
                        fx = x1;
                        fleastpos = leastpos;
                    }

                }
                else
                    unboundedCounter++;
                
                
                if (unboundedCounter==ro-1)
                {
                    MessageBox.Show("Unbounded Form");
                    clearAll();
                }
            }
            rfy = AP_rocol[fx, fy];
            for (y2 = 1; y2 <= ncol; y2++)
            {
                AP_rocol[fx, y2] = AP_rocol[fx, y2] / rfy;
            }
            for (x2 = 1; x2 <= ro; x2++)
            {
                temppr2[x2] = AP_rocol[x2, fy];
            }
            for (y2 = 1; y2 <= ncol; y2++)
            {
                temppr[y2] = AP_rocol[fx, y2];
            }
            for (x2 = 1; x2 <= ro; x2++)
            {
                if (x2 == fx)
                {
                    continue;
                }
                else
                {
                    for (y1 = 1; y1 <= ncol; y1++)
                    {
                        AP_rocol[x2, y1] = AP_rocol[x2, y1] + ((-1) * (temppr2[x2]) * (temppr[y1]));
                    }
                }
            }
        }
        private void btn_Proceed_Click(object sender, EventArgs e)
        {
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


            Identity_maker();
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
                    if (ro_i == 1)
                    {
                        oo[ro_i] = tv;
                    }
                    col_i++;
                    txtString[col_i] = inputs.Text;
                }
                if (col_i > col)
                {
                    btn_Add.Enabled = false;
                    btn_Confirm.Enabled = true;
                }
            }
        }
        //function for erasing user input values
        private void erase_Values()
        {
            
            if (ro_i <= ro)
            {
                inputs.Text = txtString[col_i - 1];
                if (col_i <= col)
                {

                    tv = 0;
                    AP_rocol[ro_i, col_i] = 0;
                    col_i--;
                }
                if (col_i <= 0)
                {
                    MessageBox.Show("Nothing to Erase");
                    col_i = 1;
                }
                if(col_i>col)
                {
                    btn_Add.Enabled = true;
                    col_i--;
                }
                
            }
        }
        //function name explains itself.
        private void clearAll()
        {
            int a,b=1;
            //looping to clear all values of AP_rocol
            for (b = 1; b <= ro; b++)
            {
                for (a = 1; a <= col; a++)
                {
                   
                    AP_rocol[b, a] = 0;

                }
            }
            listView1.Items.Clear();
        }
    }
}
