using System;
namespace BusinessEntities
{
    public interface IProductLine
    {
        bool Complete { get; set; }
        int OrderCode { get; }
        string ProductCode { get; }
        int ProductLineCode { get; }
        int QtyPrepared { get; }
        int QtyRequired { get; }
    }
}
