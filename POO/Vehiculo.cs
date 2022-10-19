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
        Velocidad = 0;
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
    //Método sobrecargado: Acelerar que reciba una cantidad y un limite
    public void Acelerar(int cantidad, int limit)
    {
        if (cantidad > 0 && Velocidad + cantidad <= limit)
        {
            Velocidad += cantidad;
        }
        else if (Velocidad + cantidad > limit)
        {
            Velocidad = limit;
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


