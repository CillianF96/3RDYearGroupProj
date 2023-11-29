using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public static class VoucherFactory
    {
        private static Voucher voucher = null;

        public static Voucher GetVoucher(int voucherID, double amount, string name, string type, string message)
        {
            if (voucher != null)  // ie is Factory is primed with an object. 
                return voucher;
            else
                return new Voucher(voucherID, amount, name, type, message);
        }
        public static void SetVoucher(Voucher aVoucher)   // This provides a seam in the factory where I can prime the factory with the voucher it will then cough up. (for test code) 
        {
            voucher = aVoucher;
        }

    }
}
