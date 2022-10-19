using System;
namespace POO;
//Clase base
//Tipo abstracto: no se pueden crear objetos
public abstract class RoadVehicle
{

    public string Manofacture;
    public int NumRuedas;
    public bool Status;

    public RoadVehicle()
    {
    }

    public void Start()
    {
        Status = true;
    }

    public virtual void Stop()
    {
        Status = false;
    }
}

//Clase car es clase hija/deribada de RoadVehicle
//Extiende a RoadVehicle
public class Car : RoadVehicle
{
    public int NumPuertas;
    public bool RuedaRepuesto;
    public int NumPassengers;
    public int NumPerson;

    public override void Stop()
    {
        base.Stop();//llama a Stop de RoadVehicle.
        NumPerson = 0;
    }
    public Car()
    {
    }
}

public class MotorCycle : RoadVehicle
{
    public bool Copilot;
    public bool Naked;

    public MotorCycle()
    { 
    }
}

public class Truck : RoadVehicle
{
    public bool Trailer;
    public int TrailerCapacity;

    public Truck()
    {

    }

}

public class ElectricCar : Car
{
    public int BatteryCapacity;

    public ElectricCar()
    {
      
    }
}

public class CombustionCar : Car
{
    public int TankCapacity;
    public double Emission;

    public CombustionCar()
    {
     
    }
}

public class hybridCar : Car
{
    public int BatteryCapacity;
    public int TankCapacity;
    public double Emission;

    public hybridCar()
    {
      
    }
}
