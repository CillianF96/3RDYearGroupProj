using System.Drawing;
using System.Windows.Forms;
namespace ConsolatioWireFrames
{
    partial class formMakePayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMakePayment));
            this.btnMakePaymentClose = new System.Windows.Forms.Button();
            this.grpMakePayment = new System.Windows.Forms.GroupBox();
            this.chkMakePaymentVoucher = new System.Windows.Forms.CheckBox();
            this.chkMakePaymentAddToRoom = new System.Windows.Forms.CheckBox();
            this.chkMakePaymentNewCard = new System.Windows.Forms.CheckBox();
            this.chkMakePaymentCash = new System.Windows.Forms.CheckBox();
            this.btnMakePaymentConfirm = new System.Windows.Forms.Button();
            this.lblMakePaymentVoucherNum = new System.Windows.Forms.Label();
            this.txtMakePaymentVoucherNum = new System.Windows.Forms.TextBox();
            this.grpMakePaymentVoucherNum = new System.Windows.Forms.GroupBox();
            this.txtMakePaymentVoucherAmount = new System.Windows.Forms.TextBox();
            this.llMakePaymentVoucherAmount = new System.Windows.Forms.Label();
            this.grbCardDetails = new System.Windows.Forms.GroupBox();
            this.txtMakePaymentCardAmount = new System.Windows.Forms.TextBox();
            this.txtMakePaymentExpiryDate = new System.Windows.Forms.TextBox();
            this.txtMakePaymentCardType = new System.Windows.Forms.TextBox();
            this.txtMakePaymentCardName = new System.Windows.Forms.TextBox();
            this.txtMakePaymentCardNumber = new System.Windows.Forms.TextBox();
            this.txtMakePaymentCvv = new System.Windows.Forms.TextBox();
            this.lblMakePaymentAmount = new System.Windows.Forms.Label();
            this.lblMakePaymentCvv = new System.Windows.Forms.Label();
            this.lblMakePaymentExpiryDate = new System.Windows.Forms.Label();
            this.lblMakePaymentCardName = new System.Windows.Forms.Label();
            this.lblMakePaymentCardNumber = new System.Windows.Forms.Label();
            this.lblMakePaymentCardType = new System.Windows.Forms.Label();
            this.grbMakePaymentCash = new System.Windows.Forms.GroupBox();
            this.txtMakePaymentCashAmount = new System.Windows.Forms.TextBox();
            this.lblMakePaymentCashAmount = new System.Windows.Forms.Label();
            this.grbMakePaymentRoomDetails = new System.Windows.Forms.GroupBox();
            this.txtMakePaymentName = new System.Windows.Forms.TextBox();
            this.lblMakePaymentName = new System.Windows.Forms.Label();
            this.txtMakePaymentRoomNumber = new System.Windows.Forms.TextBox();
            this.lblMakePaymentRoomNumber = new System.Windows.Forms.Label();
            this.grpMakePayment.SuspendLayout();
            this.grpMakePaymentVoucherNum.SuspendLayout();
            this.grbCardDetails.SuspendLayout();
            this.grbMakePaymentCash.SuspendLayout();
            this.grbMakePaymentRoomDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMakePaymentClose
            // 
            this.btnMakePaymentClose.Location = new System.Drawing.Point(549, 435);
            this.btnMakePaymentClose.Name = "btnMakePaymentClose";
            this.btnMakePaymentClose.Size = new System.Drawing.Size(131, 46);
            this.btnMakePaymentClose.TabIndex = 6;
            this.btnMakePaymentClose.Text = "&Close";
            this.btnMakePaymentClose.UseVisualStyleBackColor = true;
            this.btnMakePaymentClose.Click += new System.EventHandler(this.btnMakePaymentClose_Click);
            // 
            // grpMakePayment
            // 
            this.grpMakePayment.Controls.Add(this.chkMakePaymentVoucher);
            this.grpMakePayment.Controls.Add(this.chkMakePaymentAddToRoom);
            this.grpMakePayment.Controls.Add(this.chkMakePaymentNewCard);
            this.grpMakePayment.Controls.Add(this.chkMakePaymentCash);
            this.grpMakePayment.Location = new System.Drawing.Point(17, 25);
            this.grpMakePayment.Name = "grpMakePayment";
            this.grpMakePayment.Size = new System.Drawing.Size(339, 97);
            this.grpMakePayment.TabIndex = 2;
            this.grpMakePayment.TabStop = false;
            this.grpMakePayment.Text = "Payment Method";
            this.grpMakePayment.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // chkMakePaymentVoucher
            // 
            this.chkMakePaymentVoucher.AutoSize = true;
            this.chkMakePaymentVoucher.Location = new System.Drawing.Point(180, 57);
            this.chkMakePaymentVoucher.Name = "chkMakePaymentVoucher";
            this.chkMakePaymentVoucher.Size = new System.Drawing.Size(95, 24);
            this.chkMakePaymentVoucher.TabIndex = 4;
            this.chkMakePaymentVoucher.Text = "&Voucher";
            this.chkMakePaymentVoucher.UseVisualStyleBackColor = true;
            this.chkMakePaymentVoucher.CheckedChanged += new System.EventHandler(this.chkMakePaymentVoucher_CheckedChanged);
            // 
            // chkMakePaymentAddToRoom
            // 
            this.chkMakePaymentAddToRoom.AutoSize = true;
            this.chkMakePaymentAddToRoom.Location = new System.Drawing.Point(57, 57);
            this.chkMakePaymentAddToRoom.Name = "chkMakePaymentAddToRoom";
            this.chkMakePaymentAddToRoom.Size = new System.Drawing.Size(122, 24);
            this.chkMakePaymentAddToRoom.TabIndex = 3;
            this.chkMakePaymentAddToRoom.Text = "A&dd to room";
            this.chkMakePaymentAddToRoom.UseVisualStyleBackColor = true;
            this.chkMakePaymentAddToRoom.CheckedChanged += new System.EventHandler(this.chkMakePaymentAddToRoom_CheckedChanged);
            // 
            // chkMakePaymentNewCard
            // 
            this.chkMakePaymentNewCard.AutoSize = true;
            this.chkMakePaymentNewCard.Location = new System.Drawing.Point(180, 31);
            this.chkMakePaymentNewCard.Name = "chkMakePaymentNewCard";
            this.chkMakePaymentNewCard.Size = new System.Drawing.Size(154, 24);
            this.chkMakePaymentNewCard.TabIndex = 2;
            this.chkMakePaymentNewCard.Text = "C&redit/Debit card";
            this.chkMakePaymentNewCard.UseVisualStyleBackColor = true;
            this.chkMakePaymentNewCard.CheckedChanged += new System.EventHandler(this.chkMakePaymentNewCard_CheckedChanged);
            // 
            // chkMakePaymentCash
            // 
            this.chkMakePaymentCash.AutoSize = true;
            this.chkMakePaymentCash.Location = new System.Drawing.Point(57, 31);
            this.chkMakePaymentCash.Name = "chkMakePaymentCash";
            this.chkMakePaymentCash.Size = new System.Drawing.Size(72, 24);
            this.chkMakePaymentCash.TabIndex = 1;
            this.chkMakePaymentCash.Text = "C&ash";
            this.chkMakePaymentCash.UseVisualStyleBackColor = true;
            this.chkMakePaymentCash.CheckedChanged += new System.EventHandler(this.chkMakePaymentCash_CheckedChanged);
            // 
            // btnMakePaymentConfirm
            // 
            this.btnMakePaymentConfirm.Location = new System.Drawing.Point(17, 435);
            this.btnMakePaymentConfirm.Name = "btnMakePaymentConfirm";
            this.btnMakePaymentConfirm.Size = new System.Drawing.Size(129, 46);
            this.btnMakePaymentConfirm.TabIndex = 5;
            this.btnMakePaymentConfirm.Text = "C&onfirm";
            this.btnMakePaymentConfirm.UseVisualStyleBackColor = true;
            this.btnMakePaymentConfirm.Click += new System.EventHandler(this.btnMakePaymentConfirm_Click);
            // 
            // lblMakePaymentVoucherNum
            // 
            this.lblMakePaymentVoucherNum.AutoSize = true;
            this.lblMakePaymentVoucherNum.Location = new System.Drawing.Point(6, 42);
            this.lblMakePaymentVoucherNum.Name = "lblMakePaymentVoucherNum";
            this.lblMakePaymentVoucherNum.Size = new System.Drawing.Size(172, 20);
            this.lblMakePaymentVoucherNum.TabIndex = 5;
            this.lblMakePaymentVoucherNum.Text = "Enter Voucher Number";
            // 
            // txtMakePaymentVoucherNum
            // 
            this.txtMakePaymentVoucherNum.Location = new System.Drawing.Point(185, 42);
            this.txtMakePaymentVoucherNum.Name = "txtMakePaymentVoucherNum";
            this.txtMakePaymentVoucherNum.Size = new System.Drawing.Size(109, 26);
            this.txtMakePaymentVoucherNum.TabIndex = 6;
            // 
            // grpMakePaymentVoucherNum
            // 
            this.grpMakePaymentVoucherNum.Controls.Add(this.txtMakePaymentVoucherAmount);
            this.grpMakePaymentVoucherNum.Controls.Add(this.llMakePaymentVoucherAmount);
            this.grpMakePaymentVoucherNum.Controls.Add(this.txtMakePaymentVoucherNum);
            this.grpMakePaymentVoucherNum.Controls.Add(this.lblMakePaymentVoucherNum);
            this.grpMakePaymentVoucherNum.Location = new System.Drawing.Point(386, 12);
            this.grpMakePaymentVoucherNum.Name = "grpMakePaymentVoucherNum";
            this.grpMakePaymentVoucherNum.Size = new System.Drawing.Size(300, 131);
            this.grpMakePaymentVoucherNum.TabIndex = 9;
            this.grpMakePaymentVoucherNum.TabStop = false;
            this.grpMakePaymentVoucherNum.Text = "Voucher Details";
            this.grpMakePaymentVoucherNum.Visible = false;
            // 
            // txtMakePaymentVoucherAmount
            // 
            this.txtMakePaymentVoucherAmount.Location = new System.Drawing.Point(181, 87);
            this.txtMakePaymentVoucherAmount.Name = "txtMakePaymentVoucherAmount";
            this.txtMakePaymentVoucherAmount.Size = new System.Drawing.Size(109, 26);
            this.txtMakePaymentVoucherAmount.TabIndex = 8;
            // 
            // llMakePaymentVoucherAmount
            // 
            this.llMakePaymentVoucherAmount.AutoSize = true;
            this.llMakePaymentVoucherAmount.Location = new System.Drawing.Point(6, 90);
            this.llMakePaymentVoucherAmount.Name = "llMakePaymentVoucherAmount";
            this.llMakePaymentVoucherAmount.Size = new System.Drawing.Size(69, 20);
            this.llMakePaymentVoucherAmount.TabIndex = 7;
            this.llMakePaymentVoucherAmount.Text = "Amount:";
            // 
            // grbCardDetails
            // 
            this.grbCardDetails.Controls.Add(this.txtMakePaymentCardAmount);
            this.grbCardDetails.Controls.Add(this.txtMakePaymentExpiryDate);
            this.grbCardDetails.Controls.Add(this.txtMakePaymentCardType);
            this.grbCardDetails.Controls.Add(this.txtMakePaymentCardName);
            this.grbCardDetails.Controls.Add(this.txtMakePaymentCardNumber);
            this.grbCardDetails.Controls.Add(this.txtMakePaymentCvv);
            this.grbCardDetails.Controls.Add(this.lblMakePaymentAmount);
            this.grbCardDetails.Controls.Add(this.lblMakePaymentCvv);
            this.grbCardDetails.Controls.Add(this.lblMakePaymentExpiryDate);
            this.grbCardDetails.Controls.Add(this.lblMakePaymentCardName);
            this.grbCardDetails.Controls.Add(this.lblMakePaymentCardNumber);
            this.grbCardDetails.Controls.Add(this.lblMakePaymentCardType);
            this.grbCardDetails.Location = new System.Drawing.Point(17, 149);
            this.grbCardDetails.Name = "grbCardDetails";
            this.grbCardDetails.Size = new System.Drawing.Size(669, 170);
            this.grbCardDetails.TabIndex = 10;
            this.grbCardDetails.TabStop = false;
            this.grbCardDetails.Text = "Card Details";
            this.grbCardDetails.Visible = false;
            this.grbCardDetails.Enter += new System.EventHandler(this.grbCardDetails_Enter);
            // 
            // txtMakePaymentCardAmount
            // 
            this.txtMakePaymentCardAmount.Location = new System.Drawing.Point(471, 96);
            this.txtMakePaymentCardAmount.Name = "txtMakePaymentCardAmount";
            this.txtMakePaymentCardAmount.Size = new System.Drawing.Size(163, 26);
            this.txtMakePaymentCardAmount.TabIndex = 6;
            // 
            // txtMakePaymentExpiryDate
            // 
            this.txtMakePaymentExpiryDate.Location = new System.Drawing.Point(471, 30);
            this.txtMakePaymentExpiryDate.Name = "txtMakePaymentExpiryDate";
            this.txtMakePaymentExpiryDate.Size = new System.Drawing.Size(163, 26);
            this.txtMakePaymentExpiryDate.TabIndex = 4;
            // 
            // txtMakePaymentCardType
            // 
            this.txtMakePaymentCardType.Location = new System.Drawing.Point(139, 28);
            this.txtMakePaymentCardType.Name = "txtMakePaymentCardType";
            this.txtMakePaymentCardType.Size = new System.Drawing.Size(163, 26);
            this.txtMakePaymentCardType.TabIndex = 1;
            // 
            // txtMakePaymentCardName
            // 
            this.txtMakePaymentCardName.Location = new System.Drawing.Point(139, 61);
            this.txtMakePaymentCardName.Name = "txtMakePaymentCardName";
            this.txtMakePaymentCardName.Size = new System.Drawing.Size(163, 26);
            this.txtMakePaymentCardName.TabIndex = 2;
            // 
            // txtMakePaymentCardNumber
            // 
            this.txtMakePaymentCardNumber.Location = new System.Drawing.Point(139, 96);
            this.txtMakePaymentCardNumber.Name = "txtMakePaymentCardNumber";
            this.txtMakePaymentCardNumber.Size = new System.Drawing.Size(163, 26);
            this.txtMakePaymentCardNumber.TabIndex = 3;
            // 
            // txtMakePaymentCvv
            // 
            this.txtMakePaymentCvv.Location = new System.Drawing.Point(471, 64);
            this.txtMakePaymentCvv.Name = "txtMakePaymentCvv";
            this.txtMakePaymentCvv.Size = new System.Drawing.Size(163, 26);
            this.txtMakePaymentCvv.TabIndex = 5;
            // 
            // lblMakePaymentAmount
            // 
            this.lblMakePaymentAmount.AutoSize = true;
            this.lblMakePaymentAmount.Location = new System.Drawing.Point(349, 99);
            this.lblMakePaymentAmount.Name = "lblMakePaymentAmount";
            this.lblMakePaymentAmount.Size = new System.Drawing.Size(69, 20);
            this.lblMakePaymentAmount.TabIndex = 11;
            this.lblMakePaymentAmount.Text = "Amount:";
            // 
            // lblMakePaymentCvv
            // 
            this.lblMakePaymentCvv.AutoSize = true;
            this.lblMakePaymentCvv.Location = new System.Drawing.Point(349, 65);
            this.lblMakePaymentCvv.Name = "lblMakePaymentCvv";
            this.lblMakePaymentCvv.Size = new System.Drawing.Size(38, 20);
            this.lblMakePaymentCvv.TabIndex = 10;
            this.lblMakePaymentCvv.Text = "Cvv:";
            // 
            // lblMakePaymentExpiryDate
            // 
            this.lblMakePaymentExpiryDate.AutoSize = true;
            this.lblMakePaymentExpiryDate.Location = new System.Drawing.Point(349, 31);
            this.lblMakePaymentExpiryDate.Name = "lblMakePaymentExpiryDate";
            this.lblMakePaymentExpiryDate.Size = new System.Drawing.Size(94, 20);
            this.lblMakePaymentExpiryDate.TabIndex = 9;
            this.lblMakePaymentExpiryDate.Text = "Expiry Date:";
            // 
            // lblMakePaymentCardName
            // 
            this.lblMakePaymentCardName.AutoSize = true;
            this.lblMakePaymentCardName.Location = new System.Drawing.Point(27, 65);
            this.lblMakePaymentCardName.Name = "lblMakePaymentCardName";
            this.lblMakePaymentCardName.Size = new System.Drawing.Size(93, 20);
            this.lblMakePaymentCardName.TabIndex = 7;
            this.lblMakePaymentCardName.Text = "Card Name:";
            // 
            // lblMakePaymentCardNumber
            // 
            this.lblMakePaymentCardNumber.AutoSize = true;
            this.lblMakePaymentCardNumber.Location = new System.Drawing.Point(27, 99);
            this.lblMakePaymentCardNumber.Name = "lblMakePaymentCardNumber";
            this.lblMakePaymentCardNumber.Size = new System.Drawing.Size(107, 20);
            this.lblMakePaymentCardNumber.TabIndex = 6;
            this.lblMakePaymentCardNumber.Text = "Card Number:";
            // 
            // lblMakePaymentCardType
            // 
            this.lblMakePaymentCardType.AutoSize = true;
            this.lblMakePaymentCardType.Location = new System.Drawing.Point(27, 31);
            this.lblMakePaymentCardType.Name = "lblMakePaymentCardType";
            this.lblMakePaymentCardType.Size = new System.Drawing.Size(89, 20);
            this.lblMakePaymentCardType.TabIndex = 5;
            this.lblMakePaymentCardType.Text = "Card Type: ";
            // 
            // grbMakePaymentCash
            // 
            this.grbMakePaymentCash.Controls.Add(this.txtMakePaymentCashAmount);
            this.grbMakePaymentCash.Controls.Add(this.lblMakePaymentCashAmount);
            this.grbMakePaymentCash.Location = new System.Drawing.Point(365, 344);
            this.grbMakePaymentCash.Name = "grbMakePaymentCash";
            this.grbMakePaymentCash.Size = new System.Drawing.Size(311, 67);
            this.grbMakePaymentCash.TabIndex = 11;
            this.grbMakePaymentCash.TabStop = false;
            this.grbMakePaymentCash.Text = "Cash";
            this.grbMakePaymentCash.Visible = false;
            this.grbMakePaymentCash.Enter += new System.EventHandler(this.grbMakePaymentCash_Enter);
            // 
            // txtMakePaymentCashAmount
            // 
            this.txtMakePaymentCashAmount.Location = new System.Drawing.Point(134, 25);
            this.txtMakePaymentCashAmount.Name = "txtMakePaymentCashAmount";
            this.txtMakePaymentCashAmount.Size = new System.Drawing.Size(141, 26);
            this.txtMakePaymentCashAmount.TabIndex = 1;
            // 
            // lblMakePaymentCashAmount
            // 
            this.lblMakePaymentCashAmount.AutoSize = true;
            this.lblMakePaymentCashAmount.Location = new System.Drawing.Point(18, 31);
            this.lblMakePaymentCashAmount.Name = "lblMakePaymentCashAmount";
            this.lblMakePaymentCashAmount.Size = new System.Drawing.Size(69, 20);
            this.lblMakePaymentCashAmount.TabIndex = 11;
            this.lblMakePaymentCashAmount.Text = "Amount:";
            // 
            // grbMakePaymentRoomDetails
            // 
            this.grbMakePaymentRoomDetails.Controls.Add(this.txtMakePaymentName);
            this.grbMakePaymentRoomDetails.Controls.Add(this.lblMakePaymentName);
            this.grbMakePaymentRoomDetails.Controls.Add(this.txtMakePaymentRoomNumber);
            this.grbMakePaymentRoomDetails.Controls.Add(this.lblMakePaymentRoomNumber);
            this.grbMakePaymentRoomDetails.Location = new System.Drawing.Point(17, 325);
            this.grbMakePaymentRoomDetails.Name = "grbMakePaymentRoomDetails";
            this.grbMakePaymentRoomDetails.Size = new System.Drawing.Size(311, 101);
            this.grbMakePaymentRoomDetails.TabIndex = 19;
            this.grbMakePaymentRoomDetails.TabStop = false;
            this.grbMakePaymentRoomDetails.Text = "Room Details";
            this.grbMakePaymentRoomDetails.Visible = false;
            // 
            // txtMakePaymentName
            // 
            this.txtMakePaymentName.Location = new System.Drawing.Point(134, 63);
            this.txtMakePaymentName.Name = "txtMakePaymentName";
            this.txtMakePaymentName.Size = new System.Drawing.Size(141, 26);
            this.txtMakePaymentName.TabIndex = 2;
            // 
            // lblMakePaymentName
            // 
            this.lblMakePaymentName.AutoSize = true;
            this.lblMakePaymentName.Location = new System.Drawing.Point(15, 66);
            this.lblMakePaymentName.Name = "lblMakePaymentName";
            this.lblMakePaymentName.Size = new System.Drawing.Size(80, 20);
            this.lblMakePaymentName.TabIndex = 19;
            this.lblMakePaymentName.Text = "FullName:";
            // 
            // txtMakePaymentRoomNumber
            // 
            this.txtMakePaymentRoomNumber.Location = new System.Drawing.Point(134, 25);
            this.txtMakePaymentRoomNumber.Name = "txtMakePaymentRoomNumber";
            this.txtMakePaymentRoomNumber.Size = new System.Drawing.Size(141, 26);
            this.txtMakePaymentRoomNumber.TabIndex = 1;
            // 
            // lblMakePaymentRoomNumber
            // 
            this.lblMakePaymentRoomNumber.AutoSize = true;
            this.lblMakePaymentRoomNumber.Location = new System.Drawing.Point(18, 31);
            this.lblMakePaymentRoomNumber.Name = "lblMakePaymentRoomNumber";
            this.lblMakePaymentRoomNumber.Size = new System.Drawing.Size(114, 20);
            this.lblMakePaymentRoomNumber.TabIndex = 11;
            this.lblMakePaymentRoomNumber.Text = "Room number:";
            // 
            // formMakePayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 493);
            this.Controls.Add(this.grbMakePaymentRoomDetails);
            this.Controls.Add(this.grbMakePaymentCash);
            this.Controls.Add(this.grbCardDetails);
            this.Controls.Add(this.btnMakePaymentConfirm);
            this.Controls.Add(this.btnMakePaymentClose);
            this.Controls.Add(this.grpMakePayment);
            this.Controls.Add(this.grpMakePaymentVoucherNum);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formMakePayment";
            this.Text = "Payment Form";
            this.grpMakePayment.ResumeLayout(false);
            this.grpMakePayment.PerformLayout();
            this.grpMakePaymentVoucherNum.ResumeLayout(false);
            this.grpMakePaymentVoucherNum.PerformLayout();
            this.grbCardDetails.ResumeLayout(false);
            this.grbCardDetails.PerformLayout();
            this.grbMakePaymentCash.ResumeLayout(false);
            this.grbMakePaymentCash.PerformLayout();
            this.grbMakePaymentRoomDetails.ResumeLayout(false);
            this.grbMakePaymentRoomDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMakePaymentClose;
        private System.Windows.Forms.GroupBox grpMakePayment;
        private System.Windows.Forms.CheckBox chkMakePaymentAddToRoom;
        private System.Windows.Forms.CheckBox chkMakePaymentNewCard;
        private System.Windows.Forms.CheckBox chkMakePaymentCash;
        private System.Windows.Forms.Button btnMakePaymentConfirm;
        private System.Windows.Forms.CheckBox chkMakePaymentVoucher;
        private System.Windows.Forms.Label lblMakePaymentVoucherNum;
        private System.Windows.Forms.TextBox txtMakePaymentVoucherNum;
        private System.Windows.Forms.GroupBox grpMakePaymentVoucherNum;
        private GroupBox grbCardDetails;
        private TextBox txtMakePaymentCardAmount;
        private TextBox txtMakePaymentExpiryDate;
        private TextBox txtMakePaymentCardType;
        private TextBox txtMakePaymentCardName;
        private TextBox txtMakePaymentCardNumber;
        private TextBox txtMakePaymentCvv;
        private Label lblMakePaymentAmount;
        private Label lblMakePaymentCvv;
        private Label lblMakePaymentExpiryDate;
        private Label lblMakePaymentCardName;
        private Label lblMakePaymentCardNumber;
        private Label lblMakePaymentCardType;
        private GroupBox grbMakePaymentCash;
        private TextBox txtMakePaymentCashAmount;
        private Label lblMakePaymentCashAmount;
        private GroupBox grbMakePaymentRoomDetails;
        private TextBox txtMakePaymentName;
        private Label lblMakePaymentName;
        private TextBox txtMakePaymentRoomNumber;
        private Label lblMakePaymentRoomNumber;
        private TextBox txtMakePaymentVoucherAmount;
        private Label llMakePaymentVoucherAmount;
    }
}