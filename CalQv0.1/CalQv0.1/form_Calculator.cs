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
        int ro, col,col_i, ro_i;
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
            btn_Add.Enabled = true;
            btn_Confirm.Enabled = false;
            solve.Enabled = false;
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
