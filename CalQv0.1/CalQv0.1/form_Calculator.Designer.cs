﻿namespace CalQv0._1
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
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
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
            this.tabControl1.Location = new System.Drawing.Point(-3, -20);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(610, 467);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.BackgroundImage = global::CalQv0._1.Properties.Resources.mainmenu1;
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
            this.tabPage1.Size = new System.Drawing.Size(602, 441);
            this.tabPage1.TabIndex = 0;
            // 
            // closeButton
            // 
            this.closeButton.BackgroundImage = global::CalQv0._1.Properties.Resources.close;
            this.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Location = new System.Drawing.Point(560, 10);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(32, 32);
            this.closeButton.TabIndex = 5;
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // btn_Proceed
            // 
            this.btn_Proceed.BackgroundImage = global::CalQv0._1.Properties.Resources.next2;
            this.btn_Proceed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Proceed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Proceed.FlatAppearance.BorderSize = 0;
            this.btn_Proceed.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Proceed.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Proceed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Proceed.Location = new System.Drawing.Point(282, 252);
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
            this.label2.Location = new System.Drawing.Point(148, 208);
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
            this.label1.Location = new System.Drawing.Point(170, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "No. of Rows :";
            // 
            // columnUD
            // 
            this.columnUD.Location = new System.Drawing.Point(282, 211);
            this.columnUD.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.columnUD.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.columnUD.Name = "columnUD";
            this.columnUD.Size = new System.Drawing.Size(120, 20);
            this.columnUD.TabIndex = 1;
            this.columnUD.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // rowUD
            // 
            this.rowUD.Location = new System.Drawing.Point(282, 164);
            this.rowUD.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.rowUD.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.rowUD.Name = "rowUD";
            this.rowUD.Size = new System.Drawing.Size(120, 20);
            this.rowUD.TabIndex = 1;
            this.rowUD.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // btn_Back
            // 
            this.btn_Back.BackgroundImage = global::CalQv0._1.Properties.Resources.back1;
            this.btn_Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Back.FlatAppearance.BorderSize = 0;
            this.btn_Back.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Back.Location = new System.Drawing.Point(3, 406);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(32, 24);
            this.btn_Back.TabIndex = 0;
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Transparent;
            this.tabPage2.BackgroundImage = global::CalQv0._1.Properties.Resources.mainmenu1;
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.button2);
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
            this.tabPage2.Size = new System.Drawing.Size(602, 441);
            this.tabPage2.TabIndex = 1;
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::CalQv0._1.Properties.Resources.ResetButton;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(478, 400);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(114, 30);
            this.button4.TabIndex = 16;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::CalQv0._1.Properties.Resources.EraseButton;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(238, 400);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 30);
            this.button3.TabIndex = 15;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::CalQv0._1.Properties.Resources.close;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(560, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(32, 32);
            this.button2.TabIndex = 14;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::CalQv0._1.Properties.Resources.back1;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(11, 406);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 24);
            this.button1.TabIndex = 13;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // inputs
            // 
            this.inputs.AutoSize = true;
            this.inputs.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputs.ForeColor = System.Drawing.SystemColors.Control;
            this.inputs.Location = new System.Drawing.Point(298, 314);
            this.inputs.Name = "inputs";
            this.inputs.Size = new System.Drawing.Size(14, 21);
            this.inputs.TabIndex = 12;
            this.inputs.Text = " ";
            this.inputs.Click += new System.EventHandler(this.inputs_Click);
            // 
            // rinp
            // 
            this.rinp.AutoSize = true;
            this.rinp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rinp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rinp.Location = new System.Drawing.Point(402, 280);
            this.rinp.Name = "rinp";
            this.rinp.Size = new System.Drawing.Size(0, 20);
            this.rinp.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(298, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "Input for row";
            // 
            // solve
            // 
            this.solve.BackgroundImage = global::CalQv0._1.Properties.Resources.SolveNew;
            this.solve.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.solve.Cursor = System.Windows.Forms.Cursors.Hand;
            this.solve.Enabled = false;
            this.solve.FlatAppearance.BorderSize = 0;
            this.solve.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.solve.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.solve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.solve.Location = new System.Drawing.Point(358, 400);
            this.solve.Name = "solve";
            this.solve.Size = new System.Drawing.Size(114, 30);
            this.solve.TabIndex = 7;
            this.solve.UseVisualStyleBackColor = true;
            this.solve.Click += new System.EventHandler(this.solve_Click);
            // 
            // values_UD
            // 
            this.values_UD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.values_UD.Location = new System.Drawing.Point(21, 312);
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
            this.btn_Confirm.Location = new System.Drawing.Point(165, 327);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(50, 50);
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
            this.btn_Add.Location = new System.Drawing.Point(90, 327);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(50, 50);
            this.btn_Add.TabIndex = 4;
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // lbl_inputValue
            // 
            this.lbl_inputValue.AutoSize = true;
            this.lbl_inputValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_inputValue.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_inputValue.Location = new System.Drawing.Point(20, 280);
            this.lbl_inputValue.Name = "lbl_inputValue";
            this.lbl_inputValue.Size = new System.Drawing.Size(167, 21);
            this.lbl_inputValue.TabIndex = 3;
            this.lbl_inputValue.Text = "Input values of Matrix :";
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.Black;
            this.listView1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.ForeColor = System.Drawing.Color.White;
            this.listView1.Location = new System.Drawing.Point(6, 40);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(590, 227);
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}