using Asociaciones.ManyToMany;
using Asociaciones.ManyToOne;
using Asociaciones.OneToOne;

Console.WriteLine("==============OneToOne============");

Address address = new Address { Id = 1, Street = "calle", City = "Madrid" };
Customer customer = new Customer
{
    Id = 1,
    Name = "Enrique",
    Age = 30,
    Address = address 
};

Console.WriteLine(address);
Console.WriteLine(customer);


Console.WriteLine("==============OneToMane y ManyToOne============");


Author author1 = new Author { Id = 1, Name = "Author 1"};

Book book1 = new Book { Id = 1, Title = "Book 1", Author = author1 };
Book book2 = new Book { Id = 2, Title = "Book 2", Author = author1 };
Book book3 = new Book { Id = 3, Title = "Book 3", Author = author1 };

//author1.Books = new List<Book> { book1, book2, book3 };

/*author1.Books.Add(book1);
author1.Books.Add(book2);
author1.Books.Add(book3);*/
author1.Books.AddRange(new List<Book> { book1, book2, book3 });

Console.WriteLine(author1);
Console.WriteLine(book1);
Console.WriteLine(book2);
Console.WriteLine(book3);


Console.WriteLine("==============ManyToMany============");

//Crear categorias
Category category1 = new Category { Id = 1, Name = "action", Color = "red" };
Category category2 = new Category { Id = 2, Name = "comedia", Color = "blue"  };
Category category3 = new Category { Id = 3, Name = "drama", Color = "gray"  };
Category category4 = new Category { Id = 4, Name = "terror", Color = "black" };

//crear peliculas
Film film1 = new Film { Id = 1, Title = "Another day", Duration = 145 };
Film film2 = new Film { Id = 2, Title = "Another day1", Duration = 122 };
Film film3 = new Film { Id = 3, Title = "Another day2", Duration = 135 };
Film film4 = new Film { Id = 4, Title = "Another day3", Duration = 170 };

//Asociacion
film1.Categories.Add(category1);
film1.Categories.Add(category4);

film2.Categories.Add(category2);
film2.Categories.Add(category3);

category1.Films.Add(film1);
category4.Films.Add(film1);

category2.Films.Add(film2);
category3.Films.Add(film2);


Console.WriteLine(film1);
Console.WriteLine(film2);
Console.WriteLine(film3);
Console.WriteLine(film4);
Console.WriteLine(category1);
Console.WriteLine(category2);