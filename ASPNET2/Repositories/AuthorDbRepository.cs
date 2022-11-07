
namespace ASPNET2.Reppositories;

public class AuthorDbRepository : IAuthorRepository
{
    //Atributos
    private AppDbContext Context;
    //constructores
    public AuthorDbRepository(AppDbContext context)
    {
        Context = context;
    }


    //metodos
    public Author FindById(int id)
    {
        return Context.Authors.Find(id);
    }

    public List<Author> FindAll()
    {
        return Context.Authors.ToList();
    }

    public List<Author> FindAllBySalaryGreaterThanEquals(decimal salary)
    {
        return Context.Authors
            .Where(author => Decimal.Compare(author.Salary, salary) >= 0)
            .ToList();
    }

    public Author FindByEmail(string email)
    {
        return Context.Authors
            .Where(author => author.Email.ToLower().Equals(email.ToLower()))
            .First();
    }

    public Author Create(Author author)
    {
        //Si tiene un id asignado es un update y no creamos
        if(author.Id > 0)
        {
            return Update(author);
        }

        Context.Authors.Add(author);
        Context.SaveChanges();
        return author;
    }

    public Author Update(Author author)
    {
        if(author.Id == 0)
        {
            return Create(author);
        }

        Author authorFromDb = FindById(author.Id);
        authorFromDb.Email = author.Email;
        authorFromDb.FullName = author.FullName;
        authorFromDb.Salary = author.Salary;
        Context.Authors.Update(author);
        Context.SaveChanges();
        return authorFromDb;


    }

    public bool RemoveById(int id)
    {
        Author author = FindById(id);
        if(author == null)
        {
            return false;
        }
        Context.Authors.Remove(author);
        Context.SaveChanges();
        return true;
    }
}

