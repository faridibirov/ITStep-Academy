﻿namespace MyApp
{
    partial class Sign_Up
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtlogin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textpassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textrepassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textsurname = new System.Windows.Forms.TextBox();
            this.submitbtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // txtlogin
            // 
            this.txtlogin.Location = new System.Drawing.Point(135, 30);
            this.txtlogin.Name = "txtlogin";
            this.txtlogin.Size = new System.Drawing.Size(117, 23);
            this.txtlogin.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Password";
            // 
            // textpassword
            // 
            this.textpassword.Location = new System.Drawing.Point(135, 71);
            this.textpassword.Name = "textpassword";
            this.textpassword.Size = new System.Drawing.Size(117, 23);
            this.textpassword.TabIndex = 1;
            this.textpassword.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Re-Password";
            // 
            // textrepassword
            // 
            this.textrepassword.Location = new System.Drawing.Point(135, 114);
            this.textrepassword.Name = "textrepassword";
            this.textrepassword.Size = new System.Drawing.Size(117, 23);
            this.textrepassword.TabIndex = 1;
            this.textrepassword.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Name";
            // 
            // textname
            // 
            this.textname.Location = new System.Drawing.Point(135, 159);
            this.textname.Name = "textname";
            this.textname.Size = new System.Drawing.Size(117, 23);
            this.textname.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Surname";
            // 
            // textsurname
            // 
            this.textsurname.Location = new System.Drawing.Point(135, 203);
            this.textsurname.Name = "textsurname";
            this.textsurname.Size = new System.Drawing.Size(117, 23);
            this.textsurname.TabIndex = 1;
            // 
            // submitbtn
            // 
            this.submitbtn.Location = new System.Drawing.Point(192, 245);
            this.submitbtn.Name = "submitbtn";
            this.submitbtn.Size = new System.Drawing.Size(60, 33);
            this.submitbtn.TabIndex = 2;
            this.submitbtn.Text = "Submit";
            this.submitbtn.UseVisualStyleBackColor = true;
            this.submitbtn.Click += new System.EventHandler(this.submitbtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(267, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 27);
            this.button1.TabIndex = 3;
            this.button1.Text = "👁";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_MouseDown);
            this.button1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_MouseUp);
            // 
            // Sign_Up
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(312, 303);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.submitbtn);
            this.Controls.Add(this.textsurname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textrepassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textpassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtlogin);
            this.Controls.Add(this.label1);
            this.Name = "Sign_Up";
            this.Text = "New user";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtlogin;
        private Label label2;
        private TextBox textpassword;
        private Label label3;
        private TextBox textrepassword;
        private Label label4;
        private TextBox textname;
        private Label label5;
        private TextBox textsurname;
        private Button submitbtn;
        private Button button1;
    }
}