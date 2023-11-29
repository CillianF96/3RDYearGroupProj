namespace GitITDone_Forms
{
    partial class StaffMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffMain));
            this.dgvStaffMain = new System.Windows.Forms.DataGridView();
            this.roomReservationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnStaffMenu = new System.Windows.Forms.Button();
            this.btnStaffReceipt = new System.Windows.Forms.Button();
            this.btnStaffVoucher = new System.Windows.Forms.Button();
            this.btnStaffSearch = new System.Windows.Forms.Button();
            this.btnStaffCheckin = new System.Windows.Forms.Button();
            this.btnStaffCheckout = new System.Windows.Forms.Button();
            this.btnStaffStay = new System.Windows.Forms.Button();
            this.btnStaffSpa = new System.Windows.Forms.Button();
            this.btnStaffRestaurant = new System.Windows.Forms.Button();
            this.btnStaffLogout = new System.Windows.Forms.Button();
            this.btnStaffGenerateRoomKey = new System.Windows.Forms.Button();
            this.btnStaffMakePayment = new System.Windows.Forms.Button();
            this.txtStaffMainSearch = new System.Windows.Forms.TextBox();
            this.btnStaffMng = new System.Windows.Forms.Button();
            this.btnStaffMainRefresh = new System.Windows.Forms.Button();
            this.pcbStaffMainLogo = new System.Windows.Forms.PictureBox();
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomReservationIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colResName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkOutDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creditCardNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkedInDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.isLateCheckoutDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.keyReturnedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Eamil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaffMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomReservationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbStaffMainLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStaffMain
            // 
            this.dgvStaffMain.AllowUserToAddRows = false;
            this.dgvStaffMain.AllowUserToDeleteRows = false;
            this.dgvStaffMain.AutoGenerateColumns = false;
            this.dgvStaffMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStaffMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.roomReservationIDDataGridViewTextBoxColumn,
            this.bookingNumberDataGridViewTextBoxColumn,
            this.colResName,
            this.checkOutDateDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn,
            this.creditCardNumberDataGridViewTextBoxColumn,
            this.billDataGridViewTextBoxColumn,
            this.checkedInDataGridViewCheckBoxColumn,
            this.isLateCheckoutDataGridViewCheckBoxColumn,
            this.keyReturnedDataGridViewCheckBoxColumn,
            this.Eamil});
            this.dgvStaffMain.DataSource = this.roomReservationBindingSource;
            this.dgvStaffMain.Location = new System.Drawing.Point(39, 14);
            this.dgvStaffMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvStaffMain.Name = "dgvStaffMain";
            this.dgvStaffMain.ReadOnly = true;
            this.dgvStaffMain.RowHeadersWidth = 62;
            this.dgvStaffMain.Size = new System.Drawing.Size(817, 374);
            this.dgvStaffMain.TabIndex = 0;
            this.dgvStaffMain.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // roomReservationBindingSource
            // 
            this.roomReservationBindingSource.DataSource = typeof(BusinessEntities.RoomReservation);
            // 
            // btnStaffMenu
            // 
            this.btnStaffMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaffMenu.Location = new System.Drawing.Point(505, 543);
            this.btnStaffMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStaffMenu.Name = "btnStaffMenu";
            this.btnStaffMenu.Size = new System.Drawing.Size(161, 60);
            this.btnStaffMenu.TabIndex = 11;
            this.btnStaffMenu.Text = "&Food Menu";
            this.btnStaffMenu.UseVisualStyleBackColor = true;
            this.btnStaffMenu.Click += new System.EventHandler(this.btnStaffMenu_Click);
            // 
            // btnStaffReceipt
            // 
            this.btnStaffReceipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaffReceipt.Location = new System.Drawing.Point(182, 473);
            this.btnStaffReceipt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStaffReceipt.Name = "btnStaffReceipt";
            this.btnStaffReceipt.Size = new System.Drawing.Size(149, 60);
            this.btnStaffReceipt.TabIndex = 7;
            this.btnStaffReceipt.Text = "&Print receipt";
            this.btnStaffReceipt.UseVisualStyleBackColor = true;
            this.btnStaffReceipt.Click += new System.EventHandler(this.btnStaffReceipt_Click);
            // 
            // btnStaffVoucher
            // 
            this.btnStaffVoucher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaffVoucher.Location = new System.Drawing.Point(182, 543);
            this.btnStaffVoucher.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStaffVoucher.Name = "btnStaffVoucher";
            this.btnStaffVoucher.Size = new System.Drawing.Size(149, 60);
            this.btnStaffVoucher.TabIndex = 8;
            this.btnStaffVoucher.Text = "Create &Voucher";
            this.btnStaffVoucher.UseVisualStyleBackColor = true;
            this.btnStaffVoucher.Click += new System.EventHandler(this.btnStaffVoucher_Click);
            // 
            // btnStaffSearch
            // 
            this.btnStaffSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaffSearch.Location = new System.Drawing.Point(512, 407);
            this.btnStaffSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStaffSearch.Name = "btnStaffSearch";
            this.btnStaffSearch.Size = new System.Drawing.Size(173, 29);
            this.btnStaffSearch.TabIndex = 2;
            this.btnStaffSearch.Text = "&Search Reservation";
            this.btnStaffSearch.UseVisualStyleBackColor = true;
            this.btnStaffSearch.Click += new System.EventHandler(this.btnStaffSearch_Click);
            // 
            // btnStaffCheckin
            // 
            this.btnStaffCheckin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaffCheckin.Location = new System.Drawing.Point(13, 473);
            this.btnStaffCheckin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStaffCheckin.Name = "btnStaffCheckin";
            this.btnStaffCheckin.Size = new System.Drawing.Size(149, 60);
            this.btnStaffCheckin.TabIndex = 6;
            this.btnStaffCheckin.Text = "&Check-in";
            this.btnStaffCheckin.UseVisualStyleBackColor = true;
            this.btnStaffCheckin.Click += new System.EventHandler(this.btnStaffCheckin_Click);
            // 
            // btnStaffCheckout
            // 
            this.btnStaffCheckout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaffCheckout.Location = new System.Drawing.Point(13, 543);
            this.btnStaffCheckout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStaffCheckout.Name = "btnStaffCheckout";
            this.btnStaffCheckout.Size = new System.Drawing.Size(149, 60);
            this.btnStaffCheckout.TabIndex = 6;
            this.btnStaffCheckout.Text = "C&heck-out";
            this.btnStaffCheckout.UseVisualStyleBackColor = true;
            this.btnStaffCheckout.Click += new System.EventHandler(this.btnStaffCheckout_Click);
            // 
            // btnStaffStay
            // 
            this.btnStaffStay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaffStay.Location = new System.Drawing.Point(933, 253);
            this.btnStaffStay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStaffStay.Name = "btnStaffStay";
            this.btnStaffStay.Size = new System.Drawing.Size(220, 54);
            this.btnStaffStay.TabIndex = 3;
            this.btnStaffStay.Text = "S&TAY";
            this.btnStaffStay.UseVisualStyleBackColor = true;
            this.btnStaffStay.Click += new System.EventHandler(this.btnStaffStay_Click);
            // 
            // btnStaffSpa
            // 
            this.btnStaffSpa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaffSpa.Location = new System.Drawing.Point(933, 317);
            this.btnStaffSpa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStaffSpa.Name = "btnStaffSpa";
            this.btnStaffSpa.Size = new System.Drawing.Size(220, 51);
            this.btnStaffSpa.TabIndex = 4;
            this.btnStaffSpa.Text = "S&PA";
            this.btnStaffSpa.UseVisualStyleBackColor = true;
            this.btnStaffSpa.Click += new System.EventHandler(this.btnStaffSpa_Click);
            // 
            // btnStaffRestaurant
            // 
            this.btnStaffRestaurant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaffRestaurant.Location = new System.Drawing.Point(933, 378);
            this.btnStaffRestaurant.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStaffRestaurant.Name = "btnStaffRestaurant";
            this.btnStaffRestaurant.Size = new System.Drawing.Size(220, 51);
            this.btnStaffRestaurant.TabIndex = 5;
            this.btnStaffRestaurant.Text = "&DINING";
            this.btnStaffRestaurant.UseVisualStyleBackColor = true;
            this.btnStaffRestaurant.Click += new System.EventHandler(this.btnStaffRestaurant_Click);
            // 
            // btnStaffLogout
            // 
            this.btnStaffLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaffLogout.Location = new System.Drawing.Point(960, 543);
            this.btnStaffLogout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStaffLogout.Name = "btnStaffLogout";
            this.btnStaffLogout.Size = new System.Drawing.Size(193, 67);
            this.btnStaffLogout.TabIndex = 11;
            this.btnStaffLogout.Text = "&Log out";
            this.btnStaffLogout.UseVisualStyleBackColor = true;
            this.btnStaffLogout.Click += new System.EventHandler(this.btnStaffLogout_Click);
            // 
            // btnStaffGenerateRoomKey
            // 
            this.btnStaffGenerateRoomKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaffGenerateRoomKey.Location = new System.Drawing.Point(348, 473);
            this.btnStaffGenerateRoomKey.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStaffGenerateRoomKey.Name = "btnStaffGenerateRoomKey";
            this.btnStaffGenerateRoomKey.Size = new System.Drawing.Size(149, 60);
            this.btnStaffGenerateRoomKey.TabIndex = 9;
            this.btnStaffGenerateRoomKey.Text = "&Generate Room Key";
            this.btnStaffGenerateRoomKey.UseVisualStyleBackColor = true;
            this.btnStaffGenerateRoomKey.Click += new System.EventHandler(this.btnStaffGenerateRoomKey_Click);
            // 
            // btnStaffMakePayment
            // 
            this.btnStaffMakePayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaffMakePayment.Location = new System.Drawing.Point(348, 543);
            this.btnStaffMakePayment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStaffMakePayment.Name = "btnStaffMakePayment";
            this.btnStaffMakePayment.Size = new System.Drawing.Size(149, 60);
            this.btnStaffMakePayment.TabIndex = 10;
            this.btnStaffMakePayment.Text = "&Make Payment";
            this.btnStaffMakePayment.UseVisualStyleBackColor = true;
            this.btnStaffMakePayment.Click += new System.EventHandler(this.btnStaffMakePayment_Click);
            // 
            // txtStaffMainSearch
            // 
            this.txtStaffMainSearch.Location = new System.Drawing.Point(292, 407);
            this.txtStaffMainSearch.Multiline = true;
            this.txtStaffMainSearch.Name = "txtStaffMainSearch";
            this.txtStaffMainSearch.Size = new System.Drawing.Size(213, 29);
            this.txtStaffMainSearch.TabIndex = 1;
            // 
            // btnStaffMng
            // 
            this.btnStaffMng.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaffMng.Location = new System.Drawing.Point(1004, 441);
            this.btnStaffMng.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStaffMng.Name = "btnStaffMng";
            this.btnStaffMng.Size = new System.Drawing.Size(149, 92);
            this.btnStaffMng.TabIndex = 12;
            this.btnStaffMng.Text = "St&aff Management";
            this.btnStaffMng.UseVisualStyleBackColor = true;
            this.btnStaffMng.Click += new System.EventHandler(this.btnStaffMng_Click);
            // 
            // btnStaffMainRefresh
            // 
            this.btnStaffMainRefresh.Location = new System.Drawing.Point(39, 403);
            this.btnStaffMainRefresh.Name = "btnStaffMainRefresh";
            this.btnStaffMainRefresh.Size = new System.Drawing.Size(75, 33);
            this.btnStaffMainRefresh.TabIndex = 13;
            this.btnStaffMainRefresh.Text = "Refresh";
            this.btnStaffMainRefresh.UseVisualStyleBackColor = true;
            this.btnStaffMainRefresh.Click += new System.EventHandler(this.btnStaffMainRefresh_Click);
            // 
            // pcbStaffMainLogo
            // 
            this.pcbStaffMainLogo.Image = global::ProductTracking.Properties.Resources.Consolatio;
            this.pcbStaffMainLogo.Location = new System.Drawing.Point(894, 14);
            this.pcbStaffMainLogo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pcbStaffMainLogo.Name = "pcbStaffMainLogo";
            this.pcbStaffMainLogo.Size = new System.Drawing.Size(259, 229);
            this.pcbStaffMainLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbStaffMainLogo.TabIndex = 7;
            this.pcbStaffMainLogo.TabStop = false;
            // 
            // roomReservationIDDataGridViewTextBoxColumn
            // 
            this.roomReservationIDDataGridViewTextBoxColumn.DataPropertyName = "RoomReservationID";
            this.roomReservationIDDataGridViewTextBoxColumn.HeaderText = "Reservation ID";
            this.roomReservationIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.roomReservationIDDataGridViewTextBoxColumn.Name = "roomReservationIDDataGridViewTextBoxColumn";
            this.roomReservationIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.roomReservationIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // bookingNumberDataGridViewTextBoxColumn
            // 
            this.bookingNumberDataGridViewTextBoxColumn.DataPropertyName = "BookingNumber";
            this.bookingNumberDataGridViewTextBoxColumn.HeaderText = "Booking Number";
            this.bookingNumberDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.bookingNumberDataGridViewTextBoxColumn.Name = "bookingNumberDataGridViewTextBoxColumn";
            this.bookingNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.bookingNumberDataGridViewTextBoxColumn.Width = 150;
            // 
            // colResName
            // 
            this.colResName.HeaderText = "Reservation Name";
            this.colResName.MinimumWidth = 8;
            this.colResName.Name = "colResName";
            this.colResName.ReadOnly = true;
            this.colResName.Width = 150;
            // 
            // checkOutDateDataGridViewTextBoxColumn
            // 
            this.checkOutDateDataGridViewTextBoxColumn.DataPropertyName = "CheckOutDate";
            this.checkOutDateDataGridViewTextBoxColumn.HeaderText = "Check Out Date";
            this.checkOutDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.checkOutDateDataGridViewTextBoxColumn.Name = "checkOutDateDataGridViewTextBoxColumn";
            this.checkOutDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.checkOutDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateDataGridViewTextBoxColumn.Width = 150;
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "Time";
            this.timeDataGridViewTextBoxColumn.HeaderText = "Time";
            this.timeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            this.timeDataGridViewTextBoxColumn.ReadOnly = true;
            this.timeDataGridViewTextBoxColumn.Width = 150;
            // 
            // creditCardNumberDataGridViewTextBoxColumn
            // 
            this.creditCardNumberDataGridViewTextBoxColumn.DataPropertyName = "CreditCardNumber";
            this.creditCardNumberDataGridViewTextBoxColumn.HeaderText = "Credit Card Number";
            this.creditCardNumberDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.creditCardNumberDataGridViewTextBoxColumn.Name = "creditCardNumberDataGridViewTextBoxColumn";
            this.creditCardNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.creditCardNumberDataGridViewTextBoxColumn.Width = 150;
            // 
            // billDataGridViewTextBoxColumn
            // 
            this.billDataGridViewTextBoxColumn.DataPropertyName = "Bill";
            this.billDataGridViewTextBoxColumn.HeaderText = "Bill";
            this.billDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.billDataGridViewTextBoxColumn.Name = "billDataGridViewTextBoxColumn";
            this.billDataGridViewTextBoxColumn.ReadOnly = true;
            this.billDataGridViewTextBoxColumn.Width = 150;
            // 
            // checkedInDataGridViewCheckBoxColumn
            // 
            this.checkedInDataGridViewCheckBoxColumn.DataPropertyName = "CheckedIn";
            this.checkedInDataGridViewCheckBoxColumn.HeaderText = "Checked In";
            this.checkedInDataGridViewCheckBoxColumn.MinimumWidth = 8;
            this.checkedInDataGridViewCheckBoxColumn.Name = "checkedInDataGridViewCheckBoxColumn";
            this.checkedInDataGridViewCheckBoxColumn.ReadOnly = true;
            this.checkedInDataGridViewCheckBoxColumn.Width = 150;
            // 
            // isLateCheckoutDataGridViewCheckBoxColumn
            // 
            this.isLateCheckoutDataGridViewCheckBoxColumn.DataPropertyName = "IsLateCheckout";
            this.isLateCheckoutDataGridViewCheckBoxColumn.HeaderText = "Late Checkout";
            this.isLateCheckoutDataGridViewCheckBoxColumn.MinimumWidth = 8;
            this.isLateCheckoutDataGridViewCheckBoxColumn.Name = "isLateCheckoutDataGridViewCheckBoxColumn";
            this.isLateCheckoutDataGridViewCheckBoxColumn.ReadOnly = true;
            this.isLateCheckoutDataGridViewCheckBoxColumn.Width = 150;
            // 
            // keyReturnedDataGridViewCheckBoxColumn
            // 
            this.keyReturnedDataGridViewCheckBoxColumn.DataPropertyName = "KeyReturned";
            this.keyReturnedDataGridViewCheckBoxColumn.HeaderText = "Key Returned";
            this.keyReturnedDataGridViewCheckBoxColumn.MinimumWidth = 8;
            this.keyReturnedDataGridViewCheckBoxColumn.Name = "keyReturnedDataGridViewCheckBoxColumn";
            this.keyReturnedDataGridViewCheckBoxColumn.ReadOnly = true;
            this.keyReturnedDataGridViewCheckBoxColumn.Width = 150;
            // 
            // Eamil
            // 
            this.Eamil.DataPropertyName = "Email";
            this.Eamil.HeaderText = "Email";
            this.Eamil.MinimumWidth = 8;
            this.Eamil.Name = "Eamil";
            this.Eamil.ReadOnly = true;
            this.Eamil.Width = 150;
            // 
            // StaffMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1191, 624);
            this.Controls.Add(this.btnStaffMainRefresh);
            this.Controls.Add(this.btnStaffMng);
            this.Controls.Add(this.txtStaffMainSearch);
            this.Controls.Add(this.btnStaffMakePayment);
            this.Controls.Add(this.btnStaffGenerateRoomKey);
            this.Controls.Add(this.btnStaffLogout);
            this.Controls.Add(this.btnStaffRestaurant);
            this.Controls.Add(this.btnStaffSpa);
            this.Controls.Add(this.btnStaffStay);
            this.Controls.Add(this.pcbStaffMainLogo);
            this.Controls.Add(this.btnStaffCheckout);
            this.Controls.Add(this.btnStaffCheckin);
            this.Controls.Add(this.btnStaffSearch);
            this.Controls.Add(this.btnStaffVoucher);
            this.Controls.Add(this.btnStaffReceipt);
            this.Controls.Add(this.btnStaffMenu);
            this.Controls.Add(this.dgvStaffMain);
            this.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "StaffMain";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.StaffMain_Load);
            this.Shown += new System.EventHandler(this.StaffMain_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaffMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomReservationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbStaffMainLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStaffMain;
        private System.Windows.Forms.Button btnStaffMenu;
        private System.Windows.Forms.Button btnStaffReceipt;
        private System.Windows.Forms.Button btnStaffVoucher;
        private System.Windows.Forms.Button btnStaffSearch;
        private System.Windows.Forms.Button btnStaffCheckin;
        private System.Windows.Forms.Button btnStaffCheckout;
        private System.Windows.Forms.PictureBox pcbStaffMainLogo;
        private System.Windows.Forms.Button btnStaffStay;
        private System.Windows.Forms.Button btnStaffSpa;
        private System.Windows.Forms.Button btnStaffRestaurant;
        private System.Windows.Forms.Button btnStaffLogout;
        private System.Windows.Forms.Button btnStaffGenerateRoomKey;
        private System.Windows.Forms.Button btnStaffMakePayment;
        private System.Windows.Forms.TextBox txtStaffMainSearch;
        private System.Windows.Forms.Button btnStaffMng;
        private System.Windows.Forms.BindingSource personBindingSource;
        private System.Windows.Forms.BindingSource roomReservationBindingSource;
        private System.Windows.Forms.Button btnStaffMainRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomReservationIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colResName;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkOutDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creditCardNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn billDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkedInDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isLateCheckoutDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn keyReturnedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Eamil;
    }
}