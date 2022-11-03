
using EFCAsociaciones.Models;

namespace EFCAsociaciones.Repositories;

public class CategoryDbRepository : ICategoryRepository
{
    private AppDbContext Context;
    //constructores
    public CategoryDbRepository(AppDbContext context)
    {
        Context = context;
    }

    public CategoryDbRepository()
    {
    }

    public Category Create(Category category)
    {
        Context.Categories.Add(category);// un libro puede tener author y categories
        Context.SaveChanges();
        return category;
    }

    public List<Category> FindAll()
    {
        return Context.Categories.ToList();
    }

    public Category FindById(int id)
    {
        return Context.Categories.Find(id);
    }

    public bool Remove(int id)
    {
        Category category = FindById(id);
        if (category == null)
        {
            return false;
        }
        Context.Categories.Remove(category);// un libro puede tener author y categories
        Context.SaveChanges();
        return true;
    }

   
}

