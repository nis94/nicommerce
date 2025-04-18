using System;
using System.Linq.Expressions;
using Nicommerce.DataAccess.Data;
using Nicommerce.DataAccess.Repository.IRepository;
using Nicommerce.Models;

namespace Nicommerce.DataAccess.Repository;

public class CategoryRepository : Repository<Category>, ICategoryRepository
{
    private readonly ApplicationDbContext _db;
    public CategoryRepository(ApplicationDbContext db) : base(db)
    {
        _db = db;
    }

    public void Update(Category obj)
    {
        _db.Categories.Update(obj);
    }
}
