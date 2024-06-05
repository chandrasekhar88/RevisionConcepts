using ModelBiding.Models;
using System.Collections.Generic;

namespace ModelBiding.Repositories
{
    public class ProductRepository : IProductRepository
    {
        List<ProductModel> products = new List<ProductModel>();
        public int AddProduct(ProductModel product)
        {
            product.id = products.Count + 1;
            products.Add(product);

            return product.id;
        }

        public List<ProductModel> GetAllProducts()
        {
            return products;
        }

        public string GetName()
        {
            return "Name from Product Repository";
        }
    }
}
