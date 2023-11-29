namespace ProductTracking
{
    partial class formOperator
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
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonAllocatePreparedProduct = new System.Windows.Forms.Button();
            this.buttonViewOrderDetails = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExit.Location = new System.Drawing.Point(399, 440);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 48);
            this.buttonExit.TabIndex = 0;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonAllocatePreparedProduct
            // 
            this.buttonAllocatePreparedProduct.Location = new System.Drawing.Point(94, 101);
            this.buttonAllocatePreparedProduct.Name = "buttonAllocatePreparedProduct";
            this.buttonAllocatePreparedProduct.Size = new System.Drawing.Size(111, 80);
            this.buttonAllocatePreparedProduct.TabIndex = 1;
            this.buttonAllocatePreparedProduct.Text = "Allocate Prepared Product";
            this.buttonAllocatePreparedProduct.UseVisualStyleBackColor = true;
            this.buttonAllocatePreparedProduct.Click += new System.EventHandler(this.buttonAllocatePreparedProduct_Click);
            // 
            // buttonViewOrderDetails
            // 
            this.buttonViewOrderDetails.Location = new System.Drawing.Point(94, 204);
            this.buttonViewOrderDetails.Name = "buttonViewOrderDetails";
            this.buttonViewOrderDetails.Size = new System.Drawing.Size(111, 74);
            this.buttonViewOrderDetails.TabIndex = 2;
            this.buttonViewOrderDetails.Text = "View Order Details ";
            this.buttonViewOrderDetails.UseVisualStyleBackColor = true;
            this.buttonViewOrderDetails.Click += new System.EventHandler(this.buttonViewOrderDetails_Click);
            // 
            // formOperator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProductTracking.Properties.Resources.Blue_hills4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.ControlBox = false;
            this.Controls.Add(this.buttonViewOrderDetails);
            this.Controls.Add(this.buttonAllocatePreparedProduct);
            this.Controls.Add(this.buttonExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formOperator";
            this.Text = "formOperator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonAllocatePreparedProduct;
        private System.Windows.Forms.Button buttonViewOrderDetails;
    }
}