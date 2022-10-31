using System;
namespace EFC1.Models;

[Table("authors")]
public class Author
{
    [Key, Column("id", Order = 0)]
    public int Id { get; set; }

    [Column("full_name", TypeName = "varchar(75)", Order = 2) ]
    public string FullName { get; set; }

    [Column("email", TypeName = "varchar(100)", Order = 1)]
    public string Email { get; set; }

    [Column("salary"), Precision(14,2)]
    public decimal Salary { get; set; }

    [Column("birth_date")]
    public DateTime BirthDate { get; set; }

    //Constructor
    public Author()
    {
    }

    //metodos


    //ToString
    public override string ToString()
    {
        return $"Author: {Id}, FullName: {FullName}, Email: {Email}, Salary: {Salary}, BirthDate: {BirthDate}";
    }
}

