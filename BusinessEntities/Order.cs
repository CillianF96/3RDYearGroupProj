using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class Order : BusinessEntities.IOrder
    {
        private int orderCode;
        private int agentCode;
        private bool complete;
        private int customerCode;
        private DateTime orderDate;

 
        private List<IProductLine> productLineList;

     
        public Order(int orderCode, int agentCode, int customerCode, bool complete, DateTime orderDate)
        {
            this.orderCode = orderCode;
            this.agentCode = agentCode;
            this.customerCode = customerCode;
            this.complete = complete;
            this.orderDate = orderDate;
            this.productLineList = new List<IProductLine>();
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

        public int AgentCode
        {
            get
            {
                return agentCode;
            }
            //set
            //{
            //}
        }

        public int CustomerCode
        {
            get
            {
                return customerCode;
            }
            //set
            //{
            //}
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
        public DateTime OrderDate
        {
            get { return orderDate; }
            set { orderDate = value; }
        }

        public List<IProductLine> ProductLineList
        {
            get
            {
                return productLineList;
            }
            set
            {
                productLineList = value;
            }
        }
    }
}
