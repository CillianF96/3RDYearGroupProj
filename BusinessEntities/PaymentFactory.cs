using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class PaymentFactory
    {
        private static IPayment payment = null;

        public static IPayment GetPayment(int paymentID, string cardType, string cardName, string cardNumber, string Cvv, DateTime expiryDate, double amount, int voucherNumber, bool isCash, int bookingNo)
        {
            if (payment != null)  // ie is Factory is primed with an object. 
                return payment;
            else
                return new Payment(paymentID, cardType, cardName, cardNumber, Cvv, expiryDate, amount, voucherNumber, isCash, bookingNo);
        }
        public static void SetPayment(IPayment aPayment)   // This provides a seam in the factory where I can prime the factory with the person it will then cough up. (for test code) 
        {
            payment = aPayment;
        }
    }
}
