namespace ProductTracking
{
    partial class formAddPerson
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
            this.lblAddPersonTitle = new System.Windows.Forms.Label();
            this.lblAddPersonFName = new System.Windows.Forms.Label();
            this.lblAddPersonLName = new System.Windows.Forms.Label();
            this.lblAddPersonPhoneNo = new System.Windows.Forms.Label();
            this.lblAddPersonEmail = new System.Windows.Forms.Label();
            this.txtAddPersonFName = new System.Windows.Forms.TextBox();
            this.txtAddPersonLName = new System.Windows.Forms.TextBox();
            this.txtAddPersonPhoneNo = new System.Windows.Forms.TextBox();
            this.txtAddPersonEmail = new System.Windows.Forms.TextBox();
            this.btnAddPersonConfirm = new System.Windows.Forms.Button();
            this.btnAddPersonCancel = new System.Windows.Forms.Button();
            this.btnAddPersonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAddPersonTitle
            // 
            this.lblAddPersonTitle.AutoSize = true;
            this.lblAddPersonTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddPersonTitle.Location = new System.Drawing.Point(91, 48);
            this.lblAddPersonTitle.Name = "lblAddPersonTitle";
            this.lblAddPersonTitle.Size = new System.Drawing.Size(172, 38);
            this.lblAddPersonTitle.TabIndex = 0;
            this.lblAddPersonTitle.Text = "Add Guest";
            // 
            // lblAddPersonFName
            // 
            this.lblAddPersonFName.AutoSize = true;
            this.lblAddPersonFName.Location = new System.Drawing.Point(52, 166);
            this.lblAddPersonFName.Name = "lblAddPersonFName";
            this.lblAddPersonFName.Size = new System.Drawing.Size(90, 20);
            this.lblAddPersonFName.TabIndex = 1;
            this.lblAddPersonFName.Text = "First Name:";
            // 
            // lblAddPersonLName
            // 
            this.lblAddPersonLName.AutoSize = true;
            this.lblAddPersonLName.Location = new System.Drawing.Point(52, 204);
            this.lblAddPersonLName.Name = "lblAddPersonLName";
            this.lblAddPersonLName.Size = new System.Drawing.Size(90, 20);
            this.lblAddPersonLName.TabIndex = 2;
            this.lblAddPersonLName.Text = "Last Name:";
            // 
            // lblAddPersonPhoneNo
            // 
            this.lblAddPersonPhoneNo.AutoSize = true;
            this.lblAddPersonPhoneNo.Location = new System.Drawing.Point(52, 241);
            this.lblAddPersonPhoneNo.Name = "lblAddPersonPhoneNo";
            this.lblAddPersonPhoneNo.Size = new System.Drawing.Size(119, 20);
            this.lblAddPersonPhoneNo.TabIndex = 3;
            this.lblAddPersonPhoneNo.Text = "Phone Number:";
            // 
            // lblAddPersonEmail
            // 
            this.lblAddPersonEmail.AutoSize = true;
            this.lblAddPersonEmail.Location = new System.Drawing.Point(52, 280);
            this.lblAddPersonEmail.Name = "lblAddPersonEmail";
            this.lblAddPersonEmail.Size = new System.Drawing.Size(56, 20);
            this.lblAddPersonEmail.TabIndex = 4;
            this.lblAddPersonEmail.Text = "Email: ";
            // 
            // txtAddPersonFName
            // 
            this.txtAddPersonFName.Location = new System.Drawing.Point(161, 162);
            this.txtAddPersonFName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAddPersonFName.Name = "txtAddPersonFName";
            this.txtAddPersonFName.Size = new System.Drawing.Size(112, 26);
            this.txtAddPersonFName.TabIndex = 1;
            // 
            // txtAddPersonLName
            // 
            this.txtAddPersonLName.Location = new System.Drawing.Point(161, 204);
            this.txtAddPersonLName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAddPersonLName.Name = "txtAddPersonLName";
            this.txtAddPersonLName.Size = new System.Drawing.Size(112, 26);
            this.txtAddPersonLName.TabIndex = 2;
            // 
            // txtAddPersonPhoneNo
            // 
            this.txtAddPersonPhoneNo.Location = new System.Drawing.Point(171, 241);
            this.txtAddPersonPhoneNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAddPersonPhoneNo.Name = "txtAddPersonPhoneNo";
            this.txtAddPersonPhoneNo.Size = new System.Drawing.Size(112, 26);
            this.txtAddPersonPhoneNo.TabIndex = 3;
            // 
            // txtAddPersonEmail
            // 
            this.txtAddPersonEmail.Location = new System.Drawing.Point(171, 280);
            this.txtAddPersonEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAddPersonEmail.Name = "txtAddPersonEmail";
            this.txtAddPersonEmail.Size = new System.Drawing.Size(112, 26);
            this.txtAddPersonEmail.TabIndex = 4;
            // 
            // btnAddPersonConfirm
            // 
            this.btnAddPersonConfirm.Location = new System.Drawing.Point(52, 358);
            this.btnAddPersonConfirm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddPersonConfirm.Name = "btnAddPersonConfirm";
            this.btnAddPersonConfirm.Size = new System.Drawing.Size(84, 29);
            this.btnAddPersonConfirm.TabIndex = 5;
            this.btnAddPersonConfirm.Text = "Confirm";
            this.btnAddPersonConfirm.UseVisualStyleBackColor = true;
            this.btnAddPersonConfirm.Click += new System.EventHandler(this.btnAddPersonConfirm_Click);
            // 
            // btnAddPersonCancel
            // 
            this.btnAddPersonCancel.Location = new System.Drawing.Point(143, 358);
            this.btnAddPersonCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddPersonCancel.Name = "btnAddPersonCancel";
            this.btnAddPersonCancel.Size = new System.Drawing.Size(84, 29);
            this.btnAddPersonCancel.TabIndex = 6;
            this.btnAddPersonCancel.Text = "Cancel";
            this.btnAddPersonCancel.UseVisualStyleBackColor = true;
            this.btnAddPersonCancel.Click += new System.EventHandler(this.btnAddPersonCancel_Click);
            // 
            // btnAddPersonClose
            // 
            this.btnAddPersonClose.Location = new System.Drawing.Point(302, 440);
            this.btnAddPersonClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddPersonClose.Name = "btnAddPersonClose";
            this.btnAddPersonClose.Size = new System.Drawing.Size(84, 29);
            this.btnAddPersonClose.TabIndex = 7;
            this.btnAddPersonClose.Text = "Close";
            this.btnAddPersonClose.UseVisualStyleBackColor = true;
            this.btnAddPersonClose.Click += new System.EventHandler(this.btnAddPersonClose_Click);
            // 
            // formAddPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 484);
            this.Controls.Add(this.btnAddPersonClose);
            this.Controls.Add(this.btnAddPersonCancel);
            this.Controls.Add(this.btnAddPersonConfirm);
            this.Controls.Add(this.txtAddPersonEmail);
            this.Controls.Add(this.txtAddPersonPhoneNo);
            this.Controls.Add(this.txtAddPersonLName);
            this.Controls.Add(this.txtAddPersonFName);
            this.Controls.Add(this.lblAddPersonEmail);
            this.Controls.Add(this.lblAddPersonPhoneNo);
            this.Controls.Add(this.lblAddPersonLName);
            this.Controls.Add(this.lblAddPersonFName);
            this.Controls.Add(this.lblAddPersonTitle);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "formAddPerson";
            this.Text = "Guest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddPersonTitle;
        private System.Windows.Forms.Label lblAddPersonFName;
        private System.Windows.Forms.Label lblAddPersonLName;
        private System.Windows.Forms.Label lblAddPersonPhoneNo;
        private System.Windows.Forms.Label lblAddPersonEmail;
        private System.Windows.Forms.TextBox txtAddPersonFName;
        private System.Windows.Forms.TextBox txtAddPersonLName;
        private System.Windows.Forms.TextBox txtAddPersonPhoneNo;
        private System.Windows.Forms.TextBox txtAddPersonEmail;
        private System.Windows.Forms.Button btnAddPersonConfirm;
        private System.Windows.Forms.Button btnAddPersonCancel;
        private System.Windows.Forms.Button btnAddPersonClose;
    }
}