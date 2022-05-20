﻿
namespace PBL3.View
{
    partial class AccountEmployee
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dataAccount = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.myTextBox1 = new MyLibrary.MyTextBox();
            this.btnLock = new System.Windows.Forms.Button();
            this.btnUnlock = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataAccount)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.lbTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(120)))), ((int)(((byte)(142)))));
            this.lbTotal.Location = new System.Drawing.Point(142, 84);
            this.lbTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(52, 19);
            this.lbTotal.TabIndex = 0;
            this.lbTotal.Text = "Total:";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(195, 81);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(76, 20);
            this.txtTotal.TabIndex = 1;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(549, 84);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(96, 20);
            this.txtSearch.TabIndex = 2;
            // 
            // dataAccount
            // 
            this.dataAccount.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(221)))), ((int)(((byte)(229)))));
            this.dataAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataAccount.Location = new System.Drawing.Point(145, 174);
            this.dataAccount.Margin = new System.Windows.Forms.Padding(2);
            this.dataAccount.Name = "dataAccount";
            this.dataAccount.RowHeadersWidth = 51;
            this.dataAccount.RowTemplate.Height = 24;
            this.dataAccount.Size = new System.Drawing.Size(562, 288);
            this.dataAccount.TabIndex = 4;
            this.dataAccount.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataAccount_RowHeaderMouseClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(174)))), ((int)(((byte)(208)))));
            this.panel3.Controls.Add(this.myTextBox1);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(991, 43);
            this.panel3.TabIndex = 29;
            // 
            // myTextBox1
            // 
            this.myTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(174)))), ((int)(((byte)(208)))));
            this.myTextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(141)))), ((int)(((byte)(165)))));
            this.myTextBox1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.myTextBox1.BorderRadius = 0;
            this.myTextBox1.BorderSize = 2;
            this.myTextBox1.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myTextBox1.ForeColor = System.Drawing.Color.White;
            this.myTextBox1.Location = new System.Drawing.Point(30, 5);
            this.myTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.myTextBox1.Multiline = false;
            this.myTextBox1.Name = "myTextBox1";
            this.myTextBox1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.myTextBox1.PasswordChar = false;
            this.myTextBox1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.myTextBox1.PlaceholderText = "";
            this.myTextBox1.Size = new System.Drawing.Size(269, 34);
            this.myTextBox1.TabIndex = 1;
            this.myTextBox1.Texts = "Account Employee Management";
            this.myTextBox1.UnderlinedStyle = true;
            // 
            // btnLock
            // 
            this.btnLock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(120)))), ((int)(((byte)(142)))));
            this.btnLock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLock.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLock.ForeColor = System.Drawing.Color.White;
            this.btnLock.Image = global::PBL3.Properties.Resources.Lock;
            this.btnLock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLock.Location = new System.Drawing.Point(143, 483);
            this.btnLock.Margin = new System.Windows.Forms.Padding(2);
            this.btnLock.Name = "btnLock";
            this.btnLock.Size = new System.Drawing.Size(118, 31);
            this.btnLock.TabIndex = 6;
            this.btnLock.Text = "Lock Account";
            this.btnLock.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLock.UseVisualStyleBackColor = false;
            this.btnLock.Click += new System.EventHandler(this.btnLock_Click);
            // 
            // btnUnlock
            // 
            this.btnUnlock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(120)))), ((int)(((byte)(142)))));
            this.btnUnlock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUnlock.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.btnUnlock.ForeColor = System.Drawing.Color.White;
            this.btnUnlock.Image = global::PBL3.Properties.Resources.UnLock;
            this.btnUnlock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUnlock.Location = new System.Drawing.Point(589, 483);
            this.btnUnlock.Margin = new System.Windows.Forms.Padding(2);
            this.btnUnlock.Name = "btnUnlock";
            this.btnUnlock.Size = new System.Drawing.Size(118, 31);
            this.btnUnlock.TabIndex = 5;
            this.btnUnlock.Text = "Unlock Account";
            this.btnUnlock.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUnlock.UseVisualStyleBackColor = false;
            this.btnUnlock.Click += new System.EventHandler(this.btnUnlock_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(120)))), ((int)(((byte)(142)))));
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Image = global::PBL3.Properties.Resources.Search_find_locate_1542;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(651, 76);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(91, 33);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(336, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // AccountEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(221)))), ((int)(((byte)(229)))));
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnLock);
            this.Controls.Add(this.btnUnlock);
            this.Controls.Add(this.dataAccount);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lbTotal);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AccountEmployee";
            this.Size = new System.Drawing.Size(867, 567);
            this.Load += new System.EventHandler(this.AccountEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataAccount)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dataAccount;
        private System.Windows.Forms.Button btnUnlock;
        private System.Windows.Forms.Button btnLock;
        private System.Windows.Forms.Panel panel3;
        private MyLibrary.MyTextBox myTextBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
