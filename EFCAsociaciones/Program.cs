Console.WriteLine("=====================One to one=============");

AppDbContext context = new AppDbContextFactory().CreateDbContext(null);
IAuthorRepository authorRepo = new AuthorDbRepository(context);

Address address1 = new Address { City = "Madrid", Street = "CAlle Falsa" };
Author author1 = new Author
{
    Email = "author1@email.com",
    FullName = "Autor 1",
    Salary = 1000,
    BirthDate = DateTime.Now,
    Address = address1//Asociacion One to One
};

var authorCreated = authorRepo.Create(author1);//Se guarda tambien la asociacion en base de datos
Console.WriteLine(authorCreated);

Console.WriteLine("=====================One to Many y Many to One=============");

// autor -> books (One to many)

//books -> author (Many To One)

Console.WriteLine("=====================Many to Many=============");

//book -> Categories (Many to Many)

//Category -> books (MAny to Many)