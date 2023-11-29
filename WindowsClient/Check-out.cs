using BusinessEntities;
using BusinessLayer;
using System;
using System.Windows.Forms;

namespace GitITDone_Forms
{
    public partial class Check_out : Form
    {
        IModel Model;
        IRoomReservation GuestCheckout;
        public Check_out(IModel _model, IRoomReservation GuestInfo)
        {
            InitializeComponent();
            Model = _model;
            GuestCheckout = GuestInfo;
        }

        private void BtnCheckIn_Click(object sender, EventArgs e)
        {
            try
            {
                Model.DeleteRoomResv(GuestCheckout);
                MessageBox.Show("Check-out Complete");
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                           
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void BtnMakePayment_Click(object sender, EventArgs e)
        {

        }

        private void Check_out_Load(object sender, EventArgs e)
        {
            if(GuestCheckout == null)
            {
                txtBoxAmountDue.Text = "0";
                MessageBox.Show("Please choose a reservation to check-out");
                this.Close();
            }
            else
            {
                txtBoxAmountDue.Text = GuestCheckout.Bill.ToString();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
