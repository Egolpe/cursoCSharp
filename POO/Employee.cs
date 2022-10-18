using System;
namespace POO;

public class Employee
{
    //1.atributos
    public string Dni;
    public string Name;
    public int Age;
    public double Salary;
    public bool Married;

    //2. constructor
    public Employee(string dni, string name, int age, double salary, bool married)
    {
        Console.WriteLine("Employee constructor 1");
        Dni = dni;
        Name = name;
        Age = age;
        Salary = salary;
        Married = married;
    }

    public Employee(string dni, string name)
    {
        Console.WriteLine("Employee constructor 2");
        Dni = dni;
        Name = name;
    }

    public Employee(string Dni, string Name, double Salary)
    {
        Console.WriteLine("Employee constructor 2");
        this.Dni = Dni;
        this.Name = Name;
        this.Salary = Salary;
    }

    public Employee() { }
    
}

