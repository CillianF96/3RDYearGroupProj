using BusinessEntities;
using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ConsolatioWireFrames
{
    public partial class formMakePayment : Form
    {
        IModel Model;
        IRoomReservation client;
        public formMakePayment(IModel _model,IRoomReservation guestInfo)
        {
            InitializeComponent();
            Model = _model;
            client = guestInfo;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnMakePaymentClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grbMakePaymentCash_Enter(object sender, EventArgs e)
        {

        }

        private void btnMakePaymentSearch_Click(object sender, EventArgs e)
        {
           
        }

        private void chkMakePaymentCash_CheckedChanged(object sender, EventArgs e)
        {
            grbMakePaymentCash.Visible = true;

            if (grbCardDetails.Visible) { grbCardDetails.Visible = false; chkMakePaymentNewCard.Checked = false; }
            if (grpMakePaymentVoucherNum.Visible) { grpMakePaymentVoucherNum.Visible = false; chkMakePaymentVoucher.Checked = false; }
            if (grbMakePaymentRoomDetails.Visible) { grbMakePaymentRoomDetails.Visible = false; chkMakePaymentAddToRoom.Checked = false; }
        }

        private void chkMakePaymentVoucher_CheckedChanged(object sender, EventArgs e)
        {
            grpMakePaymentVoucherNum.Visible = true;

            if (grbMakePaymentCash.Visible) { grbMakePaymentCash.Visible = false; chkMakePaymentCash.Checked = false; }
            if (grbCardDetails.Visible) { grbCardDetails.Visible = false; chkMakePaymentNewCard.Checked = false; }
            if (grbMakePaymentRoomDetails.Visible) { grbMakePaymentRoomDetails.Visible = false; chkMakePaymentAddToRoom.Checked = false; }
        }

        private void chkMakePaymentNewCard_CheckedChanged(object sender, EventArgs e)
        {
            grbCardDetails.Visible = true;

            if (grbMakePaymentRoomDetails.Visible) { grbMakePaymentRoomDetails.Visible = false; chkMakePaymentAddToRoom.Checked = false; }
            if (grpMakePaymentVoucherNum.Visible) { grpMakePaymentVoucherNum.Visible = false; chkMakePaymentVoucher.Checked = false; }
            if (grbMakePaymentCash.Visible) { grbMakePaymentCash.Visible = false; chkMakePaymentCash.Checked = false; }
        }

        private void chkMakePaymentAddToRoom_CheckedChanged(object sender, EventArgs e)
        {
            grbMakePaymentRoomDetails.Visible = true;

            if (grbCardDetails.Visible) { grbCardDetails.Visible = false; chkMakePaymentNewCard.Checked = false; }
            if (grpMakePaymentVoucherNum.Visible) { grpMakePaymentVoucherNum.Visible = false; chkMakePaymentVoucher.Checked = false; }
            if (grbMakePaymentCash.Visible) { grbMakePaymentCash.Visible = false; chkMakePaymentCash.Checked = false; }

            //test
        }

        private void btnMakePaymentConfirm_Click(object sender, EventArgs e)
        {
            string cardType = null;
            string cardName = null;
            string cardNumber = null;
            string cvv = null;
            DateTime expiry = DateTime.Now;
            double Amount = 0;

            int voucherNumber = 0;
            // double voucherAmount = 0;

            bool isCash = false;
            // double cashAmount = 0;

            int roomNo = 0;
            string fullName = null;

            int bookingNo = 0;//change this to the actual booking number

            if (client == null)
            {
                bookingNo = 4;
            }
            else
            {
                bookingNo = client.BookingNumber;
            }
            //card variables
            if (grbCardDetails.Visible)
            {
                try
                {
                    cardType = txtMakePaymentCardType.Text;
                    cardName = txtMakePaymentCardName.Text;
                    cardNumber = txtMakePaymentCardNumber.Text;
                    cvv = txtMakePaymentCvv.Text;
                    expiry = DateTime.Parse(txtMakePaymentExpiryDate.Text);
                    Amount = Convert.ToDouble(txtMakePaymentCardAmount.Text);
                    Model.addNewPayment(-1, cardType, cardName, cardNumber, cvv, expiry, Amount, voucherNumber, isCash, bookingNo);
                    MessageBox.Show("Card Payment confirmed");
                }
                catch (System.Exception excep)
                {
                    MessageBox.Show("Please enter details");
                }

            }
            //voucher variables
            else if (grpMakePaymentVoucherNum.Visible)
            {
                Model.PopulateVoucher();
                List<IVoucher> vList = Model.VoucherList;
                bool voucherFound = false;
                try
                {
                    int voucherNum = Convert.ToInt32(txtMakePaymentVoucherNum.Text);
                    double vamount = Convert.ToDouble(txtMakePaymentVoucherAmount.Text);
               


                foreach (IVoucher voucher in vList)
                {
                    if (voucher.VoucherID.Equals(Convert.ToInt32(txtMakePaymentVoucherNum.Text)))
                    {
                        voucherNumber = Convert.ToInt32(txtMakePaymentVoucherNum.Text);
                        Amount = Convert.ToDouble(txtMakePaymentVoucherAmount.Text);
                        Model.addNewPayment(-1, cardType, cardName, cardNumber, cvv, expiry, Amount, voucherNumber, isCash, bookingNo);
                        MessageBox.Show("Voucher valid Payment confirmed");
                        voucherFound = true;
                        break; // Exit the loop since the voucher was found
                    }
                }

                if (!voucherFound)
                {
                    MessageBox.Show("Please enter a valid voucher number");
                }
                }
                catch (System.Exception excep)
                {

                    MessageBox.Show("Please add details");
                }

            }
            //cash varaiables
            else if (grbMakePaymentCash.Visible)
            {
                try
                {
                    isCash = true;
                    Amount = Convert.ToDouble(txtMakePaymentCashAmount.Text);
                    Model.addNewPayment(-1, cardType, cardName, cardNumber, cvv, expiry, Amount, voucherNumber, isCash, bookingNo);
                    MessageBox.Show("Cash Payment confirmed");
                }
                catch (System.Exception excep)
                {
                    MessageBox.Show("Please add details");
                   
                }
            }
            //room variables
            else
            {
                try
                {
                    roomNo = Convert.ToInt32(txtMakePaymentRoomNumber.Text);
                    fullName = txtMakePaymentName.Text;
                }
                catch (System.Exception excep)
                {
                    MessageBox.Show("Please add details");
                    
                }

            }



            //Model.addNewPayment(-1, cardType, cardName, cardNumber, cvv, expiry, Amount, voucherNumber, isCash, bookingNo);
            ClearFields();
        }//end of function

        private void ClearFields()
        {
            txtMakePaymentCardAmount.Clear();
            txtMakePaymentCardName.Clear();
            txtMakePaymentCardNumber.Clear();
            txtMakePaymentCardType.Clear();
            txtMakePaymentCashAmount.Clear();
            txtMakePaymentCvv.Clear();
            txtMakePaymentExpiryDate.Clear();
            txtMakePaymentName.Clear();
            
            txtMakePaymentRoomNumber.Clear();
            txtMakePaymentVoucherAmount.Clear();
            txtMakePaymentVoucherNum.Clear();

        }

        private void grbCardDetails_Enter(object sender, EventArgs e)
        {

        }
    }
}
