using POO;

// Crear una variable
string nombre = "Alan";

// Crear objeto a partir de una clase
Employee employee  = new Employee("684748494J", "empleado1", 30, 3000.0, false);
Employee employee1 = new Employee("938493847T", "empleado2", 28, 2900.0, true);

Console.WriteLine(employee1.Name);
Console.WriteLine(employee.Name);

//Operaciones aritméticas
Console.WriteLine(employee.Salary + employee1.Salary);
var media = (employee.Salary + employee1.Salary) / 2;
Console.WriteLine(media);

Employee employee2 = new Employee("11111111G", "empleado3");
Employee employee3 = new Employee("22222222G", "empleado4");
Console.WriteLine(employee2.Name);
Console.WriteLine(employee3.Name);

Employee employee4 = new Employee("333333333T", "empleado5", 3100.0);
Console.WriteLine(employee4.Salary);

//Constructor vacio
Employee employee5 = new Employee();
employee5.Name = "empleado6";
employee5.Age = 30;
Console.WriteLine(employee5.Name);
Console.WriteLine(employee5.Age);

//Constructor dinámico (Requiere un constructor vacio)
//Se pueden pasar los parámetros que se quiera y en el orden que se quiera
Employee employee6 = new Employee
{
    Age = 30,
    Dni = "77766655G"
};

Employee employee7 = new Employee
{
    Age = 30,
    Dni = "77766655G",
    Married = false
};

//Ejemplo con Vehicle
Vehiculo vehiculo = new Vehiculo();
vehiculo.Manofacture = "Seat";
vehiculo.Model = "Ibiza";

Vehiculo vehiculo1 = new Vehiculo { Manofacture = "Seat", Model = "Ibiza" };
Vehiculo vehiculo2 = new Vehiculo { Manofacture = "ford" };
Vehiculo vehiculo3 = new Vehiculo { Model = "focus" };
Vehiculo Vehiculo4 = new Vehiculo { Model = "focus", CubicCentimeters = 1.2 };

//Métodos de vehivulo
Console.WriteLine(vehiculo.Status);//False
vehiculo.Start();//invoca un método que realiza una acción
Console.WriteLine(vehiculo.Status);//true
vehiculo.Stop();
Console.WriteLine(vehiculo.Status);//false

Console.WriteLine(vehiculo.Velocidad);
vehiculo.Acelerar(50);
Console.WriteLine(vehiculo.Velocidad);
Console.WriteLine("introduce la cantida a acelerar: ");
int cantidad = int.Parse(Console.ReadLine());
vehiculo.Acelerar(cantidad);
Console.WriteLine(vehiculo.Velocidad);
Console.WriteLine("introduce la cantida a frenar: ");
int cantidad1 = int.Parse(Console.ReadLine());
vehiculo.Frenar(cantidad1);
Console.WriteLine(vehiculo.Velocidad);
