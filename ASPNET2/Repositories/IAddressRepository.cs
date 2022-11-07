
namespace ASPNET2.Repositories;

public interface ICategoryRepository
{
    
    Category FindById(int id);

    List<Category> FindAll();
    Category Create(Category category);
    
    bool RemoveById(int id);
}

