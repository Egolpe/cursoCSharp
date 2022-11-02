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

var book6FromDb2 = context.Books.Include(b => b.Categories).Where(b => b.Id == 6).First();
Console.WriteLine(book6FromDb2);