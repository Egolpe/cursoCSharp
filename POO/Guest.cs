using System;
namespace POO;

public class Guest
{
    //public int Age { get; }
    //public int Age { get; set; }
    private int age; 
    public int Age
    {   //getter que permite obtener el age
        get { return age; }
        set { if (value >= 18)
            {
                age = value;
            }
            else
            {
                age = 18;
            }
        }
    }
    //Hacer que la propiedad sea solo lectura, no permite modificar
    public string Dni { get; }

    public double Salary
    {
        get;
        private set;//solo permite modificar desde dentro de la clase
    }


    public void Promote(double quantity)
    {
        Salary += quantity;
    }


    //Ejemplo de usi de un método privado
    public void Promote()
    {
        double quantity = CalcSalaryPromotion();
        Salary += quantity;
    }
    private double CalcSalaryPromotion()
    {
        return 100.0;
    }

    public Guest()
    {
    }
}

