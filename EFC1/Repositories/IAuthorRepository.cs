
namespace EFC1.Reppositories;

public interface IAuthorRepository
{
    //Buscar un autor por id
    Author FindById(int id);

    //Buscar todos
    List<Author> FindAll();

    //filtrar por email
    Author FindByEmail(string email);

    //Filtro autores cuyo salario mayor que
    List<Author> FindAllBySalaryGreaterThanEquals(decimal salary);

    // operaciones CRUD

    //Guardar nuevo autor
    Author Create(Author author);

    //actualizar autor existente
    Author Update(Author author);

    //eliminar autor por id
    bool Remove(int id);
}

