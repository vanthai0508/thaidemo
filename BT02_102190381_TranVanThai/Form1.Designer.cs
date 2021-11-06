
namespace BT02_102190381_TranVanThai
{
    partial class Form1
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
            this.GB3 = new System.Windows.Forms.GroupBox();
            this.CBBSET = new System.Windows.Forms.ComboBox();
            this.bset = new System.Windows.Forms.Button();
            this.bdel = new System.Windows.Forms.Button();
            this.bedit = new System.Windows.Forms.Button();
            this.badd = new System.Windows.Forms.Button();
            this.bshow = new System.Windows.Forms.Button();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.BT3 = new System.Windows.Forms.Button();
            this.tsearch = new System.Windows.Forms.TextBox();
            this.CBBLSH = new System.Windows.Forms.ComboBox();
            this.LB4 = new System.Windows.Forms.Label();
            this.GB3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // GB3
            // 
            this.GB3.Controls.Add(this.CBBSET);
            this.GB3.Controls.Add(this.bset);
            this.GB3.Controls.Add(this.bdel);
            this.GB3.Controls.Add(this.bedit);
            this.GB3.Controls.Add(this.badd);
            this.GB3.Controls.Add(this.bshow);
            this.GB3.Controls.Add(this.DGV);
            this.GB3.Location = new System.Drawing.Point(40, 77);
            this.GB3.Name = "GB3";
            this.GB3.Size = new System.Drawing.Size(721, 348);
            this.GB3.TabIndex = 9;
            this.GB3.TabStop = false;
            this.GB3.Text = "Danh sach SV";
            // 
            // CBBSET
            // 
            this.CBBSET.FormattingEnabled = true;
            this.CBBSET.Location = new System.Drawing.Point(557, 290);
            this.CBBSET.Name = "CBBSET";
            this.CBBSET.Size = new System.Drawing.Size(145, 24);
            this.CBBSET.TabIndex = 6;
            this.CBBSET.SelectedIndexChanged += new System.EventHandler(this.CBBSET_SelectedIndexChanged);
            // 
            // bset
            // 
            this.bset.Location = new System.Drawing.Point(467, 290);
            this.bset.Name = "bset";
            this.bset.Size = new System.Drawing.Size(75, 23);
            this.bset.TabIndex = 5;
            this.bset.Text = "Set";
            this.bset.UseVisualStyleBackColor = true;
            this.bset.Click += new System.EventHandler(this.BT8_Click);
            // 
            // bdel
            // 
            this.bdel.Location = new System.Drawing.Point(359, 290);
            this.bdel.Name = "bdel";
            this.bdel.Size = new System.Drawing.Size(75, 23);
            this.bdel.TabIndex = 4;
            this.bdel.Text = "Del";
            this.bdel.UseVisualStyleBackColor = true;
            this.bdel.Click += new System.EventHandler(this.bdel_Click);
            // 
            // bedit
            // 
            this.bedit.Location = new System.Drawing.Point(248, 290);
            this.bedit.Name = "bedit";
            this.bedit.Size = new System.Drawing.Size(75, 23);
            this.bedit.TabIndex = 3;
            this.bedit.Text = "Edit";
            this.bedit.UseVisualStyleBackColor = true;
            this.bedit.Click += new System.EventHandler(this.bedit_Click);
            // 
            // badd
            // 
            this.badd.Location = new System.Drawing.Point(131, 290);
            this.badd.Name = "badd";
            this.badd.Size = new System.Drawing.Size(75, 23);
            this.badd.TabIndex = 2;
            this.badd.Text = "add";
            this.badd.UseVisualStyleBackColor = true;
            this.badd.Click += new System.EventHandler(this.badd_Click);
            // 
            // bshow
            // 
            this.bshow.Location = new System.Drawing.Point(16, 290);
            this.bshow.Name = "bshow";
            this.bshow.Size = new System.Drawing.Size(75, 23);
            this.bshow.TabIndex = 1;
            this.bshow.Text = "Show";
            this.bshow.UseVisualStyleBackColor = true;
            // 
            // DGV
            // 
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Location = new System.Drawing.Point(27, 31);
            this.DGV.Name = "DGV";
            this.DGV.RowHeadersWidth = 51;
            this.DGV.RowTemplate.Height = 24;
            this.DGV.Size = new System.Drawing.Size(675, 226);
            this.DGV.TabIndex = 0;
            // 
            // BT3
            // 
            this.BT3.Location = new System.Drawing.Point(686, 25);
            this.BT3.Name = "BT3";
            this.BT3.Size = new System.Drawing.Size(75, 23);
            this.BT3.TabIndex = 8;
            this.BT3.Text = "search";
            this.BT3.UseVisualStyleBackColor = true;
            // 
            // tsearch
            // 
            this.tsearch.Location = new System.Drawing.Point(496, 26);
            this.tsearch.Name = "tsearch";
            this.tsearch.Size = new System.Drawing.Size(166, 22);
            this.tsearch.TabIndex = 7;
            this.tsearch.TextChanged += new System.EventHandler(this.tsearch_TextChanged);
            // 
            // CBBLSH
            // 
            this.CBBLSH.FormattingEnabled = true;
            this.CBBLSH.Location = new System.Drawing.Point(134, 25);
            this.CBBLSH.Name = "CBBLSH";
            this.CBBLSH.Size = new System.Drawing.Size(154, 24);
            this.CBBLSH.TabIndex = 6;
            this.CBBLSH.SelectedIndexChanged += new System.EventHandler(this.CBBLSH_SelectedIndexChanged);
            // 
            // LB4
            // 
            this.LB4.AutoSize = true;
            this.LB4.Location = new System.Drawing.Point(64, 32);
            this.LB4.Name = "LB4";
            this.LB4.Size = new System.Drawing.Size(51, 17);
            this.LB4.TabIndex = 5;
            this.LB4.Text = "LopSH";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GB3);
            this.Controls.Add(this.BT3);
            this.Controls.Add(this.tsearch);
            this.Controls.Add(this.CBBLSH);
            this.Controls.Add(this.LB4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GB3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GB3;
        private System.Windows.Forms.ComboBox CBBSET;
        private System.Windows.Forms.Button bset;
        private System.Windows.Forms.Button bdel;
        private System.Windows.Forms.Button bedit;
        private System.Windows.Forms.Button badd;
        private System.Windows.Forms.Button bshow;
        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.Button BT3;
        private System.Windows.Forms.TextBox tsearch;
        private System.Windows.Forms.ComboBox CBBLSH;
        private System.Windows.Forms.Label LB4;
    }
}

