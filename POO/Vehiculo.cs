using System;
namespace POO;

public class Vehiculo
{
    // Atributos
    public string Manofacture;
    public string Model;
    public double CubicCentimeters;
    public bool Status; //true encendido, false apagado

    //Constructor vacio
    public Vehiculo()
    {

    }

    //Métodos
    public void Start()
    {
        Status = true;
    }

    public void Stop()
    {
        Status = false;
    }
}

