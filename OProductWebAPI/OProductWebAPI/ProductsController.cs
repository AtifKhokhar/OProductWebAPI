using System;
using System.Web.Http;

namespace OProductWebAPI
{
    public class ProductsController : ApiController
    {
        public ProductModel Get()
        {
            return ReturnProductModel();
        }

        private ProductModel ReturnProductModel()
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 100);
            return new ProductModel
            {
                prodId = randomNumber,
                productName = "Elwood 3301 Jeans",
                productDescription = "Tapered Fit",
                productBrand = "G-Star Raw"
            };
        }
    }
}
