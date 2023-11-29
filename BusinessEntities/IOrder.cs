using System;
using System.Collections.Generic;
namespace BusinessEntities
{
    public interface IOrder
    {
        int AgentCode { get; }
        bool Complete { get; set; }
        int CustomerCode { get; }
        int OrderCode { get; }
        DateTime OrderDate { get; set; }
        List<IProductLine> ProductLineList { get; }
    }
}
