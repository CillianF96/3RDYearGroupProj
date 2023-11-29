namespace ProductTracking
{
    partial class PrintVoucher
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrintVoucher));
            this.btnPrintVoucherClose = new System.Windows.Forms.Button();
            this.BtnPrintVoucher = new System.Windows.Forms.Button();
            this.dgvPrintVoucher = new System.Windows.Forms.DataGridView();
            this.voucherIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.messageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voucherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearchReservation = new System.Windows.Forms.Button();
            this.lblPrintVoucherName = new System.Windows.Forms.Label();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.lblPrintVoucher = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrintVoucher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voucherBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPrintVoucherClose
            // 
            this.btnPrintVoucherClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintVoucherClose.Location = new System.Drawing.Point(705, 489);
            this.btnPrintVoucherClose.Name = "btnPrintVoucherClose";
            this.btnPrintVoucherClose.Size = new System.Drawing.Size(159, 57);
            this.btnPrintVoucherClose.TabIndex = 16;
            this.btnPrintVoucherClose.Text = "Close";
            this.btnPrintVoucherClose.UseVisualStyleBackColor = true;
            this.btnPrintVoucherClose.Click += new System.EventHandler(this.btnPrintVoucherClose_Click);
            // 
            // BtnPrintVoucher
            // 
            this.BtnPrintVoucher.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPrintVoucher.Location = new System.Drawing.Point(364, 489);
            this.BtnPrintVoucher.Name = "BtnPrintVoucher";
            this.BtnPrintVoucher.Size = new System.Drawing.Size(159, 57);
            this.BtnPrintVoucher.TabIndex = 15;
            this.BtnPrintVoucher.Text = "Print Voucher";
            this.BtnPrintVoucher.UseVisualStyleBackColor = true;
            this.BtnPrintVoucher.Click += new System.EventHandler(this.BtnPrintVoucher_Click);
            // 
            // dgvPrintVoucher
            // 
            this.dgvPrintVoucher.AutoGenerateColumns = false;
            this.dgvPrintVoucher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrintVoucher.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.voucherIDDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.messageDataGridViewTextBoxColumn});
            this.dgvPrintVoucher.DataSource = this.voucherBindingSource;
            this.dgvPrintVoucher.Location = new System.Drawing.Point(57, 263);
            this.dgvPrintVoucher.Name = "dgvPrintVoucher";
            this.dgvPrintVoucher.RowHeadersWidth = 62;
            this.dgvPrintVoucher.RowTemplate.Height = 28;
            this.dgvPrintVoucher.Size = new System.Drawing.Size(806, 192);
            this.dgvPrintVoucher.TabIndex = 14;
            // 
            // voucherIDDataGridViewTextBoxColumn
            // 
            this.voucherIDDataGridViewTextBoxColumn.DataPropertyName = "VoucherID";
            this.voucherIDDataGridViewTextBoxColumn.HeaderText = "VoucherID";
            this.voucherIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.voucherIDDataGridViewTextBoxColumn.Name = "voucherIDDataGridViewTextBoxColumn";
            this.voucherIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.Width = 150;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 150;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.Width = 150;
            // 
            // messageDataGridViewTextBoxColumn
            // 
            this.messageDataGridViewTextBoxColumn.DataPropertyName = "Message";
            this.messageDataGridViewTextBoxColumn.HeaderText = "Message";
            this.messageDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.messageDataGridViewTextBoxColumn.Name = "messageDataGridViewTextBoxColumn";
            this.messageDataGridViewTextBoxColumn.Width = 150;
            // 
            // voucherBindingSource
            // 
            this.voucherBindingSource.DataSource = typeof(BusinessEntities.Voucher);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearchReservation);
            this.groupBox1.Controls.Add(this.lblPrintVoucherName);
            this.groupBox1.Controls.Add(this.txtBoxName);
            this.groupBox1.Controls.Add(this.lblPrintVoucher);
            this.groupBox1.Location = new System.Drawing.Point(192, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(526, 229);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // btnSearchReservation
            // 
            this.btnSearchReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchReservation.Location = new System.Drawing.Point(174, 166);
            this.btnSearchReservation.Name = "btnSearchReservation";
            this.btnSearchReservation.Size = new System.Drawing.Size(159, 42);
            this.btnSearchReservation.TabIndex = 5;
            this.btnSearchReservation.Text = "Search";
            this.btnSearchReservation.UseVisualStyleBackColor = true;
            this.btnSearchReservation.Click += new System.EventHandler(this.btnSearchReservation_Click);
            // 
            // lblPrintVoucherName
            // 
            this.lblPrintVoucherName.AutoSize = true;
            this.lblPrintVoucherName.Location = new System.Drawing.Point(128, 111);
            this.lblPrintVoucherName.Name = "lblPrintVoucherName";
            this.lblPrintVoucherName.Size = new System.Drawing.Size(51, 20);
            this.lblPrintVoucherName.TabIndex = 3;
            this.lblPrintVoucherName.Text = "Name";
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(244, 103);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(172, 26);
            this.txtBoxName.TabIndex = 1;
            // 
            // lblPrintVoucher
            // 
            this.lblPrintVoucher.AutoSize = true;
            this.lblPrintVoucher.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrintVoucher.Location = new System.Drawing.Point(123, 22);
            this.lblPrintVoucher.Name = "lblPrintVoucher";
            this.lblPrintVoucher.Size = new System.Drawing.Size(276, 46);
            this.lblPrintVoucher.TabIndex = 0;
            this.lblPrintVoucher.Text = "Print Voucher";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // PrintVoucher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 591);
            this.Controls.Add(this.btnPrintVoucherClose);
            this.Controls.Add(this.BtnPrintVoucher);
            this.Controls.Add(this.dgvPrintVoucher);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PrintVoucher";
            this.Load += new System.EventHandler(this.PrintVoucher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrintVoucher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voucherBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnPrintVoucherClose;
        private System.Windows.Forms.Button BtnPrintVoucher;
        private System.Windows.Forms.DataGridView dgvPrintVoucher;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearchReservation;
        private System.Windows.Forms.Label lblPrintVoucherName;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.Label lblPrintVoucher;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn voucherIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn messageDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource voucherBindingSource;
    }
}