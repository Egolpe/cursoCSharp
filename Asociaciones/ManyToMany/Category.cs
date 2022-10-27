using System;
namespace Asociaciones.ManyToMany;

//Many categories to many films

public class Category
{
    public long Id;
    public string Name;
    public string Color;

    //Asociaciones
    public List<Film> Films = new List<Film>();

    public Category()
    {
    }

    public override string ToString()
    {
        return $"Category: {Id}, Name: {Name}, Color: {Color}, Films: {Films.Count}";
    }
}

