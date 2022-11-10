
namespace ASPNET2.Reppositories;

public class AuthorDbRepository : IAuthorRepository
{
    //Atributos
    private AppDbContext Context;
    private IBookRepository BookRepo;
    //constructores
    public AuthorDbRepository(AppDbContext context, IBookRepository BookRepository)
    {
        Context = context;
        BookRepo = BookRepository;
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
        authorFromDb.AddressId = author.AddressId;

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

        List<Book> books = BookRepo.FindByAuthorId(id);
        foreach (Book book in books)
        {
            book.AuthorId = null; // desasociar
            BookRepo.Update(book); // actualizar en base de datos
        }


        Context.Authors.Remove(author);
        Context.SaveChanges();
        return true;
    }

    private void FindByAuthorId(int id)
    {
        throw new NotImplementedException();
    }

    public List<Author> FindAllBySalaryRange(decimal minSalary, decimal maxSalary)
    {
        return Context.Authors.Where(author =>
            author.Salary >= minSalary && author.Salary <= maxSalary
        ).ToList();
    }
}

