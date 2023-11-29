using BusinessEntities;
using BusinessLayer;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ProductTracking
{
    public partial class formEditUser : Form
    {
        #region Instance Attributes
        IModel Model;
        formContainer fc;
        #endregion

        #region Constructors
        public formEditUser(IModel Model)
        {
            InitializeComponent();
            this.Model = Model;
        }
        #endregion

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void PopulateDataSource()
        {
            userBindingSource.DataSource = Model.UserList;
            dgvUserList.Columns[0].ReadOnly = true;
            DataGridViewButtonColumn colSaveButton = new DataGridViewButtonColumn()
            {
                Name = "btnSave",
                HeaderText = "",
                Text = "Save",
                UseColumnTextForButtonValue = true //dont forget this line
            };
            dgvUserList.Columns.Add(colSaveButton);
        }

        private void formEditUser_Load(object sender, EventArgs e)
        {
            //dgvUserList.AutoGenerateColumns = false;
            PopulateDataSource();

        }

        private void btnSaveAll_Click(object sender, EventArgs e)
        {
            foreach (User user in Model.UserList)
            {
                user.PrintUserDetails();
                Model.editUser(user);
            }
        }

        private void dgvUserList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                foreach (User user in Model.UserList)
                {
                    if (user.UserID == (int)dgvUserList.Rows[e.RowIndex].Cells[0].Value)
                    {
                        user.PrintUserDetails();
                        Model.editUser(user);
                    }
                }
            }
        }

        private void dgvUserList_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex == -1) return;

            if (e.ColumnIndex == 3)
            {
                //Initialized a new DateTimePicker Control  
                var dtStartDate = new DateTimePicker
                {
                    Name = "dtStartDate"
                };
                //MessageBox.Show(e.RowIndex.ToString());
                //Adding DateTimePicker control into DataGridView   
                dgvUserList.Controls.Add(dtStartDate);

                dtStartDate.Value = DateTime.Parse(dgvUserList.CurrentCell.Value.ToString());
                // Setting the format (i.e. 2014-10-10)  
                dtStartDate.Format = DateTimePickerFormat.Short;

                // It returns the retangular area that represents the Display area for a cell  
                Rectangle oRectangle = dgvUserList.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);

                //Setting area for DateTimePicker Control  
                dtStartDate.Size = new Size(oRectangle.Width, oRectangle.Height);

                // Setting Location  
                dtStartDate.Location = new Point(oRectangle.X, oRectangle.Y);

                dtStartDate.Visible = true;
                dtStartDate.Focus();

                // An event attached to dateTimePicker Control which is fired when DateTimeControl is closed  
                dtStartDate.CloseUp += (object s, EventArgs evn) => removeControl("dtStartDate");
                dtStartDate.LostFocus += (object s, EventArgs evn) => removeControl("dtStartDate");
                // An event attached to dateTimePicker Control which is fired when any date is selected  
                dtStartDate.TextChanged += (object s, EventArgs evn) =>
                {
                    var control = dgvUserList.Controls.Find("dtStartDate", true);
                    dgvUserList.CurrentCell.Value = control[0].Text.ToString();
                };


            }

            else if (e.ColumnIndex == 5)
            {
                var cmbxDepartment = new ComboBox
                {
                    Name = "cmbxDepartment"
                };

                dgvUserList.Controls.Add(cmbxDepartment);

                cmbxDepartment.DataSource = new string[] { "Spa", "Dining", "Room", "Administration" };
                cmbxDepartment.SelectedIndex = cmbxDepartment.FindStringExact(dgvUserList.CurrentCell.Value.ToString());
                //MessageBox.Show(cmbxDepartment.FindStringExact(dgvUserList.CurrentCell.Value.ToString()).ToString());
                // It returns the retangular area that represents the Display area for a cell  
                Rectangle oRectangle = dgvUserList.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                cmbxDepartment.Size = new Size(oRectangle.Width, oRectangle.Height);
                cmbxDepartment.Location = new Point(oRectangle.X, oRectangle.Y);

                // Now make it visible  
                cmbxDepartment.Visible = true;
                cmbxDepartment.Focus();
                //events 

                cmbxDepartment.SelectedValueChanged += (object s, EventArgs evn) =>
                {
                    var control = dgvUserList.Controls.Find("cmbxDepartment", true);
                    dgvUserList.CurrentCell.Value = control[0].Text.ToString();

                };

                cmbxDepartment.LostFocus += (object s, EventArgs evn) => removeControl("cmbxDepartment");



            }

            else if (e.ColumnIndex == 7)
            {
                var cmbxPosition = new ComboBox
                {
                    Name = "cmbxPosition"
                };

                dgvUserList.Controls.Add(cmbxPosition);

                cmbxPosition.DataSource = new string[] { "Staff", "General Manager", "Manager", "Administrator" };
                cmbxPosition.SelectedIndex = cmbxPosition.FindStringExact(dgvUserList.CurrentCell.Value.ToString());
                //MessageBox.Show(cmbxDepartment.FindStringExact(dgvUserList.CurrentCell.Value.ToString()).ToString());
                // It returns the retangular area that represents the Display area for a cell  

                Rectangle oRectangle = dgvUserList.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                cmbxPosition.Size = new Size(oRectangle.Width, oRectangle.Height);
                cmbxPosition.Location = new Point(oRectangle.X, oRectangle.Y);

                // Now make it visible  
                cmbxPosition.Visible = true;
                cmbxPosition.Focus();
                //events 

                cmbxPosition.SelectedValueChanged += (object s, EventArgs evn) =>
                {
                    var control = dgvUserList.Controls.Find("cmbxPosition", true);
                    dgvUserList.CurrentCell.Value = control[0].Text.ToString();

                };

                cmbxPosition.LostFocus += (object s, EventArgs evn) => removeControl("cmbxPosition");
            }
        }

        private void removeControl(string controlName)
        {
            try
            {
                dgvUserList.Controls.Remove(dgvUserList.Controls.Find(controlName, true)[0]);

            }
            catch (IndexOutOfRangeException e)
            {
                Debug.WriteLine(e.Message);
            }
        }


    }
}
