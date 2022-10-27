using System;
using System.Drawing;
using System.Xml.Linq;

namespace Asociaciones.ManyToMany;

//Many films to many Categories

public class Film
{
    public long Id;
    public string Title;
    public int Duration;

    //Asociaciones
    public List<Category> Categories = new List<Category>();

    public Film()
    {
    }

    public override string ToString()
    {
        return $"Film: {Id}, Title: {Title}, Duration: {Duration}, Categories: {Categories.Count}";
    }
}

