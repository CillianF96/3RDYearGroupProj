using System.Drawing;
using System.Windows.Forms;

namespace ProductTracking
{
    partial class AdminStay
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminStay));
            this.calStayDateSpan = new System.Windows.Forms.MonthCalendar();
            this.lblCheckIn = new System.Windows.Forms.Label();
            this.AdminRoomCounter = new System.Windows.Forms.NumericUpDown();
            this.lblAdminRoomNums = new System.Windows.Forms.Label();
            this.lblRoomType = new System.Windows.Forms.Label();
            this.AdminCmbRoomType = new System.Windows.Forms.ComboBox();
            this.AdminCbxBreakfast = new System.Windows.Forms.CheckBox();
            this.AdminCbxLateCheckOut = new System.Windows.Forms.CheckBox();
            this.AdminbtnBookDinner = new System.Windows.Forms.Button();
            this.AdminbtnBookSpa = new System.Windows.Forms.Button();
            this.AdminbtnExperiences = new System.Windows.Forms.Button();
            this.btnAdminStayClose = new System.Windows.Forms.Button();
            this.AdminStaylblStay = new System.Windows.Forms.Label();
            this.btnStayConfirm = new System.Windows.Forms.Button();
            this.lblStayPrice = new System.Windows.Forms.Label();
            this.txtStayPrice = new System.Windows.Forms.TextBox();
            this.dgvStay = new System.Windows.Forms.DataGridView();
            this.roomReservationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnStaySave = new System.Windows.Forms.Button();
            this.cmbxPeople = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtResTime = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCreditCardNo = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.roomReservationIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colResName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkOutDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creditCardNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keyReturnedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.checkedInDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.AdminRoomCounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomReservationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // calStayDateSpan
            // 
            this.calStayDateSpan.Location = new System.Drawing.Point(80, 120);
            this.calStayDateSpan.Margin = new System.Windows.Forms.Padding(12);
            this.calStayDateSpan.MaxSelectionCount = 30;
            this.calStayDateSpan.Name = "calStayDateSpan";
            this.calStayDateSpan.TabIndex = 3;
            this.calStayDateSpan.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calStayDateSpan_DateChanged);
            this.calStayDateSpan.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.calStayDateSpan_DateSelected);
            // 
            // lblCheckIn
            // 
            this.lblCheckIn.AutoSize = true;
            this.lblCheckIn.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckIn.Location = new System.Drawing.Point(70, 57);
            this.lblCheckIn.Name = "lblCheckIn";
            this.lblCheckIn.Size = new System.Drawing.Size(324, 44);
            this.lblCheckIn.TabIndex = 5;
            this.lblCheckIn.Text = "Check-in / Check-out";
            // 
            // AdminRoomCounter
            // 
            this.AdminRoomCounter.Location = new System.Drawing.Point(730, 117);
            this.AdminRoomCounter.Name = "AdminRoomCounter";
            this.AdminRoomCounter.Size = new System.Drawing.Size(44, 26);
            this.AdminRoomCounter.TabIndex = 7;
            // 
            // lblAdminRoomNums
            // 
            this.lblAdminRoomNums.AutoSize = true;
            this.lblAdminRoomNums.Location = new System.Drawing.Point(632, 120);
            this.lblAdminRoomNums.Name = "lblAdminRoomNums";
            this.lblAdminRoomNums.Size = new System.Drawing.Size(60, 20);
            this.lblAdminRoomNums.TabIndex = 8;
            this.lblAdminRoomNums.Text = "Rooms";
            // 
            // lblRoomType
            // 
            this.lblRoomType.AutoSize = true;
            this.lblRoomType.Location = new System.Drawing.Point(632, 169);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(90, 20);
            this.lblRoomType.TabIndex = 9;
            this.lblRoomType.Text = "Room Type";
            // 
            // AdminCmbRoomType
            // 
            this.AdminCmbRoomType.FormattingEnabled = true;
            this.AdminCmbRoomType.Items.AddRange(new object[] {
            "Comfort Rooms",
            "Charm Rooms",
            "Deluxe 2 Bedroom Suite"});
            this.AdminCmbRoomType.Location = new System.Drawing.Point(730, 165);
            this.AdminCmbRoomType.Name = "AdminCmbRoomType";
            this.AdminCmbRoomType.Size = new System.Drawing.Size(154, 28);
            this.AdminCmbRoomType.TabIndex = 10;
            this.AdminCmbRoomType.SelectedIndexChanged += new System.EventHandler(this.AdminCmbRoomType_SelectedIndexChanged);
            // 
            // AdminCbxBreakfast
            // 
            this.AdminCbxBreakfast.AutoSize = true;
            this.AdminCbxBreakfast.Location = new System.Drawing.Point(636, 218);
            this.AdminCbxBreakfast.Name = "AdminCbxBreakfast";
            this.AdminCbxBreakfast.Size = new System.Drawing.Size(140, 24);
            this.AdminCbxBreakfast.TabIndex = 13;
            this.AdminCbxBreakfast.Text = "With Breakfast";
            this.AdminCbxBreakfast.UseVisualStyleBackColor = true;
            // 
            // AdminCbxLateCheckOut
            // 
            this.AdminCbxLateCheckOut.AutoSize = true;
            this.AdminCbxLateCheckOut.Location = new System.Drawing.Point(636, 263);
            this.AdminCbxLateCheckOut.Name = "AdminCbxLateCheckOut";
            this.AdminCbxLateCheckOut.Size = new System.Drawing.Size(217, 24);
            this.AdminCbxLateCheckOut.TabIndex = 14;
            this.AdminCbxLateCheckOut.Text = "Late Check Out Until 2pm";
            this.AdminCbxLateCheckOut.UseVisualStyleBackColor = true;
            // 
            // AdminbtnBookDinner
            // 
            this.AdminbtnBookDinner.Location = new System.Drawing.Point(40, 731);
            this.AdminbtnBookDinner.Name = "AdminbtnBookDinner";
            this.AdminbtnBookDinner.Size = new System.Drawing.Size(152, 40);
            this.AdminbtnBookDinner.TabIndex = 15;
            this.AdminbtnBookDinner.Text = "Book Dinner";
            this.AdminbtnBookDinner.UseVisualStyleBackColor = true;
            // 
            // AdminbtnBookSpa
            // 
            this.AdminbtnBookSpa.Location = new System.Drawing.Point(198, 731);
            this.AdminbtnBookSpa.Name = "AdminbtnBookSpa";
            this.AdminbtnBookSpa.Size = new System.Drawing.Size(152, 40);
            this.AdminbtnBookSpa.TabIndex = 16;
            this.AdminbtnBookSpa.Text = "Book Spa";
            this.AdminbtnBookSpa.UseVisualStyleBackColor = true;
            // 
            // AdminbtnExperiences
            // 
            this.AdminbtnExperiences.Location = new System.Drawing.Point(356, 731);
            this.AdminbtnExperiences.Name = "AdminbtnExperiences";
            this.AdminbtnExperiences.Size = new System.Drawing.Size(152, 40);
            this.AdminbtnExperiences.TabIndex = 17;
            this.AdminbtnExperiences.Text = "Experiences";
            this.AdminbtnExperiences.UseVisualStyleBackColor = true;
            // 
            // btnAdminStayClose
            // 
            this.btnAdminStayClose.Location = new System.Drawing.Point(830, 736);
            this.btnAdminStayClose.Name = "btnAdminStayClose";
            this.btnAdminStayClose.Size = new System.Drawing.Size(96, 31);
            this.btnAdminStayClose.TabIndex = 18;
            this.btnAdminStayClose.Text = "Close";
            this.btnAdminStayClose.UseVisualStyleBackColor = true;
            this.btnAdminStayClose.Click += new System.EventHandler(this.btnAdminStayClose_Click);
            // 
            // AdminStaylblStay
            // 
            this.AdminStaylblStay.AutoSize = true;
            this.AdminStaylblStay.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.AdminStaylblStay.Location = new System.Drawing.Point(375, 9);
            this.AdminStaylblStay.Name = "AdminStaylblStay";
            this.AdminStaylblStay.Size = new System.Drawing.Size(97, 48);
            this.AdminStaylblStay.TabIndex = 19;
            this.AdminStaylblStay.Text = "STAY";
            // 
            // btnStayConfirm
            // 
            this.btnStayConfirm.Location = new System.Drawing.Point(672, 431);
            this.btnStayConfirm.Name = "btnStayConfirm";
            this.btnStayConfirm.Size = new System.Drawing.Size(226, 32);
            this.btnStayConfirm.TabIndex = 21;
            this.btnStayConfirm.Text = "Add Customer Details";
            this.btnStayConfirm.UseVisualStyleBackColor = true;
            this.btnStayConfirm.Click += new System.EventHandler(this.btnStayConfirm_Click);
            // 
            // lblStayPrice
            // 
            this.lblStayPrice.AutoSize = true;
            this.lblStayPrice.Location = new System.Drawing.Point(632, 312);
            this.lblStayPrice.Name = "lblStayPrice";
            this.lblStayPrice.Size = new System.Drawing.Size(78, 20);
            this.lblStayPrice.TabIndex = 22;
            this.lblStayPrice.Text = "Stay Cost";
            // 
            // txtStayPrice
            // 
            this.txtStayPrice.Location = new System.Drawing.Point(717, 309);
            this.txtStayPrice.Name = "txtStayPrice";
            this.txtStayPrice.ReadOnly = true;
            this.txtStayPrice.Size = new System.Drawing.Size(142, 26);
            this.txtStayPrice.TabIndex = 23;
            // 
            // dgvStay
            // 
            this.dgvStay.AllowUserToAddRows = false;
            this.dgvStay.AllowUserToDeleteRows = false;
            this.dgvStay.AutoGenerateColumns = false;
            this.dgvStay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.roomReservationIDDataGridViewTextBoxColumn,
            this.bookingNumberDataGridViewTextBoxColumn,
            this.colResName,
            this.dateDataGridViewTextBoxColumn,
            this.checkOutDateDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn,
            this.creditCardNumberDataGridViewTextBoxColumn,
            this.billDataGridViewTextBoxColumn,
            this.keyReturnedDataGridViewCheckBoxColumn,
            this.checkedInDataGridViewCheckBoxColumn,
            this.Email});
            this.dgvStay.DataSource = this.roomReservationBindingSource;
            this.dgvStay.Location = new System.Drawing.Point(40, 477);
            this.dgvStay.Name = "dgvStay";
            this.dgvStay.ReadOnly = true;
            this.dgvStay.RowHeadersWidth = 62;
            this.dgvStay.RowTemplate.Height = 28;
            this.dgvStay.Size = new System.Drawing.Size(858, 231);
            this.dgvStay.TabIndex = 24;
            this.dgvStay.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStay_CellClick);
            // 
            // roomReservationBindingSource
            // 
            this.roomReservationBindingSource.DataSource = typeof(BusinessEntities.RoomReservation);
            // 
            // btnStaySave
            // 
            this.btnStaySave.Location = new System.Drawing.Point(556, 431);
            this.btnStaySave.Name = "btnStaySave";
            this.btnStaySave.Size = new System.Drawing.Size(84, 32);
            this.btnStaySave.TabIndex = 25;
            this.btnStaySave.Text = "Confirm";
            this.btnStaySave.UseVisualStyleBackColor = true;
            this.btnStaySave.Click += new System.EventHandler(this.btnStaySave_Click);
            // 
            // cmbxPeople
            // 
            this.cmbxPeople.FormattingEnabled = true;
            this.cmbxPeople.Location = new System.Drawing.Point(436, 145);
            this.cmbxPeople.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbxPeople.Name = "cmbxPeople";
            this.cmbxPeople.Size = new System.Drawing.Size(180, 28);
            this.cmbxPeople.TabIndex = 26;
            this.cmbxPeople.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmbxPeople_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(436, 120);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Reservation Name";
            // 
            // dtResTime
            // 
            this.dtResTime.CustomFormat = "HH:mm";
            this.dtResTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtResTime.Location = new System.Drawing.Point(189, 386);
            this.dtResTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtResTime.Name = "dtResTime";
            this.dtResTime.ShowUpDown = true;
            this.dtResTime.Size = new System.Drawing.Size(100, 26);
            this.dtResTime.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(440, 194);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "Credit Card No";
            // 
            // txtCreditCardNo
            // 
            this.txtCreditCardNo.Location = new System.Drawing.Point(436, 218);
            this.txtCreditCardNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCreditCardNo.MaxLength = 16;
            this.txtCreditCardNo.Name = "txtCreditCardNo";
            this.txtCreditCardNo.Size = new System.Drawing.Size(180, 26);
            this.txtCreditCardNo.TabIndex = 30;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(424, 431);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(112, 32);
            this.btnEdit.TabIndex = 31;
            this.btnEdit.Text = "Edit Row";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Visible = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(290, 431);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 32);
            this.btnCancel.TabIndex = 32;
            this.btnCancel.Text = "Cancel Edit";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // roomReservationIDDataGridViewTextBoxColumn
            // 
            this.roomReservationIDDataGridViewTextBoxColumn.DataPropertyName = "RoomReservationID";
            this.roomReservationIDDataGridViewTextBoxColumn.HeaderText = "Reservation ID";
            this.roomReservationIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.roomReservationIDDataGridViewTextBoxColumn.Name = "roomReservationIDDataGridViewTextBoxColumn";
            this.roomReservationIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.roomReservationIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // bookingNumberDataGridViewTextBoxColumn
            // 
            this.bookingNumberDataGridViewTextBoxColumn.DataPropertyName = "BookingNumber";
            this.bookingNumberDataGridViewTextBoxColumn.HeaderText = "Booking Number";
            this.bookingNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bookingNumberDataGridViewTextBoxColumn.Name = "bookingNumberDataGridViewTextBoxColumn";
            this.bookingNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.bookingNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // colResName
            // 
            this.colResName.HeaderText = "Reservation Name";
            this.colResName.MinimumWidth = 6;
            this.colResName.Name = "colResName";
            this.colResName.ReadOnly = true;
            this.colResName.Width = 125;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateDataGridViewTextBoxColumn.Width = 125;
            // 
            // checkOutDateDataGridViewTextBoxColumn
            // 
            this.checkOutDateDataGridViewTextBoxColumn.DataPropertyName = "CheckOutDate";
            this.checkOutDateDataGridViewTextBoxColumn.HeaderText = "Check Out Date";
            this.checkOutDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.checkOutDateDataGridViewTextBoxColumn.Name = "checkOutDateDataGridViewTextBoxColumn";
            this.checkOutDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.checkOutDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "Time";
            this.timeDataGridViewTextBoxColumn.HeaderText = "Time";
            this.timeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            this.timeDataGridViewTextBoxColumn.ReadOnly = true;
            this.timeDataGridViewTextBoxColumn.Width = 125;
            // 
            // creditCardNumberDataGridViewTextBoxColumn
            // 
            this.creditCardNumberDataGridViewTextBoxColumn.DataPropertyName = "CreditCardNumber";
            this.creditCardNumberDataGridViewTextBoxColumn.HeaderText = "Credit Card Number";
            this.creditCardNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.creditCardNumberDataGridViewTextBoxColumn.Name = "creditCardNumberDataGridViewTextBoxColumn";
            this.creditCardNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.creditCardNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // billDataGridViewTextBoxColumn
            // 
            this.billDataGridViewTextBoxColumn.DataPropertyName = "Bill";
            this.billDataGridViewTextBoxColumn.HeaderText = "Bill";
            this.billDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.billDataGridViewTextBoxColumn.Name = "billDataGridViewTextBoxColumn";
            this.billDataGridViewTextBoxColumn.ReadOnly = true;
            this.billDataGridViewTextBoxColumn.Width = 125;
            // 
            // keyReturnedDataGridViewCheckBoxColumn
            // 
            this.keyReturnedDataGridViewCheckBoxColumn.DataPropertyName = "KeyReturned";
            this.keyReturnedDataGridViewCheckBoxColumn.HeaderText = "Key Returned";
            this.keyReturnedDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.keyReturnedDataGridViewCheckBoxColumn.Name = "keyReturnedDataGridViewCheckBoxColumn";
            this.keyReturnedDataGridViewCheckBoxColumn.ReadOnly = true;
            this.keyReturnedDataGridViewCheckBoxColumn.Width = 125;
            // 
            // checkedInDataGridViewCheckBoxColumn
            // 
            this.checkedInDataGridViewCheckBoxColumn.DataPropertyName = "CheckedIn";
            this.checkedInDataGridViewCheckBoxColumn.HeaderText = "Checked In";
            this.checkedInDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.checkedInDataGridViewCheckBoxColumn.Name = "checkedInDataGridViewCheckBoxColumn";
            this.checkedInDataGridViewCheckBoxColumn.ReadOnly = true;
            this.checkedInDataGridViewCheckBoxColumn.Width = 125;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 8;
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 150;
            // 
            // AdminStay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 783);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.txtCreditCardNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtResTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbxPeople);
            this.Controls.Add(this.btnStaySave);
            this.Controls.Add(this.dgvStay);
            this.Controls.Add(this.txtStayPrice);
            this.Controls.Add(this.lblStayPrice);
            this.Controls.Add(this.btnStayConfirm);
            this.Controls.Add(this.AdminStaylblStay);
            this.Controls.Add(this.btnAdminStayClose);
            this.Controls.Add(this.AdminbtnExperiences);
            this.Controls.Add(this.AdminbtnBookSpa);
            this.Controls.Add(this.AdminbtnBookDinner);
            this.Controls.Add(this.AdminCbxLateCheckOut);
            this.Controls.Add(this.AdminCbxBreakfast);
            this.Controls.Add(this.AdminCmbRoomType);
            this.Controls.Add(this.lblRoomType);
            this.Controls.Add(this.lblAdminRoomNums);
            this.Controls.Add(this.AdminRoomCounter);
            this.Controls.Add(this.lblCheckIn);
            this.Controls.Add(this.calStayDateSpan);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminStay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Room Reservation";
            this.Load += new System.EventHandler(this.AdminStay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AdminRoomCounter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomReservationBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MonthCalendar calStayDateSpan;
        private Label lblCheckIn;
        private NumericUpDown AdminRoomCounter;
        private Label lblAdminRoomNums;
        private Label lblRoomType;
        private ComboBox AdminCmbRoomType;
        private Label label2;
        private CheckBox AdminCbxBreakfast;
        private CheckBox AdminCbxLateCheckOut;
        private Button AdminbtnBookDinner;
        private Button AdminbtnBookSpa;
        private Button AdminbtnExperiences;
        private Button btnAdminStayClose;
        private Label AdminStaylblStay;
        private Button btnStayConfirm;
        private Label lblStayPrice;
        private TextBox txtStayPrice;
        private DataGridView dgvStay;
        private Button btnStaySave;
        private DataGridViewTextBoxColumn mainBookingNumberDataGridViewTextBoxColumn;
        private BindingSource roomReservationBindingSource;
        private ComboBox cmbxPeople;
        private Label label1;
        private DateTimePicker dtResTime;
        private Label label3;
        private TextBox txtCreditCardNo;
        private Button btnEdit;
        private Button btnCancel;
        private DataGridViewTextBoxColumn roomReservationIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bookingNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn colResName;
        private DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn checkOutDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn creditCardNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn billDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn keyReturnedDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn checkedInDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn Email;
    }
}