using System;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace BusinessEntities
{
    public class Payment : BusinessEntities.IPayment
    {
        private int paymentID;
        private string cardType;
        private string cardName;
        private string cardNumber;
        private string cvv;
        private DateTime expiryDate;
        private double amount;
        private int voucherNumber;
        private bool isCash;
        private int bookingNo;

        public Payment(int paymentID, string cardType, string cardName, string cardNumber, string cvv, DateTime expiryDate, double amount, int voucherNumber, bool isCash, int bookingNo)
        {
            this.paymentID = paymentID;
            this.cardType = cardType;
            this.cardName = cardName;
            this.cardNumber = cardNumber;
            this.cvv = cvv;
            this.expiryDate = expiryDate;
            this.amount = amount;
            this.voucherNumber = voucherNumber;
            this.isCash = isCash;
            this.bookingNo = bookingNo;
        }

        public int PaymentID
        {
            get { return paymentID; }
            set { paymentID = value; }
        }
        public string CardType
        {
            get { return cardType; }
            set { cardType = value; }
        }
        public string CardName
        {
            get { return cardName; }
            set { cardName = value; }
        }
        public string CardNumber
        {
            get { return cardNumber; }
            set
            {
                cardNumber = value;
            }
        }
        public string CVv
        {
            get { return cvv; }
            set
            {
                cvv = value;
            }
        }

        public DateTime ExpiryDate
        {
            get { return expiryDate; }
            set
            {
                expiryDate = value;
            }
        }
        public double Amount
        {
            get { return amount; }
            set
            {
                amount = value;
            }
        }
        public int VoucherNumber
        {
            get { return voucherNumber; }
            set
            {
                voucherNumber = value;
            }
        }
        public bool IsCash
        {
            get { return isCash; }
            set
            {
                isCash = value;
            }
        }
        public int BookingNo
        {
            get { return bookingNo; }
            set { bookingNo = value; }
        }
        public void PrintPaymentDetails()
        {
            string properties = GetType().GetProperties()
                .Select(info => (info.Name, Value: info.GetValue(this, null) ?? "(null)"))
                .Aggregate(
                    new StringBuilder(),
                    (sb, pair) => sb.AppendLine($"{pair.Name}: {pair.Value}"),
                    sb => sb.ToString());
            Debug.WriteLine(properties);
        }

        public string[] GetPaymentLines()
        {
            string[] properties = GetType().GetProperties()
                .Select(p => p.Name + ": " + p.GetValue(this) ?? "").ToArray();

            return properties;
        }


    }
}
