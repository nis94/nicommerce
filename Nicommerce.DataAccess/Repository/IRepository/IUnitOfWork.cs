using System;

namespace Nicommerce.DataAccess.Repository.IRepository;

public interface IUnitOfWork
{
    ICategoryRepository Category { get; }
    
    void Save();
}
