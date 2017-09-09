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
        String x_Value;
        
        int addItem_Counter = 0;
        int columnNo , lv_Counter;
        int[] xArr = new int[20];
        

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
            listView1.Columns.Add("b");
            columnNo = (int)columnUD.Value;
            tabControl1.SelectedIndex = 1;
            //listView1.Columns.Add("b");
            //dummy code
            
            for (int x = 1; x <= columnNo; x++)
            {
                listView1.Columns.Add("x"+x);

            }
        }
        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            for (lv_Counter = 0; lv_Counter < columnNo; lv_Counter++)
            {
                ListViewItem lvi = new ListViewItem();

            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {

            columnNo = (int)columnUD.Value;

            xArr[addItem_Counter] = (int)values_UD.Value;

            addItem_Counter = addItem_Counter + 1;

            values_UD.Value = 0;

            listView1.Items.Add(Convert.ToString(x_Value));

            if(addItem_Counter == columnNo )
            {
                btn_Add.Enabled = false;
            }
        }
    }
}
