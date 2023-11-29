namespace ProductTracking
{
    partial class FormDataSelector
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
            this.btnBusiestDay = new System.Windows.Forms.Button();
            this.btnMonthlyData = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBusiestDay
            // 
            this.btnBusiestDay.Location = new System.Drawing.Point(299, 84);
            this.btnBusiestDay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBusiestDay.Name = "btnBusiestDay";
            this.btnBusiestDay.Size = new System.Drawing.Size(157, 125);
            this.btnBusiestDay.TabIndex = 0;
            this.btnBusiestDay.Text = "Show Busiest Day";
            this.btnBusiestDay.UseVisualStyleBackColor = true;
            this.btnBusiestDay.Click += new System.EventHandler(this.btnBusiestDay_Click);
            // 
            // btnMonthlyData
            // 
            this.btnMonthlyData.Location = new System.Drawing.Point(73, 84);
            this.btnMonthlyData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMonthlyData.Name = "btnMonthlyData";
            this.btnMonthlyData.Size = new System.Drawing.Size(152, 125);
            this.btnMonthlyData.TabIndex = 1;
            this.btnMonthlyData.Text = "Monthly Data";
            this.btnMonthlyData.UseVisualStyleBackColor = true;
            this.btnMonthlyData.Click += new System.EventHandler(this.btnMonthlyData_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(219, 235);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(82, 31);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FormDataSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnMonthlyData);
            this.Controls.Add(this.btnBusiestDay);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormDataSelector";
            this.Text = "FormDataSelector";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBusiestDay;
        private System.Windows.Forms.Button btnMonthlyData;
        private System.Windows.Forms.Button btnExit;
    }
}