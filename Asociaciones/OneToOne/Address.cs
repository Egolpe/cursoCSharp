using System;
using System.Reflection;
using System.Runtime.Intrinsics.Arm;

namespace Asociaciones.OneToOne;

public class Address
{

    //Atributos
    public long Id;
    public string Street;
    public string City;

    //asociaciones
    public Customer Customer;//bidireccional opcional

    //constructores
    public Address()
    {
    }

    //métodos


    //ToString
    public override string ToString()
    {
        return $"Address: {Id}, street: {Street}, city: {City}";
    }
}

