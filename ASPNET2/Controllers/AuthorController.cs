using System;
using ASPNET2.Reppositories;

namespace ASPNET2.Controllers;
[ApiController]
[Route("api/authors")]
public class AuthorController
{
    private IAuthorRepository AuthorRepo;


    public AuthorController(IAuthorRepository AuthorRepository)
    {
        AuthorRepo = AuthorRepository;
    }
    [HttpGet]
    public List<Author> FindAll()
    {
        return AuthorRepo.FindAll();
    }

    [HttpGet("{id}")]
    public Author FindById(int id)
    {
        return AuthorRepo.FindById(id);
    }

    [HttpGet("email/{email}")]
    public Author FindByEmail(string email)
    {
        return AuthorRepo.FindByEmail(email);
    }

    [HttpGet("salary/min/{min}/max/{max}")]
    public List<Author> FindBySalaryRange(decimal min, decimal max)
    {
        return AuthorRepo.FindAllBySalaryRange(min, max);
    }

    [HttpPost]
    public Author Create(Author author)
    {
        var authorDb = AuthorRepo.Create(author);
        return authorDb;
    }

    [HttpPut]
    public Author Update(Author author)
    {
        return AuthorRepo.Update(author);
    }

    [HttpDelete("{id}")]
    public void DeleteById(int id)
    {
        AuthorRepo.RemoveById(id);
    }


}

