using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ProductRepo
    {
        static MFCSEntities context = new MFCSEntities();
        public static List<Product> GetAllProducts()
        {

            var p = context.Products.ToList();
            return p;
        }
        public static List<Product_Type> GetProductTypeDetails()
        {
            return context.Product_Type.ToList();
        }
        public static List<Product_Type> GetAllProductType()
        {
            return context.Product_Type.ToList();
        }
        public static List<Buy_Products> SellHistory()
        {
            return context.Buy_Products.ToList();
        }

    }
}
