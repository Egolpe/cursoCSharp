using System;
using System.Reflection;
using System.Runtime.Intrinsics.Arm;

namespace Asociaciones.OneToOne;

public class Customer
{
    //Atributos
    public long Id;
    public string Name;
    public int Age;


    //Asociaciones
    public Address Address; //dos clientes no pueden tener el mismo address identicas 

    //Constructores
    public Customer()
    {
    }

    //métodos

    //ToString
    public override string ToString()
    {
        return $"Customer: {Id}, Name: {Name}, Age: {Age}";
    }
}

