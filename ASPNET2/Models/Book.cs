using System;


namespace ASPNET2.Models;
[Table("books")]
public class Book
{
    //Atributos
    [Key, Column("id")]
    public int Id { get; set; }

    [Required(ErrorMessage = "Titulo obligatorio"),
     Column("title"),
     MinLength(5, ErrorMessage = "Debe ser mayor de 5 caracteres"),
     MaxLength(50, ErrorMessage = "El titulo debe tener máximo 50 caracteres")]
    public string Title { get; set; }

    [Required,
    Column("isbn_number"),
    MaxLength(50, ErrorMessage = "El isbn debe tener máximo 50 caracteres")]
    public string Isbn { get; set; }

    
    [Column("release_year")]
    public int ReleaseYear { get; set; }

    [Column("description")]
    public string Description { get; set; }

    //Asociacion many books to one author
    //Asociaciones
    public Author Author { get; set; }
    public int? AuthorId { get;  set; }// autor opcional


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

