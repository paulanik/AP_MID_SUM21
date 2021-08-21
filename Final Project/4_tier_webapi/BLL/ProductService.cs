using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEL;
using BLL.MapperConfig;
using DAL;

namespace BLL
{
    public class ProductService
    {
        public static List<ProductDetails> GetAllProducts()
        {
            var data = ProductRepo.GetAllProducts();
            var pDetails = AutoMapper.Mapper.Map<List<Product>, List<ProductDetails>>(data);
            return pDetails;
        }
        public static List<Product_TypeDetails> GetProductTypeDetails()
        {
            var data = ProductRepo.GetProductTypeDetails();
            var ptDetails = AutoMapper.Mapper.Map<List<Product_Type>, List<Product_TypeDetails>>(data);
            return ptDetails;
        }
        public static List<Product_TypeModel> GetAllProductType()
        {
            var data = ProductRepo.GetAllProductType();
            var ptDetails = AutoMapper.Mapper.Map<List<Product_Type>, List<Product_TypeModel>>(data);
            return ptDetails;
        }
        public static List<SellHistory> SellHistory()
        {
            var data = ProductRepo.SellHistory();
            var bDetails = AutoMapper.Mapper.Map<List<Buy_Products>, List<SellHistory>>(data);
            return bDetails;
        }
    }
}
