
namespace BT02_102190381_TranVanThai
{
    partial class Form2
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
            this.GR1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.GB2 = new System.Windows.Forms.GroupBox();
            this.female = new System.Windows.Forms.RadioButton();
            this.male = new System.Windows.Forms.RadioButton();
            this.BT2 = new System.Windows.Forms.Button();
            this.BT1 = new System.Windows.Forms.Button();
            this.cbbLSH = new System.Windows.Forms.ComboBox();
            this.tname = new System.Windows.Forms.TextBox();
            this.tmssv = new System.Windows.Forms.TextBox();
            this.LB3 = new System.Windows.Forms.Label();
            this.LB2 = new System.Windows.Forms.Label();
            this.LB1 = new System.Windows.Forms.Label();
            this.GR1.SuspendLayout();
            this.GB2.SuspendLayout();
            this.SuspendLayout();
            // 
            // GR1
            // 
            this.GR1.Controls.Add(this.dateTimePicker1);
            this.GR1.Controls.Add(this.GB2);
            this.GR1.Controls.Add(this.BT2);
            this.GR1.Controls.Add(this.BT1);
            this.GR1.Controls.Add(this.cbbLSH);
            this.GR1.Controls.Add(this.tname);
            this.GR1.Controls.Add(this.tmssv);
            this.GR1.Controls.Add(this.LB3);
            this.GR1.Controls.Add(this.LB2);
            this.GR1.Controls.Add(this.LB1);
            this.GR1.Location = new System.Drawing.Point(17, 28);
            this.GR1.Name = "GR1";
            this.GR1.Size = new System.Drawing.Size(767, 394);
            this.GR1.TabIndex = 2;
            this.GR1.TabStop = false;
            this.GR1.Text = "Thong tin SV";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(388, 40);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(311, 22);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // GB2
            // 
            this.GB2.Controls.Add(this.female);
            this.GB2.Controls.Add(this.male);
            this.GB2.Location = new System.Drawing.Point(388, 109);
            this.GB2.Name = "GB2";
            this.GB2.Size = new System.Drawing.Size(311, 100);
            this.GB2.TabIndex = 8;
            this.GB2.TabStop = false;
            this.GB2.Text = "Gender";
            // 
            // female
            // 
            this.female.AutoSize = true;
            this.female.Location = new System.Drawing.Point(149, 33);
            this.female.Name = "female";
            this.female.Size = new System.Drawing.Size(75, 21);
            this.female.TabIndex = 10;
            this.female.TabStop = true;
            this.female.Text = "Female";
            this.female.UseVisualStyleBackColor = true;
            // 
            // male
            // 
            this.male.AutoSize = true;
            this.male.Location = new System.Drawing.Point(17, 34);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(59, 21);
            this.male.TabIndex = 9;
            this.male.TabStop = true;
            this.male.Text = "Male";
            this.male.UseVisualStyleBackColor = true;
            // 
            // BT2
            // 
            this.BT2.Location = new System.Drawing.Point(481, 281);
            this.BT2.Name = "BT2";
            this.BT2.Size = new System.Drawing.Size(75, 23);
            this.BT2.TabIndex = 7;
            this.BT2.Text = "Cancer";
            this.BT2.UseVisualStyleBackColor = true;
            // 
            // BT1
            // 
            this.BT1.Location = new System.Drawing.Point(250, 281);
            this.BT1.Name = "BT1";
            this.BT1.Size = new System.Drawing.Size(75, 35);
            this.BT1.TabIndex = 6;
            this.BT1.Text = "OK";
            this.BT1.UseVisualStyleBackColor = true;
            this.BT1.Click += new System.EventHandler(this.BT1_Click);
            // 
            // cbbLSH
            // 
            this.cbbLSH.FormattingEnabled = true;
            this.cbbLSH.Location = new System.Drawing.Point(114, 142);
            this.cbbLSH.Name = "cbbLSH";
            this.cbbLSH.Size = new System.Drawing.Size(121, 24);
            this.cbbLSH.TabIndex = 5;
            // 
            // tname
            // 
            this.tname.Location = new System.Drawing.Point(114, 97);
            this.tname.Name = "tname";
            this.tname.Size = new System.Drawing.Size(148, 22);
            this.tname.TabIndex = 4;
            // 
            // tmssv
            // 
            this.tmssv.Location = new System.Drawing.Point(114, 55);
            this.tmssv.Name = "tmssv";
            this.tmssv.Size = new System.Drawing.Size(148, 22);
            this.tmssv.TabIndex = 3;
            this.tmssv.Text = "\r\n";
            // 
            // LB3
            // 
            this.LB3.AutoSize = true;
            this.LB3.Location = new System.Drawing.Point(34, 149);
            this.LB3.Name = "LB3";
            this.LB3.Size = new System.Drawing.Size(51, 17);
            this.LB3.TabIndex = 2;
            this.LB3.Text = "LopSH";
            // 
            // LB2
            // 
            this.LB2.AutoSize = true;
            this.LB2.Location = new System.Drawing.Point(34, 97);
            this.LB2.Name = "LB2";
            this.LB2.Size = new System.Drawing.Size(45, 17);
            this.LB2.TabIndex = 1;
            this.LB2.Text = "Name";
            // 
            // LB1
            // 
            this.LB1.AutoSize = true;
            this.LB1.Location = new System.Drawing.Point(34, 55);
            this.LB1.Name = "LB1";
            this.LB1.Size = new System.Drawing.Size(46, 17);
            this.LB1.TabIndex = 0;
            this.LB1.Text = "MSSV";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GR1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.GR1.ResumeLayout(false);
            this.GR1.PerformLayout();
            this.GB2.ResumeLayout(false);
            this.GB2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GR1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox GB2;
        private System.Windows.Forms.RadioButton female;
        private System.Windows.Forms.RadioButton male;
        private System.Windows.Forms.Button BT2;
        private System.Windows.Forms.Button BT1;
        private System.Windows.Forms.ComboBox cbbLSH;
        private System.Windows.Forms.TextBox tname;
        private System.Windows.Forms.TextBox tmssv;
        private System.Windows.Forms.Label LB3;
        private System.Windows.Forms.Label LB2;
        private System.Windows.Forms.Label LB1;
    }
}