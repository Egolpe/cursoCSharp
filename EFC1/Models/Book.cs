using System;


namespace EFC1.Models;

public class Book
{
    //Atributos
    [Key]
    public int Id { get; set; }
    public string Title { get; set; }
    public string Isbn { get; set; }

    //Constructores
    public Book()
    {
    }

    //métodos

    //ToString
    public override string ToString()
    {
        return $"Book: {Id}, Title: {Title}, Isbn: {Isbn}";
    }
}

