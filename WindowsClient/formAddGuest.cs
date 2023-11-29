using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductTracking
{
    public partial class formAddGuest : Form
    {
        IModel model;
        public formAddGuest(IModel _model)
        {
            InitializeComponent();
            model = _model;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void formbtnAddGuestConfirm_Click(object sender, EventArgs e)
        {
            string firstName = formtxtAddGuestFName.Text;
            string lastName = formtxtAddGuestLName.Text;
            string phoneNum = formtxtAddGuestPhoneNum.Text;
            string email = formtxtAddGuestEmail.Text;
            string CreditCard = formtxtAddGuestCreditCard.Text;
            DateTime DOB = formdtpAddGuestDOB.Value;
            string address = formrtbAddGuestAddress.Text;
            //model.addNewPerson(firstName, lastName, phoneNum, email);
            model.addNewPerson(firstName, lastName, phoneNum, email);
            this.Close();
        }

        private void formAddGuest_Load(object sender, EventArgs e)
        {

        }
    }
}
