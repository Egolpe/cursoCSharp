using System;
namespace POO;

public class SaludoFormal : ISaludo //implementa la interfaz ISaludo, por tanto está obligada a implementar los metodos que haya
{

    public SaludoFormal()
    {
    }

    public void Saludar()//Define como se hace
    {
        Console.WriteLine("Hello ladies and gentlemen!");
    }

    public void Saludar(string nombre)
    {
        Console.WriteLine("Dear Mrs/Sr " + nombre + ".");
    }
}

