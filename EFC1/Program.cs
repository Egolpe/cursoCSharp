
using EFC1.Models;

Console.WriteLine("Hello, World!");

GuardarUno();
//GuardarMultiple();
//Required();
//ValidacionesTitle();

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
    Book book3 = new Book { Isbn = "245689204Y", Title = "book3" };
    Book book4 = new Book { Isbn = "24689754T", Title = "book4" };
    var books = new List<Book> { book3, book4 };

    context.Books.AddRange(books);

    context.SaveChanges();

    Console.WriteLine(book3);
    Console.WriteLine(book4);
}

void ValidacionesTitle()
{
    Console.WriteLine("================Validaciones=============");

    AppDbContext context = new AppDbContextFactory().CreateDbContext(null);

    Book book = new Book { Title = "hol", Isbn = "fdfnañdfn", ReleaseYear = 1983, Description = "asdcfasdfasfdasfdafasdf" };

    context.Books.Add(book);
    context.SaveChanges();
    Console.WriteLine(book);

}

void Required()
{
    Console.WriteLine("================Required =============");
    AppDbContext context = new AppDbContextFactory().CreateDbContext(null);

    //Book book5 = new Book { Isbn = "238479457H" }; no deja que sea nulo (sin título)
    Book book5 = new Book { Isbn = "238479457H", Title = "" };
    context.Books.Add(book5);
    context.SaveChanges();
    Console.WriteLine(book5);
}