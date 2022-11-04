using System;
using Microsoft.AspNetCore.Mvc;

namespace ASPNET1.Controllers;


[ApiController]
[Route("api/books")]
public class BookController
{
    private List<Book> books;


    public BookController()
    {
        books = new List<Book>
        {
            new Book { Id = 1, Title = "El Quijote", Price = 19.99f},
            new Book { Id = 2, Title = "El poder del ahora", Price = 29.99f},
            new Book { Id = 3, Title = "una sola cosa", Price = 39.99f}

        };
    }

    [HttpGet("test")]
    public string Test()
    {
        return "Don Quijote de la Mancha";
    }

    //FindAll
    [HttpGet] //GET api/books
    public List<Book> FindAll()
    {
        return books;
    }
    //FindById
    [HttpGet("{id}")] //GET api/books/1
    public Book FindById(int id)
    {
        foreach(Book book in books)
        {
            if (book.Id == id)
            {
                return book;
            }
        }
        return null;
    }

    //Create
    [HttpPost] //POST api/books
    public Book Create(Book book)
    {
        book.Price = book.Price * 1.21f;
        books.Add(book);
        return book;
    }


    //UPdate
    [HttpPut] //PUT api/books
    public Book Update(Book book)
    {
        book.Price = book.Price * 1.21f;
        //Comprobar si existe
        //Modificar
        //Sustituir el original por el editado
        books.Add(book);
        return book;
    }


    //Delete
    [HttpDelete("{id}")] //DELETE api/books/1
    public void DeleteById(int id)
    {
        for (int i = 0; i< books.Count; i++)
        {
            if (books[i].Id == id)
            {
                books.RemoveAt(i);
            }
        }
    }

}

