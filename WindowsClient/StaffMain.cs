using BusinessEntities;
using BusinessLayer;
using ConsolatioWireFrames;
using ProductTracking;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GitITDone_Forms
{
    public partial class StaffMain : Form
    {

        IModel Model;
        IRoomReservation GuestInfo;
        public StaffMain(IModel _model)
        {
            InitializeComponent();
            Model = _model;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnStaffStay_Click(object sender, EventArgs e)
        {
            AdminStay stay = new AdminStay(Model);
            stay.Show();
        }

        private void btnStaffSpa_Click(object sender, EventArgs e)
        {

        }

        private void btnStaffRestaurant_Click(object sender, EventArgs e)
        {
            formDiningMain diningMain = new formDiningMain(Model);
            diningMain.Show();
        }

        private void btnStaffCheckin_Click(object sender, EventArgs e)
        {
            Check_in checkIn = new Check_in(Model);
            checkIn.Show();
        }

        private void btnStaffCheckout_Click(object sender, EventArgs e)
        {
            Check_out checkOut = new Check_out(Model, GuestInfo);
            checkOut.Show();
        }

        private void btnStaffReceipt_Click(object sender, EventArgs e)
        {

        }

        private void btnStaffVoucher_Click(object sender, EventArgs e)
        {
            VoucherForm voucherForm = new VoucherForm(Model);
            voucherForm.Show();
        }

        private void btnStaffMakePayment_Click(object sender, EventArgs e)
        {
            formMakePayment makePayment = new formMakePayment(Model,GuestInfo);
            makePayment.Show();
        }

        private void btnStaffMng_Click(object sender, EventArgs e)
        {
           
            formManager fm = new formManager(Model);
            fm.Show();
            
        }

        private void StaffMain_Load(object sender, EventArgs e)
        {
            this.Hide();
            formLogin formLgn = new formLogin(Model);
            formLgn.ShowDialog();
            
            if (!Model.CurrentUser.IsManager)
            {
                btnStaffMng.Visible=false;
            }

            if (!Application.OpenForms.OfType<formLogin>().Any())
            {
                this.Show();
            }
            DisplayReservations();
        }
        public void DisplayReservations()
        {
            var roomResList = Model.ReservationList.OfType<RoomReservation>().ToList();

            roomReservationBindingSource.DataSource = roomResList;

            for (int i = 0; i < roomResList.Count; i++)
            {
                dgvStaffMain.Rows[i].Cells["colResName"].Value = roomResList[i].Person.FullName;
                dgvStaffMain.Rows[i].Cells["Eamil"].Value = roomResList[i].Person.Email;
            }
            dgvStaffMain.Columns["timeDataGridViewTextBoxColumn"].DefaultCellStyle.Format = @"hh\:mm";
            creditCardNumberDataGridViewTextBoxColumn.Visible = false;
            roomReservationIDDataGridViewTextBoxColumn.Visible=false;
            timeDataGridViewTextBoxColumn.Visible=false;
            checkedInDataGridViewCheckBoxColumn.Visible = false;
            isLateCheckoutDataGridViewCheckBoxColumn.Visible = false;
            keyReturnedDataGridViewCheckBoxColumn.Visible = false;

            Color myColor = Color.FromArgb(192, 192, 192);
            Color myColorYellow = Color.FromArgb(255, 255, 179);

            dgvStaffMain.EnableHeadersVisualStyles = false;
            dgvStaffMain.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);
            dgvStaffMain.ColumnHeadersDefaultCellStyle.BackColor = myColor;
            dgvStaffMain.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dgvStaffMain.DefaultCellStyle.SelectionBackColor = Color.Gray;
            dgvStaffMain.RowsDefaultCellStyle.SelectionBackColor = Color.Gray;
            dgvStaffMain.RowHeadersDefaultCellStyle.SelectionBackColor = Color.Gray;

            dgvStaffMain.AlternatingRowsDefaultCellStyle.BackColor = myColorYellow;

            //dgvStaffMain.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            //dgvStaffMain.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dgvStaffMain.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            //dgvStaffMain.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            //dgvStaffMain.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

        }

        private void StaffMain_Shown(object sender, EventArgs e)
        {

        }

        private void btnStaffLogout_Click(object sender, EventArgs e)
        {
            StaffMain_Load(null, EventArgs.Empty);
        }

        private void btnStaffGenerateRoomKey_Click(object sender, EventArgs e)
        {
            formKey key = new formKey(Model,GuestInfo);
            key.Show();

        }

        private void btnStaffMenu_Click(object sender, EventArgs e)
        {
            FoodMenuForm fmf = new FoodMenuForm(Model);
            fmf.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnStaffSearch_Click(object sender, EventArgs e)
        {
          
            txtStaffMainSearch.Focus();
            if (txtStaffMainSearch.Text == "")
            {
                MessageBox.Show("Please enter a name");
            }
            else
            {
                string name = txtStaffMainSearch.Text;
              
                bool matchFound = false;
                foreach (DataGridViewRow row in dgvStaffMain.Rows)
                {

                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value.ToString().Equals(name))
                        {
                            matchFound = true;
                            row.Selected = true;
                            break;
                        }

                    }



                }
                if (!matchFound) { MessageBox.Show($"{name} Reservation not found"); }
               
                txtStaffMainSearch.Clear();

                var roomResList = Model.ReservationList.OfType<RoomReservation>().ToList();

                string[] names = name.Split(' ');

                for (int i = 0; i < roomResList.Count; i++)
                {
                    if (roomResList[i].Person.FirstName == names[0] && roomResList[i].Person.LastName == names[1])
                    {
                        GuestInfo = roomResList[i];
                    }
                }

            }

        }//end of button search

        private void btnStaffMainRefresh_Click(object sender, EventArgs e)
        {
            DisplayReservations();
        }
    }

    }

