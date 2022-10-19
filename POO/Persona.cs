using System;
namespace POO;

public class Persona
{
    public Persona()
    {
    }
    public void Saludar()
    {
        Console.WriteLine("hola");
    }

    public void Saludar(string nombre)
    {
        Console.WriteLine("hola " + nombre);
    }

    public void Saludar(double edad)
    {
        Console.WriteLine("Hola mi edad es" + edad);
    }

    public void Despedida()
    {

    }
}

