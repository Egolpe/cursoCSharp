

//Repositorios ======================================================
using EFC1.Models;

AppDbContext context = new AppDbContextFactory().CreateDbContext(null);
IAuthorRepository authorRepo = new AuthorDbRepository(context);

Console.WriteLine("=================== FindById =================");

var author1 = authorRepo.FindById(1);
Console.WriteLine(author1);

Console.WriteLine("=================== FindAll =================");
var authors = authorRepo.FindAll();
foreach (Author author in authors)
    Console.WriteLine(author);

Console.WriteLine("=================== FindByEmail =================");
    string email = "author1@email.com";
try
{
    Author authorByEmail = authorRepo.FindByEmail(email);
    Console.WriteLine(authorByEmail);

}catch (Exception e )
{
    Console.WriteLine("No se ha encontrado el author con email: " + email);
}

Console.WriteLine("=================== FindAllBySalaryGreaterThanEquals =================");

decimal salary = 1500;

    List<Author> authorsSalaries = authorRepo.FindAllBySalaryGreaterThanEquals(salary);
    foreach (Author author in authorsSalaries)
        Console.WriteLine(author);

Console.WriteLine("=================== Create =================");

Author authorToCreate = new Author {
    FullName = "author1",
    Email = "author1@email.com",
    Salary = 1500.0m,
    BirthDate = new DateTime(1988, 1, 1)
};

var authorCreated = authorRepo.Create(authorToCreate);
Console.WriteLine(authorCreated);

Console.WriteLine("=================== Update =================");

author1 = authorRepo.FindById(1);
author1.Email = "author1edited@smail.com";
author1.FullName = "author1 editado";
author1.Salary = 5000;
author1.BirthDate = new DateTime(1978, 1, 1);//no se debe de cambiar en base de datos

var authorUpdated = authorRepo.Update(author1);

Console.WriteLine(authorUpdated);

Console.WriteLine("=================== Remove =================");


bool removed = authorRepo.Remove(2);
Console.WriteLine(removed);


// MÉTODOS CON EJEMPLOS =========================================
// Metodo1_Add();
// Metodo2_AddRange();
// Metodo3_ValidacionTitle_MinLength();
// Metodo4_ValidacionTitle_MaxLength();
// Metodo5_Validacion_Required();
// Metodo6_First();
// Metodo7_Find();
// Metodo8_Count();
// Metodo9_Update();
// Metodo10_Update_2();
// Metodo11_UpdateRange();
// Metodo12_Remove();
// Metodo13_RemoveRange();
// Metodo14_FindByTitle();
void Metodo1_Add()
{
    Console.WriteLine("=================== Guardar uno =================");
    AppDbContext context = new AppDbContextFactory().CreateDbContext(null);

    Book book1 = new Book { Isbn = "1111111", Title = "book1", ReleaseYear = 1900, Description = "dfsfsdfsdfdfsdfdsf" };

    context.Books.Add(book1);

    context.SaveChanges();

    Console.WriteLine(book1);
}

void Metodo2_AddRange()
{
    Console.WriteLine("=================== Guardar muchos =================");
    AppDbContext context = new AppDbContextFactory().CreateDbContext(null);

    Book book1 = new Book { Isbn = "1111111", Title = "book1", ReleaseYear = 1900, Description = "dfsfsdfsdfdfsdfdsf" };
    Book book2 = new Book { Isbn = "1111111", Title = "book2", ReleaseYear = 1900, Description = "dfsfsdfsdfdfsdfdsf" };

    var books = new List<Book> { book1, book2 };

    context.Books.AddRange(books);

    context.SaveChanges();

    Console.WriteLine(book1);
    Console.WriteLine(book2);
}

void Metodo3_ValidacionTitle_MinLength()
{
    Console.WriteLine("=================== Validaciones Title =================");
    AppDbContext context = new AppDbContextFactory().CreateDbContext(null);

    Book book = new Book { Title = "hol", Isbn = "sdfsfdgsdfgfdsg", ReleaseYear = 1900, Description = "sdfsfdsdfdsfadf" };

    context.Books.Add(book);

    context.SaveChanges();

    Console.WriteLine(book);
}

void Metodo4_ValidacionTitle_MaxLength()
{
    Console.WriteLine("=================== Validaciones Title =================");
    AppDbContext context = new AppDbContextFactory().CreateDbContext(null);

    Book book = new Book { Title = "hola mundo que tal adios", Isbn = "sdfsfdgsdfgfdsg", ReleaseYear = 1900, Description = "sdfsfdsdfdsfadf" };

    context.Books.Add(book);

    context.SaveChanges();

    Console.WriteLine(book);
}

