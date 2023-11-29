using BusinessLayer;
using System;
using System.Windows.Forms;

namespace ProductTracking
{
    public partial class formAddPerson : Form
    {
        IModel model;
        Form parent;
        public formAddPerson(IModel _model)
        {
            InitializeComponent();

            model = _model;

        }

        private void btnAddPersonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddPersonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddPersonConfirm_Click(object sender, EventArgs e)
        {
            string fName = txtAddPersonFName.Text;
            string lName = txtAddPersonLName.Text;
            string phoneNum = txtAddPersonPhoneNo.Text;
            string email = txtAddPersonEmail.Text;
            model.addNewPerson(fName, lName, phoneNum, email);
            this.Close();
        }


    }
}
