using System;
namespace EFCAsociaciones.Models;
[Table("categories")]
public class Category
{
    [Key, Column("id")]
    public int Id { get; set; }
    [Column("name")]
    public string Name { get; set; }
    [Column("min_age")]
    public int MinAge { get; set; }

    //Asociaciones Many to many con book
    public IList<Book> Books { get; set; }

    public Category()
    {
    }

    
}

