using System.Drawing;
using System.Windows.Forms;

namespace ProductTracking
{
    partial class VoucherForm
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
            this.lblVoucherFormTitle = new System.Windows.Forms.Label();
            this.lblVoucherFormVoucherName = new System.Windows.Forms.Label();
            this.txtVoucherName = new System.Windows.Forms.TextBox();
            this.lblVoucherFormVoucherAmount = new System.Windows.Forms.Label();
            this.txtVoucherFormVoucherAmount = new System.Windows.Forms.TextBox();
            this.lblVoucherFormVoucherMessage = new System.Windows.Forms.Label();
            this.RtbVoucherFormVoucherMessage = new System.Windows.Forms.RichTextBox();
            this.lblVoucherFormVoucherType = new System.Windows.Forms.Label();
            this.cmbVoucherFormVoucherType = new System.Windows.Forms.ComboBox();
            this.btnVoucherFormGenerate = new System.Windows.Forms.Button();
            this.btnVoucherFormCancel = new System.Windows.Forms.Button();
            this.PcbVoucherForm = new System.Windows.Forms.PictureBox();
            this.btnVoucherPrint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PcbVoucherForm)).BeginInit();
            this.SuspendLayout();
            // 
            // lblVoucherFormTitle
            // 
            this.lblVoucherFormTitle.AutoSize = true;
            this.lblVoucherFormTitle.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold);
            this.lblVoucherFormTitle.Location = new System.Drawing.Point(118, 28);
            this.lblVoucherFormTitle.Name = "lblVoucherFormTitle";
            this.lblVoucherFormTitle.Size = new System.Drawing.Size(161, 50);
            this.lblVoucherFormTitle.TabIndex = 0;
            this.lblVoucherFormTitle.Text = "Voucher";
            // 
            // lblVoucherFormVoucherName
            // 
            this.lblVoucherFormVoucherName.AutoSize = true;
            this.lblVoucherFormVoucherName.Location = new System.Drawing.Point(60, 108);
            this.lblVoucherFormVoucherName.Name = "lblVoucherFormVoucherName";
            this.lblVoucherFormVoucherName.Size = new System.Drawing.Size(141, 20);
            this.lblVoucherFormVoucherName.TabIndex = 1;
            this.lblVoucherFormVoucherName.Text = "Name on Voucher:";
            // 
            // txtVoucherName
            // 
            this.txtVoucherName.Location = new System.Drawing.Point(240, 105);
            this.txtVoucherName.Name = "txtVoucherName";
            this.txtVoucherName.Size = new System.Drawing.Size(140, 26);
            this.txtVoucherName.TabIndex = 2;
            // 
            // lblVoucherFormVoucherAmount
            // 
            this.lblVoucherFormVoucherAmount.AutoSize = true;
            this.lblVoucherFormVoucherAmount.Location = new System.Drawing.Point(64, 211);
            this.lblVoucherFormVoucherAmount.Name = "lblVoucherFormVoucherAmount";
            this.lblVoucherFormVoucherAmount.Size = new System.Drawing.Size(137, 20);
            this.lblVoucherFormVoucherAmount.TabIndex = 3;
            this.lblVoucherFormVoucherAmount.Text = "Voucher Amount: ";
            // 
            // txtVoucherFormVoucherAmount
            // 
            this.txtVoucherFormVoucherAmount.Location = new System.Drawing.Point(240, 208);
            this.txtVoucherFormVoucherAmount.Name = "txtVoucherFormVoucherAmount";
            this.txtVoucherFormVoucherAmount.Size = new System.Drawing.Size(140, 26);
            this.txtVoucherFormVoucherAmount.TabIndex = 4;
            // 
            // lblVoucherFormVoucherMessage
            // 
            this.lblVoucherFormVoucherMessage.AutoSize = true;
            this.lblVoucherFormVoucherMessage.Location = new System.Drawing.Point(24, 292);
            this.lblVoucherFormVoucherMessage.Name = "lblVoucherFormVoucherMessage";
            this.lblVoucherFormVoucherMessage.Size = new System.Drawing.Size(177, 20);
            this.lblVoucherFormVoucherMessage.TabIndex = 7;
            this.lblVoucherFormVoucherMessage.Text = "Personalized Message: ";
            // 
            // RtbVoucherFormVoucherMessage
            // 
            this.RtbVoucherFormVoucherMessage.Location = new System.Drawing.Point(240, 289);
            this.RtbVoucherFormVoucherMessage.Name = "RtbVoucherFormVoucherMessage";
            this.RtbVoucherFormVoucherMessage.Size = new System.Drawing.Size(250, 119);
            this.RtbVoucherFormVoucherMessage.TabIndex = 8;
            this.RtbVoucherFormVoucherMessage.Text = "";
            // 
            // lblVoucherFormVoucherType
            // 
            this.lblVoucherFormVoucherType.AutoSize = true;
            this.lblVoucherFormVoucherType.Location = new System.Drawing.Point(93, 155);
            this.lblVoucherFormVoucherType.Name = "lblVoucherFormVoucherType";
            this.lblVoucherFormVoucherType.Size = new System.Drawing.Size(111, 20);
            this.lblVoucherFormVoucherType.TabIndex = 10;
            this.lblVoucherFormVoucherType.Text = "Voucher Type:";
            // 
            // cmbVoucherFormVoucherType
            // 
            this.cmbVoucherFormVoucherType.AutoCompleteCustomSource.AddRange(new string[] {
            "Hotel Stay",
            "Hotel Dining ",
            "Hotel Spa",
            "Hotel Experience"});
            this.cmbVoucherFormVoucherType.FormattingEnabled = true;
            this.cmbVoucherFormVoucherType.Items.AddRange(new object[] {
            "Hotel",
            "Spa",
            "Dining"});
            this.cmbVoucherFormVoucherType.Location = new System.Drawing.Point(240, 152);
            this.cmbVoucherFormVoucherType.Name = "cmbVoucherFormVoucherType";
            this.cmbVoucherFormVoucherType.Size = new System.Drawing.Size(169, 28);
            this.cmbVoucherFormVoucherType.TabIndex = 11;
            // 
            // btnVoucherFormGenerate
            // 
            this.btnVoucherFormGenerate.Location = new System.Drawing.Point(320, 449);
            this.btnVoucherFormGenerate.Name = "btnVoucherFormGenerate";
            this.btnVoucherFormGenerate.Size = new System.Drawing.Size(171, 29);
            this.btnVoucherFormGenerate.TabIndex = 12;
            this.btnVoucherFormGenerate.Text = "Generate Voucher";
            this.btnVoucherFormGenerate.UseVisualStyleBackColor = true;
            this.btnVoucherFormGenerate.Click += new System.EventHandler(this.btnVoucherFormGenerate_Click);
            // 
            // btnVoucherFormCancel
            // 
            this.btnVoucherFormCancel.Location = new System.Drawing.Point(100, 449);
            this.btnVoucherFormCancel.Name = "btnVoucherFormCancel";
            this.btnVoucherFormCancel.Size = new System.Drawing.Size(105, 29);
            this.btnVoucherFormCancel.TabIndex = 13;
            this.btnVoucherFormCancel.Text = "Cancel";
            this.btnVoucherFormCancel.UseVisualStyleBackColor = true;
            this.btnVoucherFormCancel.Click += new System.EventHandler(this.btnVoucherFormCancel_Click);
            // 
            // PcbVoucherForm
            // 
            this.PcbVoucherForm.Image = global::ProductTracking.Properties.Resources.Consolatio;
            this.PcbVoucherForm.Location = new System.Drawing.Point(484, 28);
            this.PcbVoucherForm.Name = "PcbVoucherForm";
            this.PcbVoucherForm.Size = new System.Drawing.Size(198, 203);
            this.PcbVoucherForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcbVoucherForm.TabIndex = 9;
            this.PcbVoucherForm.TabStop = false;
            // 
            // btnVoucherPrint
            // 
            this.btnVoucherPrint.Location = new System.Drawing.Point(213, 514);
            this.btnVoucherPrint.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVoucherPrint.Name = "btnVoucherPrint";
            this.btnVoucherPrint.Size = new System.Drawing.Size(170, 35);
            this.btnVoucherPrint.TabIndex = 14;
            this.btnVoucherPrint.Text = "Print Voucher";
            this.btnVoucherPrint.UseVisualStyleBackColor = true;
            this.btnVoucherPrint.Click += new System.EventHandler(this.btnVoucherPrint_Click);
            // 
            // VoucherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 623);
            this.Controls.Add(this.btnVoucherPrint);
            this.Controls.Add(this.btnVoucherFormCancel);
            this.Controls.Add(this.btnVoucherFormGenerate);
            this.Controls.Add(this.cmbVoucherFormVoucherType);
            this.Controls.Add(this.lblVoucherFormVoucherType);
            this.Controls.Add(this.PcbVoucherForm);
            this.Controls.Add(this.RtbVoucherFormVoucherMessage);
            this.Controls.Add(this.lblVoucherFormVoucherMessage);
            this.Controls.Add(this.txtVoucherFormVoucherAmount);
            this.Controls.Add(this.lblVoucherFormVoucherAmount);
            this.Controls.Add(this.txtVoucherName);
            this.Controls.Add(this.lblVoucherFormVoucherName);
            this.Controls.Add(this.lblVoucherFormTitle);
            this.Name = "VoucherForm";
            this.Text = "VoucherForm";
            ((System.ComponentModel.ISupportInitialize)(this.PcbVoucherForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblVoucherFormTitle;
        private Label lblVoucherFormVoucherName;
        private TextBox txtVoucherName;
        private Label lblVoucherFormVoucherAmount;
        private TextBox txtVoucherFormVoucherAmount;
        private Label lblVoucherFormVoucherMessage;
        private RichTextBox RtbVoucherFormVoucherMessage;
        private PictureBox PcbVoucherForm;
        private Label lblVoucherFormVoucherType;
        private ComboBox cmbVoucherFormVoucherType;
        private Button btnVoucherFormGenerate;
        private Button btnVoucherFormCancel;
        private Button btnVoucherPrint;
    }
}