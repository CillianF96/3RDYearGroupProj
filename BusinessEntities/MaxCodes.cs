using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class MaxCodes
    {
        private int productLineCode;
        private int orderCode;

        public int ProductLineCode
        {
            get
            {
                return productLineCode;
            }
            set
            {
                productLineCode = value;
            }
        }

        public int OrderCode
        {
            get
            {
                return orderCode;
            }
            set
            {
                orderCode = value;
            }
        }
    }
}
