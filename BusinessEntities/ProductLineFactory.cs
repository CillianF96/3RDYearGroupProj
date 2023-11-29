using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public static class ProductLineFactory // Only concern of factory is to create objects. 
    {
        private static IProductLine ProductLine = null;

        public static IProductLine GetProductLine(int productLineCode, int orderCode, string productCode, int qtyRequired, int qtyPrepared, bool complete)
        {
            if (ProductLine != null)  // ie is Factory is primed with an object. 
                return ProductLine;
            else
                return new ProductLine(productLineCode, orderCode, productCode, qtyRequired, qtyPrepared, complete); // Factory produces a regular ProductLine (for production code) 
        }
        public static void SetProductLine(IProductLine aProductLine)   // This provides a seam in the factory where I can prime the factory with the ProductLine it will then produce. (for test code) 
        {
            ProductLine = aProductLine;
        }
    }
}
