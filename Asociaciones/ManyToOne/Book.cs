using System;
using System.Xml.Linq;

namespace Asociaciones.ManyToOne;

//Many books to One author (ManyToOne)

public class Book
{
    //Atributos
    public long Id;
    public string Title;
   

    //Asociaciones
    public Author Author;//ManyToOne 

    //constructores
    public Book()
    {
    }

    public override string ToString()
    {
        return $"Customer: {Id}, Title: {Title}, Author: {Author.Name}";
    }
}

