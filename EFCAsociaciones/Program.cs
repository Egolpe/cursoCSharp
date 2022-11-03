
//1. Crear objeto AppDbContext
using EFCAsociaciones.Repositories;

AppDbContext context = new AppDbContextFactory().CreateDbContext(null);
//Repositorios
IAuthorRepository authorRepo = new AuthorDbRepository(context);
IBookRepository bookRepo = new BookDbRepository(context);
IAddressRepository addressRepo = new AddressDbRepository(context);
ICategoryRepository categoryRepo = new CategoryDbRepository(context);


//3. Crear objetos Model: asociar - Desasociar
//Address
var address1 = new Address { Street = "calle1", City = "madrid" };
var address2 = new Address { Street = "calle2", City = "pamplona" };

//Category
var cat1 = new Category { Name = "cat1", MinAge = 18 };
var cat2 = new Category { Name = "cat2", MinAge = 16 };
var cat3 = new Category { Name = "cat3", MinAge = 13 };

//Author
var author1 = new Author { FullName = "a1", Email = "a1@email.com", Salary = 1999.0m, BirthDate = DateTime.Now};
var author2 = new Author { FullName = "a2", Email = "a2@email.com", Salary = 2100.0m, BirthDate = DateTime.Now };
var author3 = new Author { FullName = "a3", Email = "a3@email.com", Salary = 1599.0m, BirthDate = DateTime.Now };
var author4 = new Author { FullName = "a4", Email = "a4@email.com", Salary = 1799.0m, BirthDate = DateTime.Now };

//Book
var book1 = new Book { Title = "b1", Description = "b1", ReleaseYear = 1987, Isbn = "aksjdhf" };
var book2 = new Book { Title = "b2", Description = "b2", ReleaseYear = 2001, Isbn = "aksjdhf" };
var book3 = new Book { Title = "b3", Description = "b3", ReleaseYear = 1999, Isbn = "aksjdhf" };
var book4 = new Book { Title = "b4", Description = "b4", ReleaseYear = 2014, Isbn = "aksjdhf" };


//4 Probar operaciones CRUD contra base de datos
// Asociaciones
author1.Address = address1;
author2.Address = address2;

book1.Author = author1;
book2.Author = author1;
book3.Author = author2;
book4.Author = author3;

book1.Categories = new List<Category> { cat1, cat2, cat3 };
book2.Categories = new List<Category> { cat1 };
book3.Categories = new List<Category> { cat1, cat2 };
book4.Categories = new List<Category> { cat1, cat3 };

//Guardar todos los objetos en base de datos
addressRepo.Create(address1);
addressRepo.Create(address2);

categoryRepo.Create(cat1);
categoryRepo.Create(cat2);
categoryRepo.Create(cat3);

authorRepo.Create(author1);
authorRepo.Create(author2);
authorRepo.Create(author3);


bookRepo.Create(book1);
bookRepo.Create(book2);
bookRepo.Create(book3);
bookRepo.Create(book4);

//Actualizar


var book1ToUpdate = new Book { Id = 1, Title = "modificado", Isbn = "modificado", ReleaseYear = 1999, AuthorId = 2 };
bookRepo.Update(book1ToUpdate);
//DEsasociar relacion de book con author
book1ToUpdate.AuthorId = null;
bookRepo.Update(book1ToUpdate);
/*
//Desasociar/ actualizar una relacion de books con categories
book1ToUpdate = bookRepo.FindById(1); // busca con categorias

book1ToUpdate.Categories.Clear();
bookRepo.Update(book1ToUpdate);
*/

//Borrar


//5 Hacer operaciones CRUD con asociaciones








/*

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

Console.WriteLine("=====================One to Many=============");

// autor -> books (One to many)

//author1 = context.Authors.Find(1);
//foreach(Book book in author1.Books)
//{
//    Console.WriteLine(book.Title);
//}

//var booksFromAuthor = context.Books.Where(b => b.AuthorId == 1).ToList();
//foreach (Book book in author1.Books)
//{
//    Console.WriteLine(book.Title);
//}



Console.WriteLine("=====================Many to One=============");

//books -> author (Many To One)
Book book1 = new Book { Title = "book1", Description = "fdfsfafv", Isbn = "dfafaf", ReleaseYear = 1999, Author = author1 };
Book book2 = new Book { Title = "book2", Description = "fdfsfafv", Isbn = "dfafaf", ReleaseYear = 2001, Author = author1 };

context.Books.Add(book1);
context.Books.Add(book2);
context.SaveChanges();
Book book1FromDataBase = context.Books.Find(1);
Console.WriteLine(book1FromDataBase);

Console.WriteLine("=====================Many to Many=============");

//book -> Categories (Many to Many)

Book book3 = new Book { Title = "book3", Description = "fdfsfafv", Isbn = "dfafaf", ReleaseYear = 1999, Author = author1};
Book book4 = new Book { Title = "book4", Description = "fdfsfafv", Isbn = "dfafaf", ReleaseYear = 2001, Author = author1 };
Book book5 = new Book { Title = "book5", Description = "fdfsfafv", Isbn = "dfafaf", ReleaseYear = 1999, Author = author1 };
Book book6 = new Book { Title = "book6", Description = "fdfsfafv", Isbn = "dfafaf", ReleaseYear = 2001, Author = author1 };

var category1 = new Category { Name = "c1", MinAge = 18 };
var category2 = new Category { Name = "c2", MinAge = 13 };
var category3 = new Category { Name = "c3", MinAge = 16 };
var category4 = new Category { Name = "c4", MinAge = 16 };

//Asociar a categories
book3.Categories = new List<Category> { category1, category3 };
book4.Categories = new List<Category> { category2 };
book5.Categories = new List<Category> { category1, category2, category4 };
book6.Categories = new List<Category> { category1, category4 };

//Guardar en base de datos
context.Books.Add(book3);
context.Books.Add(book4);
context.Books.Add(book5);
context.Books.Add(book6);
context.SaveChanges();

//recuperar los objetos de la base de datos

Category categoryFromDb = context.Categories.Find(1);

Book book6FromDb = context.Books.Find(1);

Console.WriteLine(book6FromDb.Title);

// find book 6 include categories

var book6FromDb2 = context.Books
    .Include(b => b.Categories)
    .Where(b => b.Id == 6)
    .First();
Console.WriteLine(book6FromDb2);
*/