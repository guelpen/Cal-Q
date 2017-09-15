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
        int[,] aprc;
        int clmi, rwi;

        public form_Calculator()
        {
            InitializeComponent();
            

        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Proceed_Click(object sender, EventArgs e)
        {
            lbl_inputValue.Text = "Input the value of b: ";
            listView1.Columns.Add("b");
            rwi = (int)rowUD.Value;
            clmi = (int)columnUD.Value;
            tabControl1.SelectedIndex = 1;
            //listView1.Columns.Add("b");
            //dummy code
            
            for (int x = 1; x <= (clmi-1); x++)
            {
                listView1.Columns.Add("x"+x);
               

            }
        }
        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            /*sa part nato ung pang display pag pinindot ung confirm button
            // lalabas dapat ung isang row.
            btn_Add.Enabled = true;
            lbl_inputValue.Text = "Input the value of b: ";
            for (lv_Counter = 0; lv_Counter < columnNo; lv_Counter++)
            {
                ListViewItem lvi = new ListViewItem();

            }*/
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            /*lbl_inputValue.Text = "Input the value of x: ";
            columnNo = (int)columnUD.Value;

            //pang add ng value sa b
            
            bArr[addItem_Counter] = (int)values_UD.Value;

            //pang add ng value sa x
            
            if (addItem_Counter == 1)
            {
                
                xArr[addItem_Counter] = (int)values_UD.Value;
            }
            // dun sa calculator naten di kasama sa number of columns ung b kaya
            // ginawa kong addItem_Counter +1 para sakto parin sa array;

            addItem_Counter = addItem_Counter + 1;

            values_UD.Value = 0;

            //listView1.Items.Add(Convert.ToString(x_Value));

            if(addItem_Counter == columnNo+1 )
            {
                btn_Add.Enabled = false;
            }*/
        }
    }
}
