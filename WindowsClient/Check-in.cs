using BusinessEntities;
using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Policy;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GitITDone_Forms
{
    public partial class Check_in : Form
    {
        IModel Model;
        public Check_in(IModel _model)
        {
            InitializeComponent();
            Model = _model;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtBoxFirstName.Text == "" && txtBoxLastName.Text == "")
            {
                MessageBox.Show("Please enter a first and last name");
            }
            else
            {
                string searchFirstName = txtBoxFirstName.Text;
                string searchLastName = txtBoxLastName.Text;

                List<DataGridViewRow> matchingRows = new List<DataGridViewRow>();

                foreach (DataGridViewRow row in dgvCheckIn.Rows)
                {
                    bool matchFound = false;
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value != null && cell.Value.ToString().Contains(searchFirstName) && cell.Value.ToString().Contains(searchLastName))
                        {
                            matchFound = true;
                            matchingRows.Add(row);
                            break;
                        }
                    }



                }
                if (matchingRows.Count > 0)
                {
                    dgvCheckIn.ClearSelection();

                    foreach (DataGridViewRow row in matchingRows)
                    {
                        row.Selected = true;
                    }
                }
            }
            
        }

        private void dgvCheckIn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnCheckIn_Click(object sender, EventArgs e)
        {
            // nned to add DOB and Address to person and make them into a guest

            DateTime DOB = Convert.ToDateTime(textBox1.Text);
            string Address = rtbformCheckIn.Text;

            IPerson person = (IPerson)dgvCheckIn.CurrentRow.DataBoundItem;

            int personID = person.PersonID;
            string firstName = person.FirstName;
            string lastName = person.LastName;
            string phoneNumber = person.PhoneNumber;
            string email = person.Email;

            Model.addNewGuest(personID, firstName, lastName, phoneNumber, email, Address, DOB);

            MessageBox.Show("Person has been Checked In", "Checkin", MessageBoxButtons.OK);

            textBox1.Clear();
            rtbformCheckIn.Clear();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Check_in_Load(object sender, EventArgs e)
        {
            DisplayPeople();
        }

        public void DisplayPeople()
        {
            Model.PopulatePeople();
            dgvCheckIn.DataSource = new BindingList<IPerson>(Model.PersonList.ToList());
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dtpCheckInDate_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
