using System;

namespace BusinessEntities
{
    public interface IPayment
    {
        int PaymentID { get; set; }
        string CardType { get; set; }
        string CardName { get; set; }

        string CardNumber { get; set; }
        string CVv { get; set; }

        DateTime ExpiryDate { get; set; }

        double Amount { get; set; }
        int VoucherNumber { get; set; }
        bool IsCash { get; set; }

        int BookingNo { get; set; }

        void PrintPaymentDetails();

        string[] GetPaymentLines();

    }
}
