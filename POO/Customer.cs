using System;
namespace POO;

public class Customer
{

    public string Dni;
    public string Email;
    public ISaludo Saludo;
    public Address Address;
    public RoadVehicle Vehicle;//Polimorfismo
    public List<RoadVehicle> PersonalVehicles = new List<RoadVehicle>();//Polimorfismo

    public Customer()
    {
    }

    public void Saludar()
    {
        Saludo.Saludar();
    }
}

