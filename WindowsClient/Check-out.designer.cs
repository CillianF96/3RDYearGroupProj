namespace GitITDone_Forms
{
    partial class Check_out
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Check_out));
            this.BtnCheckOut = new System.Windows.Forms.Button();
            this.BtnMakePayment = new System.Windows.Forms.Button();
            this.txtBoxAmountDue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPrintReceipt = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnCheckOut
            // 
            this.BtnCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCheckOut.Location = new System.Drawing.Point(468, 205);
            this.BtnCheckOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnCheckOut.Name = "BtnCheckOut";
            this.BtnCheckOut.Size = new System.Drawing.Size(202, 55);
            this.BtnCheckOut.TabIndex = 7;
            this.BtnCheckOut.Text = "Check out";
            this.BtnCheckOut.UseVisualStyleBackColor = true;
            this.BtnCheckOut.Click += new System.EventHandler(this.BtnCheckIn_Click);
            // 
            // BtnMakePayment
            // 
            this.BtnMakePayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMakePayment.Location = new System.Drawing.Point(468, 25);
            this.BtnMakePayment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnMakePayment.Name = "BtnMakePayment";
            this.BtnMakePayment.Size = new System.Drawing.Size(202, 74);
            this.BtnMakePayment.TabIndex = 8;
            this.BtnMakePayment.Text = "Make Payment";
            this.BtnMakePayment.UseVisualStyleBackColor = true;
            this.BtnMakePayment.Click += new System.EventHandler(this.BtnMakePayment_Click);
            // 
            // txtBoxAmountDue
            // 
            this.txtBoxAmountDue.Location = new System.Drawing.Point(330, 95);
            this.txtBoxAmountDue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxAmountDue.Name = "txtBoxAmountDue";
            this.txtBoxAmountDue.ReadOnly = true;
            this.txtBoxAmountDue.Size = new System.Drawing.Size(100, 26);
            this.txtBoxAmountDue.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(172, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 26);
            this.label1.TabIndex = 10;
            this.label1.Text = "Amount Due";
            // 
            // btnPrintReceipt
            // 
            this.btnPrintReceipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintReceipt.Location = new System.Drawing.Point(468, 122);
            this.btnPrintReceipt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrintReceipt.Name = "btnPrintReceipt";
            this.btnPrintReceipt.Size = new System.Drawing.Size(202, 55);
            this.btnPrintReceipt.TabIndex = 11;
            this.btnPrintReceipt.Text = "Print Receipt";
            this.btnPrintReceipt.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(468, 294);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(202, 55);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Check_out
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 375);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnPrintReceipt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxAmountDue);
            this.Controls.Add(this.BtnMakePayment);
            this.Controls.Add(this.BtnCheckOut);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Check_out";
            this.Text = "Check-Out";
            this.Load += new System.EventHandler(this.Check_out_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCheckOut;
        private System.Windows.Forms.Button BtnMakePayment;
        private System.Windows.Forms.TextBox txtBoxAmountDue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPrintReceipt;
        private System.Windows.Forms.Button btnClose;
    }
}