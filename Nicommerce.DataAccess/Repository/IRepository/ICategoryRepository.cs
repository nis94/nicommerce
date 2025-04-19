using System;
using Nicommerce.Models;

namespace Nicommerce.DataAccess.Repository.IRepository;

public interface ICategoryRepository : IRepository<Category>
{
    void Update(Category obj);
}
