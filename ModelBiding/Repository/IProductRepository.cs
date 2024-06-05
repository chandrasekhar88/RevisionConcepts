using ModelBiding.Models;
using System.Collections.Generic;

namespace ModelBiding.Repositories
{
    public interface IProductRepository
    {
        int AddProduct(ProductModel product);
        List<ProductModel> GetAllProducts();
        string GetName();
    }
}