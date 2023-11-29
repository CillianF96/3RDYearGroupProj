using System.Linq;
using System.Text;

namespace BusinessEntities
{
    public class Voucher : IVoucher
    {
        private int voucherID;

        private double amount;

        private string name;

        private string type;

        private string message;

        public Voucher() { }

        public Voucher(int voucherID, double amount, string name, string type, string message)
        {
            this.voucherID = voucherID;
            this.amount = amount;
            this.name = name;
            this.type = type;
            this.message = message;
        }

        public int VoucherID
        {
            get { return voucherID; }
            set { voucherID = value; }
        }

        public double Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public string Message
        {
            get { return message; }
            set { message = value; }
        }

        public string GetVoucher()
        {
            return "Guest: " + VoucherID + " " + Amount + " " + Name + " " + Type + " " + Message;
        }

        public string PrintVoucherDetails()
        {
            string properties = GetType().GetProperties()
                .Select(info => (info.Name, Value: info.GetValue(this, null) ?? "(null)"))
                .Aggregate(
                    new StringBuilder(),
                    (sb, pair) => sb.AppendLine($"{pair.Name}: {pair.Value}"),
                    sb => sb.ToString());
            return properties;
        }
    }
}
