using BusinessEntities;
using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ProductTracking
{
    public partial class AdminStay : Form
    {
        IModel Model;
        public AdminStay(IModel _model)
        {
            InitializeComponent();
            Model = _model;
        }

        private void lblCheckIn_Click(object sender, EventArgs e)
        {

        }

        private void btnAdminStayClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStayConfirm_Click(object sender, EventArgs e)
        {
            formAddPerson newPerson = new formAddPerson(Model);
            newPerson.Show();
        }

        private List<IRoom> getAvailableRooms()
        {
            var filteredRes = Model.ReservationList.OfType<IRoomReservation>().Where(r => (calStayDateSpan.SelectionStart.Date >= r.Date && calStayDateSpan.SelectionStart.Date <= r.CheckOutDate) ||
                (calStayDateSpan.SelectionEnd.Date >= r.Date && calStayDateSpan.SelectionEnd.Date <= r.CheckOutDate)).ToList();
            //filteredRes.ForEach(ur => Debug.WriteLine(ur.RoomReservationID));
            var availableRooms = new List<IRoom>();
            if (filteredRes.Count == 0)
                availableRooms = Model.RoomList;
            for (int i = 0; i < Model.RoomList.Count; i++)
            {
                for (int j = 0; j < filteredRes.Count; j++)
                {
                    if (Model.RoomList[i].RoomID != filteredRes[j].Room.RoomID)
                    {
                        availableRooms.Add(Model.RoomList[i]);
                        break;
                    }
                }
            }
            return availableRooms;
        }

        private void btnStaySave_Click(object sender, EventArgs e)
        {

            //var reservedRooms = Model.ReservationList.OfType<IRoomReservation>().Where(r => r.Room.RoomType == AdminCmbRoomType.SelectedText).ToList();

            //Debug.WriteLine("first available roooms:");
            //Debug.WriteLine(availableRooms[0].RoomType);
            var firstAvailableRoom = getAvailableRooms().FirstOrDefault(ar => ar.RoomType == AdminCmbRoomType.Text);

            if (firstAvailableRoom == null)
            {
                MessageBox.Show(string.Format("No {0} room available for {1} - {2} period", AdminCmbRoomType.Text.ToLower(),
                    calStayDateSpan.SelectionStart.Date.ToString("d"),
                    calStayDateSpan.SelectionEnd.Date.ToString("d"))); return;
            }

            //Debug.WriteLine(firstAvailableRoom.RoomID);
            //MessageBox.Show(Convert.ToString(cmbxPeople.SelectedItem.GetType()));
            if (Model.addNewRoomReservation(
                calStayDateSpan.SelectionStart.Date,
                dtResTime.Value.TimeOfDay,
                txtCreditCardNo.Text,
                Convert.ToDouble(txtStayPrice.Text.Substring(1)),
                false,
                (Person)cmbxPeople.SelectedItem,
                calStayDateSpan.SelectionEnd.Date,
                (Room)firstAvailableRoom,
                false,
                AdminCbxLateCheckOut.Checked))
            {
                Person person = (Person)cmbxPeople.SelectedItem;
                MessageBox.Show("Room reserved");
                //Model.SendEmail(person.Email.ToString(), calStayDateSpan.SelectionStart.Date.ToString(), calStayDateSpan.SelectionEnd.Date.ToString(), txtStayPrice.Text);

                Refresh();
            }
            else
            {
                MessageBox.Show("Error adding reservation");
            }

            //var roomResList = Model.ReservationList.OfType<RoomReservation>().ToList();
            //roomReservationBindingSource.DataSource = roomResList;
            ////dgvStay.Update();
            ////dgvStay.Refresh();
            DisplayReservations();

        }



        private void AdminStay_Load(object sender, EventArgs e)
        {
            DisplayReservations();
            calStayDateSpan.MinDate = DateTime.Today;
            cmbxPeople.DataSource = Model.PersonList;
            cmbxPeople.DisplayMember = "FullName";
            AdminCmbRoomType.DataSource = new string[] { "Charm", "Deluxe Suit", "Comfort" };
        }

        private void DisplayReservations()
        {
            var roomResList = Model.ReservationList.OfType<RoomReservation>().ToList();

            roomReservationBindingSource.DataSource = roomResList;

            for (int i = 0; i < roomResList.Count; i++)
            {
                dgvStay.Rows[i].Cells["colResName"].Value = roomResList[i].Person.FullName;
                dgvStay.Rows[i].Cells["Email"].Value = roomResList[i].Person.Email;
            }
            dgvStay.Columns["timeDataGridViewTextBoxColumn"].DefaultCellStyle.Format = @"hh\:mm";
            //Debug.WriteLine(Model.ReservationList.OfType<RoomReservation>().ToList()[0].Time);

            DataGridViewButtonColumn colSaveButton = new DataGridViewButtonColumn()
            {
                Name = "btnDelete",
                HeaderText = "",
                Text = "Cancel Reservation",
                Width = 110,
                UseColumnTextForButtonValue = true //dont forget this line
            };

            creditCardNumberDataGridViewTextBoxColumn.Visible = false;
            roomReservationIDDataGridViewTextBoxColumn.Visible = false;
            timeDataGridViewTextBoxColumn.Visible = false;
            checkedInDataGridViewCheckBoxColumn.Visible = false;

            Color myColor = Color.FromArgb(192, 192, 192);
            Color myColorYellow = Color.FromArgb(255, 255, 179);

            dgvStay.EnableHeadersVisualStyles = false;
            dgvStay.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);
            dgvStay.ColumnHeadersDefaultCellStyle.BackColor = myColor;
            dgvStay.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dgvStay.DefaultCellStyle.SelectionBackColor = Color.Gray;
            dgvStay.RowsDefaultCellStyle.SelectionBackColor = Color.Gray;
            dgvStay.RowHeadersDefaultCellStyle.SelectionBackColor = Color.Gray;

            dgvStay.AlternatingRowsDefaultCellStyle.BackColor = myColorYellow;

            //dgvStay.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            //dgvStay.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dgvStay.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            //dgvStay.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            //dgvStay.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            keyReturnedDataGridViewCheckBoxColumn.Visible = false;
            if (!dgvStay.Columns.Cast<DataGridViewColumn>().Any(col => col.Name == "btnDelete"))
            {
                dgvStay.Columns.Add(colSaveButton);
            }


        }

        private void AdminCmbRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetRoomRate(AdminCmbRoomType.Text, new List<DateTime>() { calStayDateSpan.SelectionStart.Date, calStayDateSpan.SelectionEnd.Date });
        }

        private void dgvStay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            calStayDateSpan.MinDate = DateTime.Parse("01/01/2000");

            const int DeleteIndex = 11;

            btnEdit.Visible = true;
            btnCancel.Visible = true;
            btnStaySave.Visible = false;

            IRoomReservation selectedResv = (IRoomReservation)dgvStay.CurrentRow.DataBoundItem;

            calStayDateSpan.SelectionStart = selectedResv.Date;
            calStayDateSpan.SelectionEnd = selectedResv.CheckOutDate;

            //Debug.WriteLine(cmbxPeople.Items.IndexOf(selectedResv.Person));
            cmbxPeople.SelectedIndex = getMatchingPersonIndex(selectedResv.Person);
            AdminCmbRoomType.SelectedIndex = AdminCmbRoomType.FindStringExact(selectedResv.Room.RoomType);
            AdminCbxLateCheckOut.Checked = selectedResv.IsLateCheckout;
            //txtStayPrice.Text = "";
            txtCreditCardNo.Text = selectedResv.CreditCardNumber;
            dtResTime.Value = DateTime.Today.Add(selectedResv.Time);
            if (e.ColumnIndex == DeleteIndex)
            {
                DialogResult result =
                MessageBox.Show($"Delete Booking Number: {selectedResv.BookingNumber}?",
                "Confirm Delete", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {

                    Model.DeleteRoomResv(selectedResv);
                    try
                    {

                       // Model.SendCancellationEmail(selectedResv.Person.Email, selectedResv.Date.ToString(), selectedResv.CheckOutDate.ToString(), selectedResv.Bill.ToString());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }




                }
            }
            DisplayReservations();

        }

        private int getMatchingPersonIndex(IPerson findPerson)
        {
            foreach (IPerson person in cmbxPeople.Items)
            {
                if (person.PersonID == findPerson.PersonID)
                    return cmbxPeople.Items.IndexOf(person);
            }
            return -1;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            calStayDateSpan.MinDate = DateTime.Today;
            ClearFields();
        }

        private void ClearFields()
        {
            btnCancel.Visible = false;
            btnEdit.Visible = false;
            btnStaySave.Visible = true;
            calStayDateSpan.SelectionStart = DateTime.Today;
            calStayDateSpan.SelectionEnd = DateTime.Today;
            cmbxPeople.SelectedIndex = 0;
            AdminCmbRoomType.SelectedIndex = 0;
            AdminCbxLateCheckOut.Checked = false;
            AdminCmbRoomType_SelectedIndexChanged(null, EventArgs.Empty);
            txtCreditCardNo.Text = "";
            dtResTime.Value = DateTime.Now;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var firstAvailableRoom = getAvailableRooms().FirstOrDefault(ar => ar.RoomType == AdminCmbRoomType.Text);

            if (firstAvailableRoom == null)
            {
                MessageBox.Show(string.Format("No {0} room available for {1} - {2} period", AdminCmbRoomType.Text.ToLower(),
                    calStayDateSpan.SelectionStart.Date.ToString("d"),
                    calStayDateSpan.SelectionEnd.Date.ToString("d"))); return;
            }

            IRoomReservation roomResvEdit = (IRoomReservation)dgvStay.CurrentRow.DataBoundItem;

            //calStayDateSpan.SelectionStart.Date,
            //    dtResTime.Value.TimeOfDay,
            //    txtCreditCardNo.Text,
            //    Convert.ToDouble(txtStayPrice.Text.Substring(1)),
            //    false,
            //    (Person)cmbxPeople.SelectedItem,
            //    calStayDateSpan.SelectionEnd.Date,
            //    (Room)firstAvailableRoom,
            //    false,
            //    AdminCbxLateCheckOut.Checked
            if ((roomResvEdit.Date != calStayDateSpan.SelectionStart.Date && roomResvEdit.CheckOutDate != calStayDateSpan.SelectionEnd.Date) || roomResvEdit.Room.RoomType != AdminCmbRoomType.Text)
                roomResvEdit.Room = (Room)firstAvailableRoom;
            roomResvEdit.Date = calStayDateSpan.SelectionStart.Date;
            roomResvEdit.CheckOutDate = calStayDateSpan.SelectionEnd.Date;
            roomResvEdit.Time = dtResTime.Value.TimeOfDay;
            roomResvEdit.Bill = Convert.ToDouble(txtStayPrice.Text.Substring(1));
            roomResvEdit.Person = (Person)cmbxPeople.SelectedItem;

            roomResvEdit.IsLateCheckout = AdminCbxLateCheckOut.Checked;
            roomResvEdit.CreditCardNumber = txtCreditCardNo.Text;

            if (Model.editRoomReservation((IRoomReservation)dgvStay.CurrentRow.DataBoundItem))
                MessageBox.Show("Room reservation successfully edited");
            else
                MessageBox.Show("Error editing room reservation");
            ClearFields();
            Refresh();
            DisplayReservations();
        }

        private void GetRoomRate(string roomType, List<DateTime> startEnd)
        {
            double rate = 0;
            List<DateTime> dates = new List<DateTime>();
            for (int i = 0; i < (int)(startEnd[1] - startEnd[0]).TotalDays; i++)
            {
                dates.Add(startEnd[0].AddDays(i));
            }

            switch (roomType)
            {
                case "Comfort":

                    foreach (DateTime date in dates)
                    {
                        if (date.DayOfWeek == DayOfWeek.Monday || date.DayOfWeek == DayOfWeek.Tuesday)
                            rate += 225;
                        else if (date.DayOfWeek == DayOfWeek.Wednesday || date.DayOfWeek == DayOfWeek.Thursday)
                            rate += 245;
                        else
                            rate += 265;

                    }
                    break;
                case "Charm":
                    foreach (DateTime date in dates)
                    {
                        if (date.DayOfWeek == DayOfWeek.Monday || date.DayOfWeek == DayOfWeek.Tuesday)
                            rate += 255;
                        else if (date.DayOfWeek == DayOfWeek.Wednesday || date.DayOfWeek == DayOfWeek.Thursday)
                            rate += 275;
                        else
                            rate += 295;

                    }
                    break;

                case "Deluxe Suit":
                    foreach (DateTime date in dates)
                    {
                        if (date.DayOfWeek == DayOfWeek.Monday || date.DayOfWeek == DayOfWeek.Tuesday)
                            rate += 425;
                        else if (date.DayOfWeek == DayOfWeek.Wednesday || date.DayOfWeek == DayOfWeek.Thursday)
                            rate += 455;
                        else
                            rate += 475;
                    }
                    break;
                default:
                    break;
            }
            txtStayPrice.Text = "€" + rate.ToString();

        }

        private void cmbxPeople_MouseClick(object sender, MouseEventArgs e)
        {
            cmbxPeople.DataSource = null;
            cmbxPeople.DataSource = Model.PersonList;
            cmbxPeople.DisplayMember = "FullName";
        }

        private void calStayDateSpan_DateSelected(object sender, DateRangeEventArgs e)
        {
            GetRoomRate(AdminCmbRoomType.Text, new List<DateTime>() { calStayDateSpan.SelectionStart.Date, calStayDateSpan.SelectionEnd.Date });

        }


        private void calStayDateSpan_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

    }
}