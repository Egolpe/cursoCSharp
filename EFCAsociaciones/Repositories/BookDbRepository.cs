
using EFCAsociaciones.Models;

namespace EFCAsociaciones.Repositories;

public class BookDbRepository : IBookRepository
{

    //Atributos
    private AppDbContext Context;
    //constructores
    public BookDbRepository(AppDbContext context)
    {
        Context = context;
    }

    public BookDbRepository()
    {
    }

    public Book Create(Book book)
    {
        if (book.Id > 0)
        {
            return Update(book);
        }

        
        Context.Books.Add(book);// un libro puede tener author y categories
        Context.SaveChanges();
        return book;
    }

    public List<Book> FindAll()
    {
        return Context.Books.ToList();
    }

    public Book FindById(int id)
    {
        return Context.Books.Find(id);
    }

    public Book FindByIdWhitInclude(int id)
    {
        return Context.Books
            .Include(book => book.Categories) //incluir objetos Category
            .Where(book => book.Id == id)
            .FirstOrDefault();
    }

    public List<Book> FindByTitleContains(string title)
    {
        return Context.Books
        .Where(book => book.Title.ToLower()
        .Contains(title.ToLower()))
        .ToList();
    }

    public bool Remove(int id)
    {
        Book book = FindById(id);
        if (book == null)
        {
            return false;
        }
        Context.Books.Remove(book);// un libro puede tener author y categories
        Context.SaveChanges();
        return true;
    }
        

    public Book Update(Book book)
    {
        if (book.Id == 0)
        {
            return Create(book);
        }
        //Guardar solo aquellos atributos que interesen 
        Context.Books.Attach(book);

        Context.Entry(book).Property(b => b.Title).IsModified = true;
        Context.Entry(book).Property(b => b.AuthorId).IsModified = true;



        Context.SaveChanges();
        return FindById(book.Id);
    }
}


