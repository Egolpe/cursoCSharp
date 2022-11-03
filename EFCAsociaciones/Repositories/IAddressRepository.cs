
namespace EFCAsociaciones.Repositories;

public interface ICategoryRepository
{
    
    Category FindById(int id);

    List<Category> FindAll();
    Category Create(Category category);
    
    bool Remove(int id);
}

