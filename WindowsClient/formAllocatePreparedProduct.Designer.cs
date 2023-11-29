using System.Windows.Forms;
namespace ProductTracking
{
    public partial class formAllocatePreparedProduct : Form
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
            this.textBoxProductCode = new System.Windows.Forms.TextBox();
            this.buttonFind = new System.Windows.Forms.Button();
            this.listViewProductLines = new System.Windows.Forms.ListView();
            this.buttonBack = new System.Windows.Forms.Button();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.buttonAddProduct = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxProductCode
            // 
            this.textBoxProductCode.Location = new System.Drawing.Point(42, 21);
            this.textBoxProductCode.Name = "textBoxProductCode";
            this.textBoxProductCode.Size = new System.Drawing.Size(100, 20);
            this.textBoxProductCode.TabIndex = 0;
            this.textBoxProductCode.TextChanged += new System.EventHandler(this.textBoxProductCode_TextChanged);
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(198, 21);
            this.buttonFind.Name = "Find";
            this.buttonFind.Size = new System.Drawing.Size(175, 23);
            this.buttonFind.TabIndex = 1;
            this.buttonFind.Text = "Enter a ProductCode to find";
            this.buttonFind.UseMnemonic = false;
            this.buttonFind.UseVisualStyleBackColor = false;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // listViewProductLines
            // 
            this.listViewProductLines.Location = new System.Drawing.Point(42, 63);
            this.listViewProductLines.Name = "listViewProductLines";
            this.listViewProductLines.Size = new System.Drawing.Size(339, 186);
            this.listViewProductLines.TabIndex = 2;
            this.listViewProductLines.UseCompatibleStateImageBehavior = false;
            this.listViewProductLines.View = System.Windows.Forms.View.Details;
            this.listViewProductLines.SelectedIndexChanged += new System.EventHandler(this.listViewProductLines_SelectedIndexChanged);
             // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(390, 371);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 44);
            this.buttonBack.TabIndex = 3;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Location = new System.Drawing.Point(42, 287);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(100, 20);
            this.textBoxAmount.TabIndex = 4;
            this.textBoxAmount.TextChanged += new System.EventHandler(this.textBoxAmount_TextChanged);
            // 
            // buttonAddProduct
            // 
            this.buttonAddProduct.Location = new System.Drawing.Point(197, 287);
            this.buttonAddProduct.Name = "buttonAddProduct";
            this.buttonAddProduct.Size = new System.Drawing.Size(75, 23);
            this.buttonAddProduct.TabIndex = 5;
            this.buttonAddProduct.Text = "Add Product";
            this.buttonAddProduct.UseVisualStyleBackColor = true;
            this.buttonAddProduct.Click += new System.EventHandler(this.buttonAddProduct_Click);
            // 
            // formAllocatePreparedProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProductTracking.Properties.Resources.Blue_hills4;
            this.ClientSize = new System.Drawing.Size(492, 456);
            this.Controls.Add(this.buttonAddProduct);
            this.Controls.Add(this.textBoxAmount);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.listViewProductLines);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.textBoxProductCode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formAllocatePreparedProduct";
            this.Text = "formAllocatePreparedProduct";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxProductCode;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.ListView listViewProductLines;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.Button buttonAddProduct;
    }
}