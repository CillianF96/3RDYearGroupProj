namespace ConsolatioWireFrames
{
    partial class formDiningMain
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
            this.rdoDiningMainBirdCage = new System.Windows.Forms.RadioButton();
            this.rdoDiningMainMadamoiselle = new System.Windows.Forms.RadioButton();
            this.tabControlDining = new System.Windows.Forms.TabControl();
            this.tabDinner = new System.Windows.Forms.TabPage();
            this.dgvDinner = new System.Windows.Forms.DataGridView();
            this.tabLunch = new System.Windows.Forms.TabPage();
            this.dgvLunch = new System.Windows.Forms.DataGridView();
            this.tabBreakfast = new System.Windows.Forms.TabPage();
            this.dgvBreakfast = new System.Windows.Forms.DataGridView();
            this.btnDiningMain = new System.Windows.Forms.Button();
            this.btnDiningMainAddResv = new System.Windows.Forms.Button();
            this.btnDiningMainClose = new System.Windows.Forms.Button();
            this.tabControlDining.SuspendLayout();
            this.tabDinner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDinner)).BeginInit();
            this.tabLunch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLunch)).BeginInit();
            this.tabBreakfast.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBreakfast)).BeginInit();
            this.SuspendLayout();
            // 
            // rdoDiningMainBirdCage
            // 
            this.rdoDiningMainBirdCage.AutoSize = true;
            this.rdoDiningMainBirdCage.Location = new System.Drawing.Point(108, 27);
            this.rdoDiningMainBirdCage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdoDiningMainBirdCage.Name = "rdoDiningMainBirdCage";
            this.rdoDiningMainBirdCage.Size = new System.Drawing.Size(93, 17);
            this.rdoDiningMainBirdCage.TabIndex = 0;
            this.rdoDiningMainBirdCage.TabStop = true;
            this.rdoDiningMainBirdCage.Text = "&The Bird Cage";
            this.rdoDiningMainBirdCage.UseVisualStyleBackColor = true;
            // 
            // rdoDiningMainMadamoiselle
            // 
            this.rdoDiningMainMadamoiselle.AutoSize = true;
            this.rdoDiningMainMadamoiselle.Location = new System.Drawing.Point(466, 27);
            this.rdoDiningMainMadamoiselle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdoDiningMainMadamoiselle.Name = "rdoDiningMainMadamoiselle";
            this.rdoDiningMainMadamoiselle.Size = new System.Drawing.Size(89, 17);
            this.rdoDiningMainMadamoiselle.TabIndex = 1;
            this.rdoDiningMainMadamoiselle.TabStop = true;
            this.rdoDiningMainMadamoiselle.Text = "&Madamoiselle";
            this.rdoDiningMainMadamoiselle.UseVisualStyleBackColor = true;
            // 
            // tabControlDining
            // 
            this.tabControlDining.Controls.Add(this.tabDinner);
            this.tabControlDining.Controls.Add(this.tabLunch);
            this.tabControlDining.Controls.Add(this.tabBreakfast);
            this.tabControlDining.Location = new System.Drawing.Point(23, 67);
            this.tabControlDining.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControlDining.Name = "tabControlDining";
            this.tabControlDining.SelectedIndex = 0;
            this.tabControlDining.Size = new System.Drawing.Size(679, 231);
            this.tabControlDining.TabIndex = 3;
            // 
            // tabDinner
            // 
            this.tabDinner.Controls.Add(this.dgvDinner);
            this.tabDinner.Location = new System.Drawing.Point(4, 22);
            this.tabDinner.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabDinner.Name = "tabDinner";
            this.tabDinner.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabDinner.Size = new System.Drawing.Size(671, 205);
            this.tabDinner.TabIndex = 0;
            this.tabDinner.Text = "Dinner";
            this.tabDinner.UseVisualStyleBackColor = true;
            // 
            // dgvDinner
            // 
            this.dgvDinner.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDinner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDinner.Location = new System.Drawing.Point(2, 2);
            this.dgvDinner.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvDinner.Name = "dgvDinner";
            this.dgvDinner.RowHeadersWidth = 62;
            this.dgvDinner.Size = new System.Drawing.Size(667, 201);
            this.dgvDinner.TabIndex = 3;
            // 
            // tabLunch
            // 
            this.tabLunch.Controls.Add(this.dgvLunch);
            this.tabLunch.Location = new System.Drawing.Point(4, 22);
            this.tabLunch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabLunch.Name = "tabLunch";
            this.tabLunch.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabLunch.Size = new System.Drawing.Size(671, 205);
            this.tabLunch.TabIndex = 1;
            this.tabLunch.Text = "Lunch";
            this.tabLunch.UseVisualStyleBackColor = true;
            // 
            // dgvLunch
            // 
            this.dgvLunch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLunch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLunch.Location = new System.Drawing.Point(2, 2);
            this.dgvLunch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvLunch.Name = "dgvLunch";
            this.dgvLunch.RowHeadersWidth = 62;
            this.dgvLunch.Size = new System.Drawing.Size(667, 201);
            this.dgvLunch.TabIndex = 3;
            // 
            // tabBreakfast
            // 
            this.tabBreakfast.Controls.Add(this.dgvBreakfast);
            this.tabBreakfast.Location = new System.Drawing.Point(4, 22);
            this.tabBreakfast.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabBreakfast.Name = "tabBreakfast";
            this.tabBreakfast.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabBreakfast.Size = new System.Drawing.Size(671, 205);
            this.tabBreakfast.TabIndex = 2;
            this.tabBreakfast.Text = "Breakfast";
            this.tabBreakfast.UseVisualStyleBackColor = true;
            // 
            // dgvBreakfast
            // 
            this.dgvBreakfast.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBreakfast.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBreakfast.Location = new System.Drawing.Point(2, 2);
            this.dgvBreakfast.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvBreakfast.Name = "dgvBreakfast";
            this.dgvBreakfast.RowHeadersWidth = 62;
            this.dgvBreakfast.Size = new System.Drawing.Size(667, 201);
            this.dgvBreakfast.TabIndex = 3;
            // 
            // btnDiningMain
            // 
            this.btnDiningMain.Location = new System.Drawing.Point(144, 309);
            this.btnDiningMain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDiningMain.Name = "btnDiningMain";
            this.btnDiningMain.Size = new System.Drawing.Size(72, 24);
            this.btnDiningMain.TabIndex = 4;
            this.btnDiningMain.Text = "&Show Menu";
            this.btnDiningMain.UseVisualStyleBackColor = true;
            // 
            // btnDiningMainAddResv
            // 
            this.btnDiningMainAddResv.Location = new System.Drawing.Point(28, 309);
            this.btnDiningMainAddResv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDiningMainAddResv.Name = "btnDiningMainAddResv";
            this.btnDiningMainAddResv.Size = new System.Drawing.Size(105, 24);
            this.btnDiningMainAddResv.TabIndex = 5;
            this.btnDiningMainAddResv.Text = "&Add Reservation";
            this.btnDiningMainAddResv.UseVisualStyleBackColor = true;
            // 
            // btnDiningMainClose
            // 
            this.btnDiningMainClose.Location = new System.Drawing.Point(625, 309);
            this.btnDiningMainClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDiningMainClose.Name = "btnDiningMainClose";
            this.btnDiningMainClose.Size = new System.Drawing.Size(72, 24);
            this.btnDiningMainClose.TabIndex = 6;
            this.btnDiningMainClose.Text = "&Close";
            this.btnDiningMainClose.UseVisualStyleBackColor = true;
            this.btnDiningMainClose.Click += new System.EventHandler(this.btnDiningMainClose_Click);
            // 
            // formDiningMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 359);
            this.Controls.Add(this.btnDiningMainClose);
            this.Controls.Add(this.btnDiningMainAddResv);
            this.Controls.Add(this.btnDiningMain);
            this.Controls.Add(this.tabControlDining);
            this.Controls.Add(this.rdoDiningMainMadamoiselle);
            this.Controls.Add(this.rdoDiningMainBirdCage);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "formDiningMain";
            this.Text = "formDiningMain";
            this.tabControlDining.ResumeLayout(false);
            this.tabDinner.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDinner)).EndInit();
            this.tabLunch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLunch)).EndInit();
            this.tabBreakfast.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBreakfast)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdoDiningMainBirdCage;
        private System.Windows.Forms.RadioButton rdoDiningMainMadamoiselle;
        private System.Windows.Forms.TabControl tabControlDining;
        private System.Windows.Forms.TabPage tabDinner;
        private System.Windows.Forms.DataGridView dgvDinner;
        private System.Windows.Forms.TabPage tabLunch;
        private System.Windows.Forms.DataGridView dgvLunch;
        private System.Windows.Forms.TabPage tabBreakfast;
        private System.Windows.Forms.DataGridView dgvBreakfast;
        private System.Windows.Forms.Button btnDiningMain;
        private System.Windows.Forms.Button btnDiningMainAddResv;
        private System.Windows.Forms.Button btnDiningMainClose;
    }
}