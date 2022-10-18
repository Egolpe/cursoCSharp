using System;
namespace POO;


//Clase que representa empleados
public class Employee
{
    //1.atributos: información del empleado 
    public string Dni;
    public string Name;
    public int Age;
    public double Salary;
    public bool Married;

    //2. constructor: método especial que permite construir objetos empleado
    public Employee(string dni, string name, int age, double salary, bool married)
    {
        Console.WriteLine("Employee constructor 1");
        Dni = dni;
        Name = name;
        Age = age;
        Salary = salary;
        Married = married;
    }
    //constructor sobrecargado: permite duplicar métodos variando los parametros
    public Employee(string dni, string name)
    {
        Console.WriteLine("Employee constructor 2");
        Dni = dni;
        Name = name;
    }
    //constructor sobrecargado
    public Employee(string Dni, string Name, double Salary)
    {
        Console.WriteLine("Employee constructor 2");
        this.Dni = Dni;
        this.Name = Name;
        this.Salary = Salary;
    }
    //constructor sobrecargado
    public Employee() { }
    
}

