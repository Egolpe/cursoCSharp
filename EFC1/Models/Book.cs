using System;


namespace EFC1.Models;
[Table("books")]
public class Book
{
    //Atributos
    [Key, Column("id")]
    public int Id { get; set; }

    [Required(ErrorMessage = "Titulo obligatorio"),
     Column("title"),
     MinLength(5, ErrorMessage = "Debe ser mayor de 5 caracteres"),
     MaxLength(15, ErrorMessage = "El titulo debe tener máximo 15 caracteres")]
    public string Title { get; set; }

    [Required,
     Column("isbn_number"),
     MaxLength(50, ErrorMessage = "El isbn debe tener máximo 50 caracteres")]
    public string Isbn { get; set; }

    [Required,
     Column("release_year")]
    public int ReleaseYear { get; set; }

    [Column("description")]
    public string Description { get; set; }

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

