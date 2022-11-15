

namespace ASPNET2.Controllers;

[ApiController]
[Route("api/books")]
public class BookController
{
    private IBookRepository BookRepo;


    public BookController(IBookRepository bookRepository)
    {
        BookRepo = bookRepository;
    }

    //metodos

    //FindAll
    [HttpGet] //GET api/books
    public List<Book> FindAll()
    {
        return BookRepo.FindAll();
    }
    
    [HttpGet("{id}")]
    public Book FindById(int id)
    {
        return BookRepo.FindById(id);
    }

    [HttpGet("include/{id}")]
    public Book FindByIdWithInclude(int id)
    {
        return BookRepo.FindByIdWhitInclude(id);
    }

    [HttpGet("title/{title}")]
    public List<Book>? FindByTitleContains(string title)
    {
        return BookRepo.FindByTitleContains(title);
    }

    [HttpPost]
    public Book Create(Book book)
    {
        var bookDb =  BookRepo.Create(book);
        return bookDb;
    }

    [HttpPut]
    public Book Update(Book book)
    {
        return BookRepo.Update(book);
    }

    [HttpDelete("{id}")]
    public void DeleteById(int id)
    {
        BookRepo.Remove(id);
    }


}

