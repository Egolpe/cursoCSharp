using System;
namespace POO;

public class SaludoInformal :ISaludo
{
    public SaludoInformal()
    {
    }

    public void Saludar()
    {
        Console.WriteLine("whats up guys!!!");
    }

    public void Saludar(string nombre)
    {
        Console.WriteLine("whats up " + nombre);
    }
}

