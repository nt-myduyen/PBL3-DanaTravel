﻿
namespace PBL3.View.tour
{
    partial class FormAddTransport
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
            this.btnChoose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.pictureTransport = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTransport)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChoose
            // 
            this.btnChoose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(120)))), ((int)(((byte)(142)))));
            this.btnChoose.ForeColor = System.Drawing.Color.White;
            this.btnChoose.Image = global::PBL3.Properties.Resources.choose_1_102356;
            this.btnChoose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChoose.Location = new System.Drawing.Point(52, 176);
            this.btnChoose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(112, 41);
            this.btnChoose.TabIndex = 1;
            this.btnChoose.Text = "Choose Image";
            this.btnChoose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChoose.UseVisualStyleBackColor = false;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(120)))), ((int)(((byte)(142)))));
            this.label1.Location = new System.Drawing.Point(227, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Transport:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(120)))), ((int)(((byte)(142)))));
            this.label2.Location = new System.Drawing.Point(232, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Price:";
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(120)))), ((int)(((byte)(142)))));
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.Image = global::PBL3.Properties.Resources._1486485557_add_create_new_more_plus_81188;
            this.btnCreate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreate.Location = new System.Drawing.Point(433, 176);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(82, 41);
            this.btnCreate.TabIndex = 4;
            this.btnCreate.Text = "Create";
            this.btnCreate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(305, 46);
            this.txtName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(230, 20);
            this.txtName.TabIndex = 5;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(305, 98);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(230, 20);
            this.txtPrice.TabIndex = 6;
            // 
            // pictureTransport
            // 
            this.pictureTransport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureTransport.Image = global::PBL3.Properties.Resources.picture_file_image_photo_gallery_icon_219497;
            this.pictureTransport.Location = new System.Drawing.Point(35, 24);
            this.pictureTransport.Margin = new System.Windows.Forms.Padding(2);
            this.pictureTransport.Name = "pictureTransport";
            this.pictureTransport.Size = new System.Drawing.Size(154, 140);
            this.pictureTransport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureTransport.TabIndex = 0;
            this.pictureTransport.TabStop = false;
            // 
            // FormAddTransport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(221)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(616, 228);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnChoose);
            this.Controls.Add(this.pictureTransport);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormAddTransport";
            this.Text = "AddTransport";
            ((System.ComponentModel.ISupportInitialize)(this.pictureTransport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureTransport;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPrice;
    }
}