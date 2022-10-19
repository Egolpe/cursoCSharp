using System;
namespace POO;

public class Customer
{

    public string Dni;
    public string Email;
    public Address Address;
    public RoadVehicle Vehicle;//Polimorfismo
    public List<RoadVehicle> PersonalVehicles;//Polimorfismo

    public Customer()
    {
    }
}

