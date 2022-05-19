﻿
namespace PBL3.View.tour
{
    partial class FormAddEditTour
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
            this.TourCategory = new System.Windows.Forms.Label();
            this.cbbTourCategory = new System.Windows.Forms.ComboBox();
            this.lbTitle = new System.Windows.Forms.Label();
            this.txtPricePercentChildren = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTotalChildren = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProfit = new System.Windows.Forms.TextBox();
            this.txtVAT = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtTotalAdult = new System.Windows.Forms.TextBox();
            this.lbTotal = new System.Windows.Forms.Label();
            this.lbDescription = new System.Windows.Forms.Label();
            this.dtpDepartureDate = new System.Windows.Forms.DateTimePicker();
            this.lbReturnDate = new System.Windows.Forms.Label();
            this.dtpReturnDate = new System.Windows.Forms.DateTimePicker();
            this.lbDepartureDate = new System.Windows.Forms.Label();
            this.txtTourName = new System.Windows.Forms.TextBox();
            this.lbTourName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rtbShortDesc = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotalPriceService = new System.Windows.Forms.TextBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.htmlDescription = new System.Windows.Forms.WebBrowser();
            this.txtImage = new System.Windows.Forms.Label();
            this.panelPicture = new System.Windows.Forms.Panel();
            this.btnAddImage = new System.Windows.Forms.Button();
            this.lbTransport = new System.Windows.Forms.Label();
            this.txtTransport = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TourCategory
            // 
            this.TourCategory.AutoSize = true;
            this.TourCategory.Location = new System.Drawing.Point(40, 197);
            this.TourCategory.Name = "TourCategory";
            this.TourCategory.Size = new System.Drawing.Size(99, 17);
            this.TourCategory.TabIndex = 71;
            this.TourCategory.Text = "Tour Category";
            // 
            // cbbTourCategory
            // 
            this.cbbTourCategory.FormattingEnabled = true;
            this.cbbTourCategory.Location = new System.Drawing.Point(173, 194);
            this.cbbTourCategory.Name = "cbbTourCategory";
            this.cbbTourCategory.Size = new System.Drawing.Size(307, 24);
            this.cbbTourCategory.TabIndex = 70;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTitle.Location = new System.Drawing.Point(530, 17);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(96, 31);
            this.lbTitle.TabIndex = 66;
            this.lbTitle.Text = "TOUR";
            // 
            // txtPricePercentChildren
            // 
            this.txtPricePercentChildren.Location = new System.Drawing.Point(712, 146);
            this.txtPricePercentChildren.Name = "txtPricePercentChildren";
            this.txtPricePercentChildren.Size = new System.Drawing.Size(125, 22);
            this.txtPricePercentChildren.TabIndex = 65;
            this.txtPricePercentChildren.TextChanged += new System.EventHandler(this.txtTextChange);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(559, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 17);
            this.label4.TabIndex = 64;
            this.label4.Text = "Price (%) By Children";
            // 
            // txtTotalChildren
            // 
            this.txtTotalChildren.Enabled = false;
            this.txtTotalChildren.Location = new System.Drawing.Point(968, 192);
            this.txtTotalChildren.Name = "txtTotalChildren";
            this.txtTotalChildren.Size = new System.Drawing.Size(144, 22);
            this.txtTotalChildren.TabIndex = 63;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(858, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 17);
            this.label3.TabIndex = 62;
            this.label3.Text = "Price / Children";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(858, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 61;
            this.label2.Text = "Profit(%)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(858, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 60;
            this.label1.Text = "VAT(%)";
            // 
            // txtProfit
            // 
            this.txtProfit.Location = new System.Drawing.Point(968, 96);
            this.txtProfit.Name = "txtProfit";
            this.txtProfit.Size = new System.Drawing.Size(144, 22);
            this.txtProfit.TabIndex = 59;
            this.txtProfit.TextChanged += new System.EventHandler(this.txtTextChange);
            // 
            // txtVAT
            // 
            this.txtVAT.Location = new System.Drawing.Point(968, 146);
            this.txtVAT.Name = "txtVAT";
            this.txtVAT.Size = new System.Drawing.Size(144, 22);
            this.txtVAT.TabIndex = 58;
            this.txtVAT.TextChanged += new System.EventHandler(this.txtTextChange);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(368, 653);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 33);
            this.btnBack.TabIndex = 57;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(606, 651);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(84, 35);
            this.btnClear.TabIndex = 56;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(828, 651);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(87, 35);
            this.btnSave.TabIndex = 55;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtTotalAdult
            // 
            this.txtTotalAdult.Enabled = false;
            this.txtTotalAdult.Location = new System.Drawing.Point(712, 192);
            this.txtTotalAdult.Name = "txtTotalAdult";
            this.txtTotalAdult.Size = new System.Drawing.Size(125, 22);
            this.txtTotalAdult.TabIndex = 54;
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Location = new System.Drawing.Point(559, 200);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(84, 17);
            this.lbTotal.TabIndex = 53;
            this.lbTotal.Text = "Price / Adult";
            // 
            // lbDescription
            // 
            this.lbDescription.AutoSize = true;
            this.lbDescription.Location = new System.Drawing.Point(46, 465);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(79, 17);
            this.lbDescription.TabIndex = 51;
            this.lbDescription.Text = "Description";
            // 
            // dtpDepartureDate
            // 
            this.dtpDepartureDate.Location = new System.Drawing.Point(173, 106);
            this.dtpDepartureDate.Name = "dtpDepartureDate";
            this.dtpDepartureDate.Size = new System.Drawing.Size(307, 22);
            this.dtpDepartureDate.TabIndex = 47;
            // 
            // lbReturnDate
            // 
            this.lbReturnDate.AutoSize = true;
            this.lbReturnDate.Location = new System.Drawing.Point(40, 149);
            this.lbReturnDate.Name = "lbReturnDate";
            this.lbReturnDate.Size = new System.Drawing.Size(85, 17);
            this.lbReturnDate.TabIndex = 46;
            this.lbReturnDate.Text = "Return Date";
            // 
            // dtpReturnDate
            // 
            this.dtpReturnDate.Location = new System.Drawing.Point(173, 149);
            this.dtpReturnDate.Name = "dtpReturnDate";
            this.dtpReturnDate.Size = new System.Drawing.Size(307, 22);
            this.dtpReturnDate.TabIndex = 45;
            // 
            // lbDepartureDate
            // 
            this.lbDepartureDate.AutoSize = true;
            this.lbDepartureDate.Location = new System.Drawing.Point(40, 106);
            this.lbDepartureDate.Name = "lbDepartureDate";
            this.lbDepartureDate.Size = new System.Drawing.Size(106, 17);
            this.lbDepartureDate.TabIndex = 44;
            this.lbDepartureDate.Text = "Departure Date";
            // 
            // txtTourName
            // 
            this.txtTourName.Location = new System.Drawing.Point(173, 62);
            this.txtTourName.Name = "txtTourName";
            this.txtTourName.Size = new System.Drawing.Size(307, 22);
            this.txtTourName.TabIndex = 43;
            // 
            // lbTourName
            // 
            this.lbTourName.AutoSize = true;
            this.lbTourName.Location = new System.Drawing.Point(37, 62);
            this.lbTourName.Name = "lbTourName";
            this.lbTourName.Size = new System.Drawing.Size(79, 17);
            this.lbTourName.TabIndex = 42;
            this.lbTourName.Text = "Tour Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(559, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 17);
            this.label5.TabIndex = 72;
            this.label5.Text = "Short Description";
            // 
            // rtbShortDesc
            // 
            this.rtbShortDesc.Location = new System.Drawing.Point(712, 245);
            this.rtbShortDesc.Name = "rtbShortDesc";
            this.rtbShortDesc.Size = new System.Drawing.Size(400, 148);
            this.rtbShortDesc.TabIndex = 73;
            this.rtbShortDesc.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(559, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 17);
            this.label6.TabIndex = 74;
            this.label6.Text = "Total price service";
            // 
            // txtTotalPriceService
            // 
            this.txtTotalPriceService.Location = new System.Drawing.Point(712, 101);
            this.txtTotalPriceService.Name = "txtTotalPriceService";
            this.txtTotalPriceService.Size = new System.Drawing.Size(125, 22);
            this.txtTotalPriceService.TabIndex = 75;
            this.txtTotalPriceService.TextChanged += new System.EventHandler(this.txtTextChange);
            // 
            // btnOpen
            // 
            this.btnOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpen.Location = new System.Drawing.Point(40, 504);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(94, 50);
            this.btnOpen.TabIndex = 76;
            this.btnOpen.Text = "Edit";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // htmlDescription
            // 
            this.htmlDescription.Location = new System.Drawing.Point(173, 414);
            this.htmlDescription.MinimumSize = new System.Drawing.Size(20, 20);
            this.htmlDescription.Name = "htmlDescription";
            this.htmlDescription.Size = new System.Drawing.Size(939, 222);
            this.htmlDescription.TabIndex = 77;
            // 
            // txtImage
            // 
            this.txtImage.AutoSize = true;
            this.txtImage.Location = new System.Drawing.Point(58, 285);
            this.txtImage.Name = "txtImage";
            this.txtImage.Size = new System.Drawing.Size(46, 17);
            this.txtImage.TabIndex = 78;
            this.txtImage.Text = "Image";
            // 
            // panelPicture
            // 
            this.panelPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPicture.Location = new System.Drawing.Point(173, 242);
            this.panelPicture.Name = "panelPicture";
            this.panelPicture.Size = new System.Drawing.Size(185, 151);
            this.panelPicture.TabIndex = 79;
            // 
            // btnAddImage
            // 
            this.btnAddImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddImage.Location = new System.Drawing.Point(40, 315);
            this.btnAddImage.Name = "btnAddImage";
            this.btnAddImage.Size = new System.Drawing.Size(94, 40);
            this.btnAddImage.TabIndex = 80;
            this.btnAddImage.Text = "Add";
            this.btnAddImage.UseVisualStyleBackColor = true;
            this.btnAddImage.Click += new System.EventHandler(this.btnAddImage_Click);
            // 
            // lbTransport
            // 
            this.lbTransport.AutoSize = true;
            this.lbTransport.Location = new System.Drawing.Point(556, 65);
            this.lbTransport.Name = "lbTransport";
            this.lbTransport.Size = new System.Drawing.Size(70, 17);
            this.lbTransport.TabIndex = 81;
            this.lbTransport.Text = "Transport";
            // 
            // txtTransport
            // 
            this.txtTransport.Location = new System.Drawing.Point(712, 62);
            this.txtTransport.Name = "txtTransport";
            this.txtTransport.Size = new System.Drawing.Size(400, 22);
            this.txtTransport.TabIndex = 82;
            // 
            // FormAddEditTour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtTransport);
            this.Controls.Add(this.lbTransport);
            this.Controls.Add(this.btnAddImage);
            this.Controls.Add(this.panelPicture);
            this.Controls.Add(this.txtImage);
            this.Controls.Add(this.htmlDescription);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.txtTotalPriceService);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rtbShortDesc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TourCategory);
            this.Controls.Add(this.cbbTourCategory);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.txtPricePercentChildren);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTotalChildren);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtProfit);
            this.Controls.Add(this.txtVAT);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtTotalAdult);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.lbDescription);
            this.Controls.Add(this.dtpDepartureDate);
            this.Controls.Add(this.lbReturnDate);
            this.Controls.Add(this.dtpReturnDate);
            this.Controls.Add(this.lbDepartureDate);
            this.Controls.Add(this.txtTourName);
            this.Controls.Add(this.lbTourName);
            this.Name = "FormAddEditTour";
            this.Size = new System.Drawing.Size(1156, 698);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TourCategory;
        private System.Windows.Forms.ComboBox cbbTourCategory;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.TextBox txtPricePercentChildren;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTotalChildren;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProfit;
        private System.Windows.Forms.TextBox txtVAT;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtTotalAdult;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.DateTimePicker dtpDepartureDate;
        private System.Windows.Forms.Label lbReturnDate;
        private System.Windows.Forms.DateTimePicker dtpReturnDate;
        private System.Windows.Forms.Label lbDepartureDate;
        private System.Windows.Forms.TextBox txtTourName;
        private System.Windows.Forms.Label lbTourName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox rtbShortDesc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTotalPriceService;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.WebBrowser htmlDescription;
        private System.Windows.Forms.Label txtImage;
        private System.Windows.Forms.Panel panelPicture;
        private System.Windows.Forms.Button btnAddImage;
        private System.Windows.Forms.Label lbTransport;
        private System.Windows.Forms.TextBox txtTransport;
    }
}