void Metodo5_Validacion_Required()
{
    Console.WriteLine("=================== Validaciones Title =================");
    AppDbContext context = new AppDbContextFactory().CreateDbContext(null);

    Book book = new Book { Title = "hola mundo", Isbn = "sdfsfdgsdfgfdsg", ReleaseYear = 1900 };

    context.Books.Add(book);

    context.SaveChanges();

    Console.WriteLine(book);
}

void Metodo6_First()
{
    Console.WriteLine("=================== First =================");
    AppDbContext context = new AppDbContextFactory().CreateDbContext(null);

    Book book = context.Books.First();

    Console.WriteLine(book);
}

void Metodo7_Find()
{
    Console.WriteLine("=================== Find =================");
    AppDbContext context = new AppDbContextFactory().CreateDbContext(null);

    Book book = context.Books.Find(2);

    Console.WriteLine(book);
}

void Metodo8_Count()
{
    Console.WriteLine("=================== Count =================");
    AppDbContext context = new AppDbContextFactory().CreateDbContext(null);

    int totalBooks = context.Books.Count();

    Console.WriteLine(totalBooks);
}

void Metodo9_Update()
{

    Console.WriteLine("=================== Update =================");

    AppDbContext context = new AppDbContextFactory().CreateDbContext(null);

    Book book = context.Books.Find(1);
    book.Description = "libro modificado otra vez";

    // MySqlConnector.MySqlException (0x80004005): Duplicate entry '1' for key 'books.PRIMARY'
    // context.Books.Add(book); 

    context.Books.Update(book);

    context.SaveChanges();

    book = context.Books.Find(1);
    Console.WriteLine(book);

}

void Metodo10_Update_2()
{

    Console.WriteLine("=================== Update =================");
    // En lugar de obtenerlo con Find lo creamos manualmente
    Book book = new Book { Id = 1, Title = "book1 cambiado", Isbn = "dfgdfd", ReleaseYear = 2000, Description = "modified" };

    AppDbContext context = new AppDbContextFactory().CreateDbContext(null);

    context.Books.Update(book);

    context.SaveChanges();

    book = context.Books.Find(1);
    Console.WriteLine(book);
}

void Metodo11_UpdateRange()
{

    Console.WriteLine("=================== Update =================");

    AppDbContext context = new AppDbContextFactory().CreateDbContext(null);

    // modificar 2 libros y guardarlos en base de datos
    Book book1 = new Book { Id = 1, Title = "prueba1", Isbn = "dfgdfd", ReleaseYear = 3000, Description = "modified" };
    Book book2 = new Book { Id = 2, Title = "prueba2", Isbn = "dfgdfd", ReleaseYear = 4000, Description = "modified" };
    var books = new List<Book> { book1, book2 };

    context.Books.UpdateRange(books);

    context.SaveChanges();

    // Comprobar que se guardaron los cambios
    Book book = context.Books.Find(1);
    Console.WriteLine(book);
    book = context.Books.Find(2);
    Console.WriteLine(book);
}

void Metodo12_Remove()
{

    Console.WriteLine("=================== Remove =================");

    AppDbContext context = new AppDbContextFactory().CreateDbContext(null);

    int before = context.Books.Count();

    Book book = context.Books.Find(1);
    if (book == null) return;

    context.Books.Remove(book);

    context.SaveChanges();

    int after = context.Books.Count();

    if (after == before - 1) Console.WriteLine("Se ha borrado 1 libro");
}

void Metodo13_RemoveRange()
{

    Console.WriteLine("=================== Remove Range =================");

    AppDbContext context = new AppDbContextFactory().CreateDbContext(null);

    int before = context.Books.Count();

    Book book1 = new Book { Id = 3, Title = "prueba1", Isbn = "dfgdfd", ReleaseYear = 3000, Description = "modified" };
    Book book2 = new Book { Id = 4, Title = "prueba2", Isbn = "dfgdfd", ReleaseYear = 4000, Description = "modified" };
    var books = new List<Book> { book1, book2 };

    context.Books.RemoveRange(books);

    context.SaveChanges();

    int after = context.Books.Count();

    if (after == before - 2) Console.WriteLine("Se han borrado 2 libros");
}

void Metodo14_FindByTitle()
{
    Console.WriteLine("=================== Find By Title =================");

    AppDbContext context = new AppDbContextFactory().CreateDbContext(null);

    List<Book> books = context.Books
        .Where(book => book.Title.ToLower().Equals("book1"))
        .ToList();

    foreach (Book book in books) Console.WriteLine(book);

    /*
    Book filteredBook = context.Books
    .Where(book => book.Title.ToLower().Equals("Don Quijote"))
    .First();

    var books2 = from book in context.Books 
                 where book.Title.ToLower().Equals("Don Quijote") 
                 select book;
    */
}

