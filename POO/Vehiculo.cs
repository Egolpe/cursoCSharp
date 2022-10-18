using System;
namespace POO;

public class Vehiculo
{
    // Atributos (definen un estado)
    public string Manofacture;
    public string Model;
    public double CubicCentimeters;
    public bool Status; //true encendido, false apagado
    public int Velocidad; //true encendido, false apagado

    //Constructor vacio (permite crear nuevos objetos tantos como quieras)
    public Vehiculo()
    {

    }

    //Métodos (definen comportamiento)
    public void Start()
    {
        Status = true;
    }

    public void Stop()
    {
        Status = false;
    }
    public void Acelerar(int cantidad)
    {
        
        if (cantidad > 0 && Velocidad + cantidad <= 120)
        {
            Velocidad += cantidad;
        } else if (Velocidad + cantidad > 120)
        {
            Velocidad = 120;
        }
    }
    public void Frenar(int cantidad)
    {
        
        if (cantidad > 0 && Velocidad - cantidad >= 0)
        {
            Velocidad -= cantidad;
        }else if ( Velocidad - cantidad < 0)
        {
            Velocidad = 0;
        }
    }
}

