
Console.WriteLine("Hello, World!");

AppDbContext context = new AppDbContextFactory().CreateDbContext(null);

Book book1 = new Book { Isbn = "1234578R", Title = "book1" };
Book book2 = new Book { Isbn = "1357908T", Title = "book2" };

context.Books.Add(book1);
context.Books.Add(book2);

context.SaveChanges();

Console.WriteLine(book1);
Console.WriteLine(book2);