using System;
namespace Asociaciones.ManyToOne;

// One author to many books(OneToMany)

public class Author
{
    //Atributos
    public long Id;
    public string Name;

    //Asociaciones(OneToMany)
    public List<Book> Books = new List<Book>();//importante incializar la lista para agregar elementos despues


    //constructores
    public Author()
    {
    }

    public override string ToString()
    {
        return $"Author: {Id}, Name: {Name}, Books: {Books.Count}";
    }
}

