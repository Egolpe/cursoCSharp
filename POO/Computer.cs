using System;
namespace POO;

public class Computer
{
    public int Id;
    public string Model;
    public int Ram;

    public Computer()
    {
    }
    public override string ToString()
    {
        return $"Computir: {Id}, Model: {Model}, Ram: {Ram}";
    }
}

