using BusinessEntities;
using BusinessLayer;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ProductTracking
{
    public partial class formAddUser : Form
    {
        #region Instance Attributes
        IModel Model;
        formContainer fc;
        #endregion

        #region Constructors
        public formAddUser(IModel _model)
        {
            InitializeComponent();
            Model = _model;

        }
        #endregion

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }
        /*
         * LINQ (Language Integrated Query) is a Microsoft programming model and methodology that essentially adds formal query capabilities into Microsoft .NET-based programming languages. LINQ offers a 
         * compact, expressive, and intelligible syntax for manipulating data.
         * */
        private void buttonCommit_Click(object sender, EventArgs e)
        {
            // some validation on userName, we won't allow duplicate usernames
            IUser duplicateUser = Model.UserList.FirstOrDefault(user => user.Username == textBoxName.Text.Trim());
            /* provides a shortcut to accessing the element that occurs first in the collection or query,
            while protecting against invalid accesses if there are no elements.It'sa linq query. FirstOrDefault is a generic method which means it accepts a type parameter that indicates what types it acts upon. 
            The => is a lambda operator. Anything before the => are the input parameters, and anything after is the expression. You can have multiple input parameters.
            Think of a lambda expression as"given x, do something with x"                                                                                          * */
            if (duplicateUser == null)
            {
                if (Model.addNewUser(textBoxName.Text, textBoxPassword.Text, chbxManager.Checked, Convert.ToDouble(txtSalary.Text), cmbDepartment.SelectedItem.ToString(), txtPhoneNo.Text, cmbPosition.SelectedItem.ToString(), dtStartDate.Value.Date))
                {
                    MessageBox.Show("User created");
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Error adding user");
                }
            }
            else
            {
                MessageBox.Show("Duplicate User name, enter a different name!");
                MessageBox.Show(duplicateUser.Username + " " + duplicateUser.Password);  // just to show directOrDefault returns the matching user where there is one. 
                ClearFields();
            }

        }

        private void ClearFields()
        {
            textBoxName.Text = "";
            textBoxPassword.Text = "";
            chbxManager.Checked = false;
            txtSalary.Text = "";
            cmbDepartment.SelectedItem = null;
            cmbPosition.SelectedItem = null;
            txtPhoneNo.Text = "";
            dtStartDate.Value = DateTime.Now.Date;
        }

    }
}
