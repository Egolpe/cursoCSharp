
Console.WriteLine("Hello, World!");

AppDbContext context = new AppDbContextFactory().CreateDbContext(null);

Console.WriteLine("===============Guardar uno===============");
Book book1 = new Book { Isbn = "1234578R", Title = "book1" };
Book book2 = new Book { Isbn = "1357908T", Title = "book2" };

context.Books.Add(book1);
context.Books.Add(book2);

context.SaveChanges();

Console.WriteLine(book1);
Console.WriteLine(book2);

Console.WriteLine("================Guardar muchos (lista)=============");
Book book3 = new Book { Isbn = "245689204Y", Title = "book3" };
Book book4 = new Book { Isbn = "24689754T", Title = "book4" };
var books = new List<Book> { book3, book4 };

context.Books.AddRange(books);

context.SaveChanges();

Console.WriteLine(book3);
Console.WriteLine(book4);