using System;
namespace POO;

public class SmartPhone
{

    public int Ram;
    public string Manofacture;
    public int Cores;

    public SmartPhone()
    {
    }

    public SmartPhone(int ram, string manofacture, int cores)
    {
        Ram = ram;
        Manofacture = manofacture;
        Cores = cores;
    }

    public override string ToString()
    {
        return $"Manofacture: {Manofacture}, Ram: {Ram}, Cores: {Cores}";
    }
}

