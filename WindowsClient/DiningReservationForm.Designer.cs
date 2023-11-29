using System.Drawing;
using System.Windows.Forms;

namespace GitItDone
{
    partial class DiningReservationForm
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
            this.lblDiningReservationFormTitle = new System.Windows.Forms.Label();
            this.lblDiningReservationFormDateTime = new System.Windows.Forms.Label();
            this.lblDiningReservationFormTableSize = new System.Windows.Forms.Label();
            this.lblDiningReservationFormLocation = new System.Windows.Forms.Label();
            this.lblDiningReservationFormTableNum = new System.Windows.Forms.Label();
            this.lblDiningReservationFormReq = new System.Windows.Forms.Label();
            this.txtDiningReservationFormTableNum = new System.Windows.Forms.TextBox();
            this.numericUpDownDiningReservationFormTableSize = new System.Windows.Forms.NumericUpDown();
            this.RtbDiningReservationFormReq = new System.Windows.Forms.RichTextBox();
            this.cmbDiningReservationFormLocation = new System.Windows.Forms.ComboBox();
            this.btnDiningReservationFormConfirm = new System.Windows.Forms.Button();
            this.btnDiningReservationFormCancel = new System.Windows.Forms.Button();
            this.lblDiningReservationFormPhoneNum = new System.Windows.Forms.Label();
            this.txtDiningReservationFormPhoneNum = new System.Windows.Forms.TextBox();
            this.lblDiningReservationFormCreditCard = new System.Windows.Forms.Label();
            this.txtDiningReservationFormCreditCrad = new System.Windows.Forms.TextBox();
            this.dtpDinningResvDateTime = new System.Windows.Forms.DateTimePicker();
            this.lblDiningResvLName = new System.Windows.Forms.Label();
            this.lblDiningResvFname = new System.Windows.Forms.Label();
            this.txtDiningResvLname = new System.Windows.Forms.TextBox();
            this.txtDiningResvFname = new System.Windows.Forms.TextBox();
            this.txtDiningResvEmail = new System.Windows.Forms.TextBox();
            this.lblDiningResvEmail = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDiningReservationFormTableSize)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDiningReservationFormTitle
            // 
            this.lblDiningReservationFormTitle.AutoSize = true;
            this.lblDiningReservationFormTitle.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold);
            this.lblDiningReservationFormTitle.Location = new System.Drawing.Point(158, 9);
            this.lblDiningReservationFormTitle.Name = "lblDiningReservationFormTitle";
            this.lblDiningReservationFormTitle.Size = new System.Drawing.Size(444, 50);
            this.lblDiningReservationFormTitle.TabIndex = 0;
            this.lblDiningReservationFormTitle.Text = "Dining Reservation Form";
            // 
            // lblDiningReservationFormDateTime
            // 
            this.lblDiningReservationFormDateTime.AutoSize = true;
            this.lblDiningReservationFormDateTime.Location = new System.Drawing.Point(42, 390);
            this.lblDiningReservationFormDateTime.Name = "lblDiningReservationFormDateTime";
            this.lblDiningReservationFormDateTime.Size = new System.Drawing.Size(113, 20);
            this.lblDiningReservationFormDateTime.TabIndex = 2;
            this.lblDiningReservationFormDateTime.Text = "Date and Time";
            // 
            // lblDiningReservationFormTableSize
            // 
            this.lblDiningReservationFormTableSize.AutoSize = true;
            this.lblDiningReservationFormTableSize.Location = new System.Drawing.Point(46, 358);
            this.lblDiningReservationFormTableSize.Name = "lblDiningReservationFormTableSize";
            this.lblDiningReservationFormTableSize.Size = new System.Drawing.Size(87, 20);
            this.lblDiningReservationFormTableSize.TabIndex = 3;
            this.lblDiningReservationFormTableSize.Text = "Table Size:";
            // 
            // lblDiningReservationFormLocation
            // 
            this.lblDiningReservationFormLocation.AutoSize = true;
            this.lblDiningReservationFormLocation.Location = new System.Drawing.Point(47, 324);
            this.lblDiningReservationFormLocation.Name = "lblDiningReservationFormLocation";
            this.lblDiningReservationFormLocation.Size = new System.Drawing.Size(70, 20);
            this.lblDiningReservationFormLocation.TabIndex = 4;
            this.lblDiningReservationFormLocation.Text = "Location";
            // 
            // lblDiningReservationFormTableNum
            // 
            this.lblDiningReservationFormTableNum.AutoSize = true;
            this.lblDiningReservationFormTableNum.Location = new System.Drawing.Point(47, 229);
            this.lblDiningReservationFormTableNum.Name = "lblDiningReservationFormTableNum";
            this.lblDiningReservationFormTableNum.Size = new System.Drawing.Size(112, 20);
            this.lblDiningReservationFormTableNum.TabIndex = 5;
            this.lblDiningReservationFormTableNum.Text = "Table Number:";
            // 
            // lblDiningReservationFormReq
            // 
            this.lblDiningReservationFormReq.AutoSize = true;
            this.lblDiningReservationFormReq.Location = new System.Drawing.Point(42, 419);
            this.lblDiningReservationFormReq.Name = "lblDiningReservationFormReq";
            this.lblDiningReservationFormReq.Size = new System.Drawing.Size(279, 20);
            this.lblDiningReservationFormReq.TabIndex = 6;
            this.lblDiningReservationFormReq.Text = "Special Requests (Dietry Preferences)";
            // 
            // txtDiningReservationFormTableNum
            // 
            this.txtDiningReservationFormTableNum.Location = new System.Drawing.Point(188, 226);
            this.txtDiningReservationFormTableNum.Name = "txtDiningReservationFormTableNum";
            this.txtDiningReservationFormTableNum.Size = new System.Drawing.Size(140, 26);
            this.txtDiningReservationFormTableNum.TabIndex = 14;
            // 
            // numericUpDownDiningReservationFormTableSize
            // 
            this.numericUpDownDiningReservationFormTableSize.Location = new System.Drawing.Point(158, 352);
            this.numericUpDownDiningReservationFormTableSize.Name = "numericUpDownDiningReservationFormTableSize";
            this.numericUpDownDiningReservationFormTableSize.Size = new System.Drawing.Size(70, 26);
            this.numericUpDownDiningReservationFormTableSize.TabIndex = 16;
            // 
            // RtbDiningReservationFormReq
            // 
            this.RtbDiningReservationFormReq.Location = new System.Drawing.Point(46, 442);
            this.RtbDiningReservationFormReq.Name = "RtbDiningReservationFormReq";
            this.RtbDiningReservationFormReq.Size = new System.Drawing.Size(277, 111);
            this.RtbDiningReservationFormReq.TabIndex = 17;
            this.RtbDiningReservationFormReq.Text = "";
            // 
            // cmbDiningReservationFormLocation
            // 
            this.cmbDiningReservationFormLocation.AutoCompleteCustomSource.AddRange(new string[] {
            "The Bird Cage",
            "Madmoiselle"});
            this.cmbDiningReservationFormLocation.FormattingEnabled = true;
            this.cmbDiningReservationFormLocation.Location = new System.Drawing.Point(159, 316);
            this.cmbDiningReservationFormLocation.Name = "cmbDiningReservationFormLocation";
            this.cmbDiningReservationFormLocation.Size = new System.Drawing.Size(169, 28);
            this.cmbDiningReservationFormLocation.TabIndex = 18;
            // 
            // btnDiningReservationFormConfirm
            // 
            this.btnDiningReservationFormConfirm.Location = new System.Drawing.Point(559, 524);
            this.btnDiningReservationFormConfirm.Name = "btnDiningReservationFormConfirm";
            this.btnDiningReservationFormConfirm.Size = new System.Drawing.Size(106, 29);
            this.btnDiningReservationFormConfirm.TabIndex = 19;
            this.btnDiningReservationFormConfirm.Text = "Confirm";
            this.btnDiningReservationFormConfirm.UseVisualStyleBackColor = true;
            // 
            // btnDiningReservationFormCancel
            // 
            this.btnDiningReservationFormCancel.Location = new System.Drawing.Point(370, 524);
            this.btnDiningReservationFormCancel.Name = "btnDiningReservationFormCancel";
            this.btnDiningReservationFormCancel.Size = new System.Drawing.Size(106, 29);
            this.btnDiningReservationFormCancel.TabIndex = 20;
            this.btnDiningReservationFormCancel.Text = "Cancel";
            this.btnDiningReservationFormCancel.UseVisualStyleBackColor = true;
            // 
            // lblDiningReservationFormPhoneNum
            // 
            this.lblDiningReservationFormPhoneNum.AutoSize = true;
            this.lblDiningReservationFormPhoneNum.Location = new System.Drawing.Point(47, 155);
            this.lblDiningReservationFormPhoneNum.Name = "lblDiningReservationFormPhoneNum";
            this.lblDiningReservationFormPhoneNum.Size = new System.Drawing.Size(123, 20);
            this.lblDiningReservationFormPhoneNum.TabIndex = 23;
            this.lblDiningReservationFormPhoneNum.Text = "Phone Number: ";
            // 
            // txtDiningReservationFormPhoneNum
            // 
            this.txtDiningReservationFormPhoneNum.Location = new System.Drawing.Point(188, 155);
            this.txtDiningReservationFormPhoneNum.Name = "txtDiningReservationFormPhoneNum";
            this.txtDiningReservationFormPhoneNum.Size = new System.Drawing.Size(140, 26);
            this.txtDiningReservationFormPhoneNum.TabIndex = 24;
            // 
            // lblDiningReservationFormCreditCard
            // 
            this.lblDiningReservationFormCreditCard.AutoSize = true;
            this.lblDiningReservationFormCreditCard.Location = new System.Drawing.Point(47, 280);
            this.lblDiningReservationFormCreditCard.Name = "lblDiningReservationFormCreditCard";
            this.lblDiningReservationFormCreditCard.Size = new System.Drawing.Size(93, 20);
            this.lblDiningReservationFormCreditCard.TabIndex = 25;
            this.lblDiningReservationFormCreditCard.Text = "Credit Card:";
            // 
            // txtDiningReservationFormCreditCrad
            // 
            this.txtDiningReservationFormCreditCrad.Location = new System.Drawing.Point(161, 277);
            this.txtDiningReservationFormCreditCrad.Name = "txtDiningReservationFormCreditCrad";
            this.txtDiningReservationFormCreditCrad.Size = new System.Drawing.Size(183, 26);
            this.txtDiningReservationFormCreditCrad.TabIndex = 26;
            // 
            // dtpDinningResvDateTime
            // 
            this.dtpDinningResvDateTime.Location = new System.Drawing.Point(161, 390);
            this.dtpDinningResvDateTime.Name = "dtpDinningResvDateTime";
            this.dtpDinningResvDateTime.Size = new System.Drawing.Size(200, 26);
            this.dtpDinningResvDateTime.TabIndex = 27;
            // 
            // lblDiningResvLName
            // 
            this.lblDiningResvLName.AutoSize = true;
            this.lblDiningResvLName.Location = new System.Drawing.Point(46, 123);
            this.lblDiningResvLName.Name = "lblDiningResvLName";
            this.lblDiningResvLName.Size = new System.Drawing.Size(86, 20);
            this.lblDiningResvLName.TabIndex = 28;
            this.lblDiningResvLName.Text = "Last Name";
            // 
            // lblDiningResvFname
            // 
            this.lblDiningResvFname.AutoSize = true;
            this.lblDiningResvFname.Location = new System.Drawing.Point(46, 91);
            this.lblDiningResvFname.Name = "lblDiningResvFname";
            this.lblDiningResvFname.Size = new System.Drawing.Size(86, 20);
            this.lblDiningResvFname.TabIndex = 29;
            this.lblDiningResvFname.Text = "First Name";
            // 
            // txtDiningResvLname
            // 
            this.txtDiningResvLname.Location = new System.Drawing.Point(188, 123);
            this.txtDiningResvLname.Name = "txtDiningResvLname";
            this.txtDiningResvLname.Size = new System.Drawing.Size(140, 26);
            this.txtDiningResvLname.TabIndex = 30;
            // 
            // txtDiningResvFname
            // 
            this.txtDiningResvFname.Location = new System.Drawing.Point(188, 91);
            this.txtDiningResvFname.Name = "txtDiningResvFname";
            this.txtDiningResvFname.Size = new System.Drawing.Size(140, 26);
            this.txtDiningResvFname.TabIndex = 31;
            // 
            // txtDiningResvEmail
            // 
            this.txtDiningResvEmail.Location = new System.Drawing.Point(188, 187);
            this.txtDiningResvEmail.Name = "txtDiningResvEmail";
            this.txtDiningResvEmail.Size = new System.Drawing.Size(140, 26);
            this.txtDiningResvEmail.TabIndex = 32;
            // 
            // lblDiningResvEmail
            // 
            this.lblDiningResvEmail.AutoSize = true;
            this.lblDiningResvEmail.Location = new System.Drawing.Point(47, 193);
            this.lblDiningResvEmail.Name = "lblDiningResvEmail";
            this.lblDiningResvEmail.Size = new System.Drawing.Size(52, 20);
            this.lblDiningResvEmail.TabIndex = 33;
            this.lblDiningResvEmail.Text = "Email:";
            // 
            // DiningReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 565);
            this.Controls.Add(this.lblDiningResvEmail);
            this.Controls.Add(this.txtDiningResvEmail);
            this.Controls.Add(this.txtDiningResvFname);
            this.Controls.Add(this.txtDiningResvLname);
            this.Controls.Add(this.lblDiningResvFname);
            this.Controls.Add(this.lblDiningResvLName);
            this.Controls.Add(this.dtpDinningResvDateTime);
            this.Controls.Add(this.txtDiningReservationFormCreditCrad);
            this.Controls.Add(this.lblDiningReservationFormCreditCard);
            this.Controls.Add(this.txtDiningReservationFormPhoneNum);
            this.Controls.Add(this.lblDiningReservationFormPhoneNum);
            this.Controls.Add(this.btnDiningReservationFormCancel);
            this.Controls.Add(this.btnDiningReservationFormConfirm);
            this.Controls.Add(this.cmbDiningReservationFormLocation);
            this.Controls.Add(this.RtbDiningReservationFormReq);
            this.Controls.Add(this.numericUpDownDiningReservationFormTableSize);
            this.Controls.Add(this.txtDiningReservationFormTableNum);
            this.Controls.Add(this.lblDiningReservationFormReq);
            this.Controls.Add(this.lblDiningReservationFormTableNum);
            this.Controls.Add(this.lblDiningReservationFormLocation);
            this.Controls.Add(this.lblDiningReservationFormTableSize);
            this.Controls.Add(this.lblDiningReservationFormDateTime);
            this.Controls.Add(this.lblDiningReservationFormTitle);
            this.Name = "DiningReservationForm";
            this.Text = "DiningReservationForm";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDiningReservationFormTableSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblDiningReservationFormTitle;
        private Label lblDiningReservationFormDateTime;
        private Label lblDiningReservationFormTableSize;
        private Label lblDiningReservationFormLocation;
        private Label lblDiningReservationFormTableNum;
        private Label lblDiningReservationFormReq;
        private TextBox txtDiningReservationFormTableNum;
        private NumericUpDown numericUpDownDiningReservationFormTableSize;
        private RichTextBox RtbDiningReservationFormReq;
        private ComboBox cmbDiningReservationFormLocation;
        private Button btnDiningReservationFormConfirm;
        private Button btnDiningReservationFormCancel;
        private Label lblDiningReservationFormPhoneNum;
        private TextBox txtDiningReservationFormPhoneNum;
        private Label lblDiningReservationFormCreditCard;
        private TextBox txtDiningReservationFormCreditCrad;
        private DateTimePicker dtpDinningResvDateTime;
        private Label lblDiningResvLName;
        private Label lblDiningResvFname;
        private TextBox txtDiningResvLname;
        private TextBox txtDiningResvFname;
        private TextBox txtDiningResvEmail;
        private Label lblDiningResvEmail;
    }
}