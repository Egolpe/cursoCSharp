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

//Acelera por primera vez
Console.WriteLine(vehiculo.Velocidad);//0
vehiculo.Acelerar(50);
Console.WriteLine(vehiculo.Velocidad);//50

//Acelerar por segunda vez
Console.WriteLine("introduce la cantida a acelerar: ");
int cantidad = int.Parse(Console.ReadLine());
vehiculo.Acelerar(cantidad);
Console.WriteLine(vehiculo.Velocidad);

//Acelerar con sobrecarga
Vehiculo ferrari = new Vehiculo();
ferrari.Start();
ferrari.Acelerar(130);

ferrari.Stop();
ferrari.Start();
ferrari.Acelerar(130, 200);

vehiculo.Acelerar(50, 120);
Console.WriteLine(vehiculo.Velocidad);
//Frenar por primera vez
vehiculo.Frenar(50);
Console.WriteLine(vehiculo.Velocidad);


//Frenar por segunda vez
Console.WriteLine("introduce la cantida a frenar: ");
int cantidad1 = int.Parse(Console.ReadLine());
vehiculo.Frenar(cantidad1);
Console.WriteLine(vehiculo.Velocidad);


Persona persona = new Persona();
persona.Saludar();
persona.Saludar("Juan");


//método toString
SmartPhone movil = new SmartPhone {
    Manofacture = "Samsung",
    Cores = 4,
    Ram = 8
};
Console.WriteLine(movil);

SmartPhone movil1 = new SmartPhone
{
    Manofacture = "One Pluse",
    Cores = 8,
    Ram = 16
};
Console.WriteLine(movil1);

//Encapsulacion(getter setter)
//get sirve para obtener/leer un atributo
//set sirve para modificar el valor de un atributo

Guest invitado = new Guest();
invitado.Age = -20;
Console.WriteLine(invitado.Age);
//invitado.Dni="777888999Y";
//invitado.Salary = 10.0;
Console.WriteLine(invitado.Salary);
invitado.Promote(200.0);
Console.WriteLine(invitado.Salary);
//invitado.Salary = 200.0;

//Promote sobrecargado
invitado.Promote();
Console.WriteLine(invitado.Salary);
//invitado.CalcSalaryPromotion();

//Asociación entre clases

Address address1 = new Address {
    street = "calle falsa 123",
    PostalCode = "44666",
    City = "Madrid",
    Country = "Spain"
};
Customer customer = new Customer {
    Dni = "77788899Y",
    Email = "cust1@company.com",
    Address = address1
};

//calle del cliente
Console.WriteLine(customer.Address.street);

// Herencias:

Car car = new Car();
car.Manofacture = "Ford";//heredada
car.NumRuedas   = 4;//heredada

car.NumPuertas  = 3;//específica de car
car.RuedaRepuesto = false;//específica de car
car.NumPassengers = 3;//específica de car

car.Start(); //heredado

MotorCycle moto = new MotorCycle();
moto.Manofacture = "Kawasaki"; //heredada
moto.NumRuedas = 2;//heredada
moto.Copilot = true; //especifica de MotorCycle
moto.Naked = false;//especifica de MotorCycle


Truck truck = new Truck();
truck.Manofacture = "volvo";//heredada
truck.NumRuedas = 12;//heredada
truck.Trailer = true;
truck.TrailerCapacity = 5;

//Clase abstracta
//se aplica normalmente a la clase base de una herencia
//con el objetivo de que no se instancie
//y obligar a que se instancie una de la clases hijas

/* RoadVehicle veh1 = new RoadVehicle();
truck.Manufacturer = "Honda"; 
truck.NumRuedas = 4; */

ElectricCar electric1 = new ElectricCar();
electric1.Manofacture = "Alfa";//heredada de RoadVehicle
electric1.NumRuedas = 4;//heredada de RoadVehicle

electric1.NumPuertas = 5;//heredada de car
electric1.RuedaRepuesto = true;//heredada de car
electric1.NumPassengers = 5;//heredada de car

electric1.BatteryCapacity = 50000;// específica

CombustionCar combustion1 = new CombustionCar();
combustion1.Manofacture = "Alfa";//heredada de RoadVehicle
combustion1.NumRuedas = 4;//heredada de RoadVehicle

combustion1.NumPuertas = 5;//heredada de car
combustion1.RuedaRepuesto = true;//heredada de car
combustion1.NumPassengers = 5;//heredada de car

combustion1.TankCapacity = 120;// específica
combustion1.Emission = 30.5;// específica

//Override en herencia

Car alfaRomeo = new Car();
alfaRomeo.NumPerson = 3;
alfaRomeo.Start();
Console.WriteLine(alfaRomeo.Status + " " + alfaRomeo.NumPerson);

alfaRomeo.Stop();
Console.WriteLine(alfaRomeo.Status + " " + alfaRomeo.NumPerson);

//porlimorfismo

Customer client = new Customer {
    Dni = "77788899Y",
    Vehicle = electric1 //polimorfismo
};
client.Vehicle.Start();


DoSomething(truck);
DoSomething(moto);


void DoSomething(RoadVehicle vehicle) //Polimorfismo
{
    vehicle.Start();
    vehicle.Stop();
}

var vehicles = new List<RoadVehicle>
{
    new MotorCycle { Copilot = true},
    new ElectricCar { BatteryCapacity = 30000}
};

Customer client2 = new Customer
{
    Dni = "44455566T",
    PersonalVehicles = vehicles //Polimorfismo
};

Console.WriteLine("Num de vehiculos de client2: " + client2.PersonalVehicles.Count());