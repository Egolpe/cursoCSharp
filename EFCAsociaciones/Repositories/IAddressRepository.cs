
namespace EFCAsociaciones.Repositories;

public interface IBookRepository
{
    //buscar por id
    Book FindById(int id);

    // buscar por id incluyendo asociaciones: Author , Category
    Book FindByIdWhitInclude(int id);

    //buscar por Title que contenga el texto
    List<Book> FindByTitleContains(string title);

    //Buscar todos
    List<Book> FindAll();

    //guardar
    Book Create(Book book);
    //actualizar  restringiendo campos
    Book Update(Book book);
    //borrar por id
    bool Remove(int id);
}

