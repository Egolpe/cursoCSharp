
using EFC1.Models;

Console.WriteLine("Hello, World!");

//GuardarUno();
//GuardarMultiple();
//Required();
//ValidacionesTitleMinLength();
//ValidacionesTitleMaxLength();
//FindFirst();
//Find();
Count();

//Métodos con ejemplos ========================================================
void GuardarUno()
{

    AppDbContext context = new AppDbContextFactory().CreateDbContext(null);
    Console.WriteLine("===============Guardar uno===============");
    Book book1 = new Book { Isbn = "1234578R", Title = "book1", ReleaseYear = 1983 , Description = "ñadhfñahdsñfhañdfhñahfñs" };


    context.Books.Add(book1);

    context.SaveChanges();

    Console.WriteLine(book1);

}

void GuardarMultiple()
{
    AppDbContext context = new AppDbContextFactory().CreateDbContext(null);
    Console.WriteLine("================Guardar muchos (lista)=============");
    Book book2 = new Book { Isbn = "245689204Y", Title = "book3", ReleaseYear = 1900, Description = "ñdafñkdshfñaohdsfñha" };
    Book book3 = new Book { Isbn = "24689754T", Title = "book4", ReleaseYear = 1900, Description = "ñdafñkdshfñaohdsfñha" };
    var books = new List<Book> { book2, book3 };

    context.Books.AddRange(books);

    context.SaveChanges();

    Console.WriteLine(book2);
    Console.WriteLine(book3);
}

void ValidacionesTitleMinLength()
{
    Console.WriteLine("================Validaciones=============");

    AppDbContext context = new AppDbContextFactory().CreateDbContext(null);

    Book book = new Book { Title = "hol", Isbn = "fdfnañdfn", ReleaseYear = 1983, Description = "asdcfasdfasfdasfdafasdf" };

    context.Books.Add(book);
    context.SaveChanges();
    Console.WriteLine(book);

}

void ValidacionesTitleMaxLength()
{
    Console.WriteLine("================Validaciones max length=============");

    AppDbContext context = new AppDbContextFactory().CreateDbContext(null);

    Book book4 = new Book { Title = "Hola mundo que tal adios", Isbn = "fdfnañdfn", ReleaseYear = 1983, Description = "asdcfasdfasfdasfdafasdf" };

    context.Books.Add(book4);
    context.SaveChanges();
    Console.WriteLine(book4);
}

void ValidationRequired()
{
    Console.WriteLine("================Required =============");
    AppDbContext context = new AppDbContextFactory().CreateDbContext(null);

    //Book book5 = new Book { Isbn = "238479457H" }; no deja que sea nulo (sin título)
    Book book5 = new Book { Isbn = "238479457H", Title = "book5", ReleaseYear =1785 };
    context.Books.Add(book5);
    context.SaveChanges();
    Console.WriteLine(book5);
}

void FindFirst()
{
    AppDbContext context = new AppDbContextFactory().CreateDbContext(null);
    Console.WriteLine("===============Find First===============");

    var book = context.Books.First();
    Console.WriteLine(book);
}

void Find()
{
    AppDbContext context = new AppDbContextFactory().CreateDbContext(null);
    Console.WriteLine("===============Find===============");

    var book = context.Books.Find(5);
    Console.WriteLine(book);
}

void Count()
{
    AppDbContext context = new AppDbContextFactory().CreateDbContext(null);
    Console.WriteLine("===============Count===============");

    var book = context.Books.Count();
    Console.WriteLine(book);
}

