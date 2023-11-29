using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class ProductLine : BusinessEntities.IProductLine
    {
        private int productLineCode;
        private int orderCode;
        private string productCode;
        private int qtyRequired;
        private int qtyPrepared;
        private bool complete;

        public ProductLine(int productLineCode, int orderCode, string productCode, int qtyRequired, int qtyPrepared, bool complete)
        {
            this.productLineCode = productLineCode;
            this.orderCode = orderCode;
            this.productCode = productCode;
            this.qtyRequired = qtyRequired;
            this.qtyPrepared = qtyPrepared;
            this.complete = complete;
        }

        public int ProductLineCode
        {
            get
            {
                return productLineCode;
            }
            //set
            //{
            //}
        }

        public int OrderCode
        {
            get
            {
                return orderCode;
            }
            //set
            //{
            //}
        }

        public string ProductCode
        {
            get
            {
                return productCode;
            }
            //set
            //{
            //}
        }

        public int QtyRequired
        {
            get
            {
                return qtyRequired;
            }
            //set
            //{
            //}
        }

        public int QtyPrepared
        {
            get
            {
                return qtyPrepared;
            }
            set
            {
                qtyPrepared = value;
            }
        }

        public bool Complete
        {
            get
            {
                return complete;
            }
            set
            {
                complete = value;
            }
        }
    }
}
