using ModelBiding.Models;
using ModelBiding.Repositories;
using System.Collections.Generic;

namespace Day26Concepts.Repository
{
    public class TestRepository : IProductRepository
    {
        public int AddProduct(ProductModel product)
        {
            throw new System.NotImplementedException();
        }

        public List<ProductModel> GetAllProducts()
        {
            throw new System.NotImplementedException();
        }

        public string GetName()
        {
            return "Name from Test Repository";
        }
    }
}
