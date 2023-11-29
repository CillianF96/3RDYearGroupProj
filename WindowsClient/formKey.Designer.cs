namespace ProductTracking
{
    partial class formKey
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formKey));
            this.btnKeySend = new System.Windows.Forms.Button();
            this.pcbKeyCode = new System.Windows.Forms.PictureBox();
            this.printDocumentKey = new System.Drawing.Printing.PrintDocument();
            this.printPreviewKey = new System.Windows.Forms.PrintPreviewDialog();
            this.btnKeyClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcbKeyCode)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKeySend
            // 
            this.btnKeySend.Location = new System.Drawing.Point(170, 357);
            this.btnKeySend.Name = "btnKeySend";
            this.btnKeySend.Size = new System.Drawing.Size(194, 42);
            this.btnKeySend.TabIndex = 3;
            this.btnKeySend.Text = "&Send Key";
            this.btnKeySend.UseVisualStyleBackColor = true;
            this.btnKeySend.Click += new System.EventHandler(this.btnKeySend_Click);
            // 
            // pcbKeyCode
            // 
            this.pcbKeyCode.Location = new System.Drawing.Point(110, 35);
            this.pcbKeyCode.Name = "pcbKeyCode";
            this.pcbKeyCode.Size = new System.Drawing.Size(314, 279);
            this.pcbKeyCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbKeyCode.TabIndex = 4;
            this.pcbKeyCode.TabStop = false;
            // 
            // printDocumentKey
            // 
            this.printDocumentKey.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocumentKey_PrintPage);
            // 
            // printPreviewKey
            // 
            this.printPreviewKey.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewKey.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewKey.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewKey.Document = this.printDocumentKey;
            this.printPreviewKey.Enabled = true;
            this.printPreviewKey.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewKey.Icon")));
            this.printPreviewKey.Name = "printPreviewKey";
            this.printPreviewKey.Visible = false;
            // 
            // btnKeyClose
            // 
            this.btnKeyClose.Location = new System.Drawing.Point(437, 405);
            this.btnKeyClose.Name = "btnKeyClose";
            this.btnKeyClose.Size = new System.Drawing.Size(110, 42);
            this.btnKeyClose.TabIndex = 5;
            this.btnKeyClose.Text = "&Close";
            this.btnKeyClose.UseVisualStyleBackColor = true;
            this.btnKeyClose.Click += new System.EventHandler(this.btnKeyClose_Click);
            // 
            // formKey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 450);
            this.Controls.Add(this.btnKeyClose);
            this.Controls.Add(this.pcbKeyCode);
            this.Controls.Add(this.btnKeySend);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formKey";
            ((System.ComponentModel.ISupportInitialize)(this.pcbKeyCode)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnKeySend;
        private System.Windows.Forms.PictureBox pcbKeyCode;
        private System.Drawing.Printing.PrintDocument printDocumentKey;
        private System.Windows.Forms.PrintPreviewDialog printPreviewKey;
        private System.Windows.Forms.Button btnKeyClose;
    }
}