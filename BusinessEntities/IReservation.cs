using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public interface IReservation
    {
        int BookingNumber { get; set; }

        DateTime Date { get; set; }

        TimeSpan Time { get; set; }

        string CreditCardNumber { get; set; }

        double Bill { get; set; }

        Boolean CheckedIn {  get; set; }

        Person Person { get; set; }

    }
}
