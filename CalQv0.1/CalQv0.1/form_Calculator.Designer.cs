namespace CalQv0._1
{
    partial class form_Calculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.closeButton = new System.Windows.Forms.Button();
            this.btn_Proceed = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.columnUD = new System.Windows.Forms.NumericUpDown();
            this.rowUD = new System.Windows.Forms.NumericUpDown();
            this.btn_Back = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.inputs = new System.Windows.Forms.Label();
            this.rinp = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.solve = new System.Windows.Forms.Button();
            this.values_UD = new System.Windows.Forms.NumericUpDown();
            this.btn_Confirm = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.lbl_inputValue = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.columnUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rowUD)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.values_UD)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(581, 418);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.BackgroundImage = global::CalQv0._1.Properties.Resources.bg4;
            this.tabPage1.Controls.Add(this.closeButton);
            this.tabPage1.Controls.Add(this.btn_Proceed);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.columnUD);
            this.tabPage1.Controls.Add(this.rowUD);
            this.tabPage1.Controls.Add(this.btn_Back);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(573, 392);
            this.tabPage1.TabIndex = 0;
            // 
            // closeButton
            // 
            this.closeButton.BackgroundImage = global::CalQv0._1.Properties.Resources.closeIcon1;
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Location = new System.Drawing.Point(498, 19);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(32, 24);
            this.closeButton.TabIndex = 5;
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // btn_Proceed
            // 
            this.btn_Proceed.BackgroundImage = global::CalQv0._1.Properties.Resources.next1;
            this.btn_Proceed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Proceed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Proceed.FlatAppearance.BorderSize = 0;
            this.btn_Proceed.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Proceed.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Proceed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Proceed.Location = new System.Drawing.Point(256, 221);
            this.btn_Proceed.Name = "btn_Proceed";
            this.btn_Proceed.Size = new System.Drawing.Size(32, 24);
            this.btn_Proceed.TabIndex = 4;
            this.btn_Proceed.UseVisualStyleBackColor = true;
            this.btn_Proceed.Click += new System.EventHandler(this.btn_Proceed_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(122, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "No. of Columns :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(144, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "No. of Rows :";
            // 
            // columnUD
            // 
            this.columnUD.Location = new System.Drawing.Point(256, 179);
            this.columnUD.Name = "columnUD";
            this.columnUD.Size = new System.Drawing.Size(120, 20);
            this.columnUD.TabIndex = 1;
            // 
            // rowUD
            // 
            this.rowUD.Location = new System.Drawing.Point(256, 132);
            this.rowUD.Name = "rowUD";
            this.rowUD.Size = new System.Drawing.Size(120, 20);
            this.rowUD.TabIndex = 1;
            // 
            // btn_Back
            // 
            this.btn_Back.BackgroundImage = global::CalQv0._1.Properties.Resources.backIcon;
            this.btn_Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Back.FlatAppearance.BorderSize = 0;
            this.btn_Back.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Back.Location = new System.Drawing.Point(24, 329);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(32, 24);
            this.btn_Back.TabIndex = 0;
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Transparent;
            this.tabPage2.BackgroundImage = global::CalQv0._1.Properties.Resources.bg4;
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.inputs);
            this.tabPage2.Controls.Add(this.rinp);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.solve);
            this.tabPage2.Controls.Add(this.values_UD);
            this.tabPage2.Controls.Add(this.btn_Confirm);
            this.tabPage2.Controls.Add(this.btn_Add);
            this.tabPage2.Controls.Add(this.lbl_inputValue);
            this.tabPage2.Controls.Add(this.listView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(573, 392);
            this.tabPage2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::CalQv0._1.Properties.Resources.backIcon2;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(6, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 24);
            this.button1.TabIndex = 13;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // inputs
            // 
            this.inputs.AutoSize = true;
            this.inputs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputs.ForeColor = System.Drawing.SystemColors.Control;
            this.inputs.Location = new System.Drawing.Point(298, 280);
            this.inputs.Name = "inputs";
            this.inputs.Size = new System.Drawing.Size(13, 20);
            this.inputs.TabIndex = 12;
            this.inputs.Text = " ";
            // 
            // rinp
            // 
            this.rinp.AutoSize = true;
            this.rinp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rinp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rinp.Location = new System.Drawing.Point(402, 246);
            this.rinp.Name = "rinp";
            this.rinp.Size = new System.Drawing.Size(0, 20);
            this.rinp.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(298, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Input for row";
            // 
            // solve
            // 
            this.solve.BackgroundImage = global::CalQv0._1.Properties.Resources.solve;
            this.solve.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.solve.FlatAppearance.BorderSize = 0;
            this.solve.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.solve.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.solve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.solve.Location = new System.Drawing.Point(445, 350);
            this.solve.Name = "solve";
            this.solve.Size = new System.Drawing.Size(122, 34);
            this.solve.TabIndex = 7;
            this.solve.UseVisualStyleBackColor = true;
            // 
            // values_UD
            // 
            this.values_UD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.values_UD.Location = new System.Drawing.Point(21, 278);
            this.values_UD.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.values_UD.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.values_UD.Name = "values_UD";
            this.values_UD.Size = new System.Drawing.Size(53, 26);
            this.values_UD.TabIndex = 6;
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.BackgroundImage = global::CalQv0._1.Properties.Resources.tickmark;
            this.btn_Confirm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Confirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Confirm.FlatAppearance.BorderSize = 0;
            this.btn_Confirm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Confirm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Confirm.Location = new System.Drawing.Point(493, 267);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(32, 37);
            this.btn_Confirm.TabIndex = 5;
            this.btn_Confirm.UseVisualStyleBackColor = true;
            this.btn_Confirm.Click += new System.EventHandler(this.btn_Confirm_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.BackgroundImage = global::CalQv0._1.Properties.Resources.plus;
            this.btn_Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Add.FlatAppearance.BorderSize = 0;
            this.btn_Add.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.Location = new System.Drawing.Point(89, 278);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(32, 24);
            this.btn_Add.TabIndex = 4;
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // lbl_inputValue
            // 
            this.lbl_inputValue.AutoSize = true;
            this.lbl_inputValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_inputValue.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_inputValue.Location = new System.Drawing.Point(20, 246);
            this.lbl_inputValue.Name = "lbl_inputValue";
            this.lbl_inputValue.Size = new System.Drawing.Size(167, 20);
            this.lbl_inputValue.TabIndex = 3;
            this.lbl_inputValue.Text = "Input values of Matrix :";
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(6, 6);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(561, 227);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // form_Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CalQv0._1.Properties.Resources.bg4;
            this.ClientSize = new System.Drawing.Size(605, 444);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(621, 483);
            this.Name = "form_Calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.columnUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rowUD)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.values_UD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown columnUD;
        private System.Windows.Forms.NumericUpDown rowUD;
        private System.Windows.Forms.Button btn_Proceed;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label lbl_inputValue;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Confirm;
        private System.Windows.Forms.NumericUpDown values_UD;
        private System.Windows.Forms.Button solve;
        private System.Windows.Forms.Label inputs;
        private System.Windows.Forms.Label rinp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button closeButton;
    }
}