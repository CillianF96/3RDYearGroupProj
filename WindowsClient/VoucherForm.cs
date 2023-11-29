using BusinessLayer;
using System;
using System.Reflection;
using System.Windows.Forms;

namespace ProductTracking
{
    public partial class VoucherForm : Form
    {
        IModel Model;
        public VoucherForm(IModel _model)
        {
            InitializeComponent();
            Model = _model;
        }

        private void btnVoucherFormCancel_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void btnVoucherFormGenerate_Click(object sender, System.EventArgs e)
        {
            if(txtVoucherName.Text == "" || txtVoucherFormVoucherAmount.Text == "" || cmbVoucherFormVoucherType.Text == "" || RtbVoucherFormVoucherMessage.Text == "")
            {
                MessageBox.Show("Please enter voucher information");
            }
            else
            {
                string name = txtVoucherName.Text;
                int amount = Convert.ToInt32(txtVoucherFormVoucherAmount.Text);
                string type = cmbVoucherFormVoucherType.Text;
                string message = RtbVoucherFormVoucherMessage.Text;
                Model.addNewVoucher(amount, name, type, message);
                MessageBox.Show("Voucher has been Created");
                this.Close();
            }
            
        }

        private void btnVoucherPrint_Click(object sender, EventArgs e)
        {
            
            PrintVoucher voucher = new PrintVoucher(Model);
            voucher.ShowDialog();
        }



    }
}
