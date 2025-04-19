using System;
using Nicommerce.Models;

namespace Nicommerce.DataAccess.Repository.IRepository;

public interface IProductRepository : IRepository<Product>
{
    void Update(Product obj);
}
