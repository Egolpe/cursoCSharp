
namespace ASPNET2.Repositories;

public interface ICategoryRepository
{
    //buscar por id
    Category FindById(int id);

    //Buscar todos
    List<Category> FindAll();

    List<Category> FindByMinAge(int age);

    //guardar
    Category Create(Category category);
   
    //borrar por id
    bool Remove(int id);
}

