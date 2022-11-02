using System;


namespace EFCAsociaciones.Models;

public class Book
{
    //Atributos
    
    public int Id { get; set; }

    public string Title { get; set; }

    public string Isbn { get; set; }

    public int ReleaseYear { get; set; }

    public string Description { get; set; }

    //Asociacion many books to one author
    //Asociaciones
    public Author Author { get; set; }
    public int AuthorId { get;  set; }


    //Asociaciones Many to many con category
    public IList<Category> Categories { get; set; }
    //Constructores
    public Book()
    {
    }



    //métodos

    //ToString
    public override string ToString()
    {
        return $"Book: {Id}, Title: {Title}, Isbn: {Isbn}, ReleaseYear: {ReleaseYear}, Description: {Description}";
    }
}

