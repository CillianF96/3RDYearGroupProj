using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public static class OrderFactory // Only concern of factory is to create objects. 
    {
        private static IOrder Order = null;

        public static IOrder GetOrder(int orderCode, int agentCode, int customerCode, bool complete, DateTime orderDate)
        {
            if (Order != null)  // ie is Factory is primed with an object. 
                return Order;
            else
                return new Order(orderCode, agentCode, customerCode, complete, orderDate); // Factory produces a regular Order (for production code) 
        }
        public static void SetOrder(IOrder aOrder)   // This provides a seam in the factory where I can prime the factory with the Order it will then produce. (for test code) 
        {
            Order = aOrder;
        }
    }
}
