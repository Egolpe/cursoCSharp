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

//Address - Country - Language

Language idioma1 = new Language { Nombre = "Castellano", Latin= true, Year = 1900 };
Language idioma2 = new Language { Nombre = "Gallego", Latin= true, Year = 1300};
Language idioma3 = new Language { Nombre = "Vasco", Latin = false, Year = 1600 };

// 1. Crear varios objetos Language

//opcion  1
var languages = new List<Language> { idioma1, idioma2, idioma3 };

//opcion 2
/*var languages = new List<Kanguage>();
Language.Add(idioma1);
Language.Add(idioma2);
Language.Add(idioma3);*/

// 2. Crear un objeto Country con varios Language

Country country1 = new Country
{
    Capital = "Madrid",
    Nombre = "España",
    Pib = 1.2,
    Población = 470000000,
    TieneCosta = true,
    UE = true,
    Languages = languages
};
//Opción 2
Country country2 = new Country
{
    Capital = "Alemania",
    Nombre = "Berlin",
    Pib = 1.2,
    Población = 470000000,
    TieneCosta = true,
    UE = true,
};
//country2.Languages.AddRange(languages);
country2.Languages.Add(idioma1);
country2.Languages.Add(idioma2);
country2.Languages.Add(idioma3);

// 3. Crear objeto Address con un Country

Address addressMadrid = new Address
{
    country = country1,
    City = "Madrid",
    PostalCode = "44477",
    street = "calle"

};

// 4. Crear un objeto Customer con un Address

Customer client1 = new Customer
{
    Address = addressMadrid,
    Dni = "77788899T",
    Email = "cust1@sdsd.com",
};

// 5. A partir del objeto Customer imprimir qué lenguajes habla con un bucle for
if(client1.Address.country.Languages == null)
{
    Console.WriteLine("Lista de idiomas sin inicializar");
}

Console.WriteLine("El cliente habla los siguientes idiomas: ");
foreach (Language idioma in client1.Address.country.Languages)
{
    Console.WriteLine(idioma.Nombre);
}

//Interfaces

ISaludo saludo1 = new SaludoFormal();//Polimorfismo en interfaz
Customer rodolfo = new Customer { Saludo = saludo1 };
rodolfo.Saludo.Saludar();
rodolfo.Saludo.Saludar("Enrique");
rodolfo.Saludar();

ISaludo saludo2 = new SaludoInformal();//Polimorfismo en interfaz
rodolfo.Saludo = saludo2;
rodolfo.Saludo.Saludar();
rodolfo.Saludo.Saludar("Enrique");
rodolfo.Saludar();


Customer mike = new Customer { Saludo = saludo2 };


// 1. Crear clase Computer
// 2. Crear una interface IComputerRepository con operaciones CRUD sobre una lista de Computer
// 3. Crear una implementación de la interface
// 4. Utilizar los métodos desde Program.cs

IComputerRepository computerRepo = new ComputerListRepositoryImpl();
var computers = computerRepo.findAll();
Console.WriteLine(computers.Count());
var computer1 = computerRepo.findbyId(2);
Console.WriteLine(computer1.Ram);


var computers2 = computerRepo.FindAllByRam(8, 64);
var computers3 = computerRepo.FindAllByRam(16, 128);

var computer4 = computerRepo.FindAllByModel("Mackbook Pro");
Console.WriteLine(computer4);


//Comprobar que Save añade un nuevo ordenador:

//Caso 1: añadir un ordenador que si se guarda

//Crear un computer
Computer computer5 = new Computer
{
    Id =4, Model= "DELL", Ram = 16
};
//llamar al metodo save
int beforeSave = computerRepo.Count();
bool saved = computerRepo.Save(computer5);
int afterSave = computerRepo.Count();
//comprobar si se guardó
if (saved)
{
    Console.WriteLine("Se ha guarddado correctamente el ordenador 5");
}else
{
    Console.WriteLine("no se ha podido guardar porque ya existe");
}
//Comprobar los que habia antes de añadir y los que hay después de añadir  y verificar que hay más
if (afterSave - beforeSave == 1)
{
    Console.WriteLine("Efectivamente la lista de computers se incremento en 1.");
}

//===========================================================//


//Caso 2: añadir un ordenador que no se guarda porque ya existe
//Crear un ordenador con el mismo Id que otro ordenador que ya existe en la lista
var comp1 = new Computer
{
    Id = 1,
    Model = "Macbook Pro",
    Ram = 16
};

//Intentar guarddar el ordenador en la lista de ordenadores
beforeSave = computerRepo.Count();
saved = computerRepo.Save(comp1);
afterSave = computerRepo.Count();
//comprobar que no se ha guardado nada
if (!saved) Console.WriteLine("Efectivamente no se ha guardado comp1");

if(afterSave == beforeSave)
{
    Console.WriteLine("No Se guardo");
}

//SaveAll =================================================
Console.WriteLine("======SaveAll============ caso 1");
//Caso 1: insertar 3 ordenadores completamente nuevos, el resultado devuelve 3
Computer pcA = new Computer
{
    Id = 5,
    Model = "firulais",
    Ram = 2
};
Computer pcB = new Computer
{
    Id = 6,
    Model = "firulais2",
    Ram = 16
};
Computer pcC = new Computer
{
    Id = 7,
    Model = "firulais3",
    Ram = 32
};
var pcsToAdd = new List<Computer> { pcA, pcB, pcC };
int savedNum =computerRepo.SaveAll(pcsToAdd);


if(savedNum == 3)
{
    Console.WriteLine("Se han guardado tres ordenadores nuevos");
}





Console.WriteLine("======SaveAll============ caso 2");

//Caso 2: insertar 4 ordenadores 2 nuevos y 2 que ya existen y debe devolver 2.
//2 nuevos
Computer pc1 = new Computer
{
    Id = 8,
    Model = "firulais",
    Ram = 2
};
Computer pc2 = new Computer
{
    Id = 9,
    Model = "firulais2",
    Ram = 16
};

//2 que ya existen
Computer pc3 = new Computer
{
    Id = 7,
    Model = "firulais3",
    Ram = 32
};
Computer pc4 = new Computer
{
    Id = 5,
    Model = "firulais",
    Ram = 2
};

pcsToAdd = new List<Computer> { pc1, pc2, pc3, pc4 };
savedNum = computerRepo.SaveAll(pcsToAdd);

if (savedNum == 2)
{
    Console.WriteLine("Se han guardado 2 ordenadores nuevos");
}


//=======================================================
//==================PRINTALL=============================

computerRepo.PrintAll();


//========================================================
//====================UPDATE==============================

Console.WriteLine("======UPDate============");
//1.Tener un ordenador con los atributos modificados, menos el Id
var computer1Modified = new Computer { Id = 1, Ram = 32, Model = "mackBook Pro modificado" };

//invocar el metodo update
var isModified = computerRepo.update(computer1Modified);
//Comprobar que el objeto ordenador con ID 1 ha sido modificado
if(isModified)
{
    Console.WriteLine("Se ha modificado el ordenador con el id1");
}

var computer1FromList = computerRepo.findbyId(1);

if (computer1FromList.Model.Equals("MackBook Pro modificado") && computer1FromList.Ram == 32)
{
    Console.WriteLine("Se han modificado los atributos del ordenador con Id 1");
}


/*Console.WriteLine("======DELETEBYID============");
var beforeDelete = computerRepo.Count();
bool isDeleted = computerRepo.DeleteById(2);
var afterDelete = computerRepo.Count();
if (isDeleted)
{
    Console.WriteLine("Se ha borrado correctamente");
}

if (afterSave == beforeDelete -1)
{
    Console.WriteLine("Correcto se ha eliminado correctamente");
}*/

/*Console.WriteLine("======DELETEBYIDS============");
var ids = new List<int> { 1, 3, 5 };
int deleteNum = computerRepo.DeleteByIds(ids);
if(deleteNum == 3)
{
    Console.WriteLine("Se han eliminado 3 ordenadores");
}*/

Console.WriteLine("======DELETEALL============");
/*beforeDelete = computerRepo.Count();
bool hasDeleteAll = computerRepo.DeleteAll();
afterDelete = computerRepo.Count();

if(hasDeleteAll)
{
    Console.WriteLine("Se han eliminado todos los ordenadores");
}
if (afterDelete == 0) Console.WriteLine("Se han eliminado todos los ordenadores");
hasDeleteAll = computerRepo.DeleteAll();
if(hasDeleteAll ) Console.WriteLine("Se han eliminado todos los ordenadores");
*/

Console.WriteLine("======CALCURA LA MEDIA DE RAM============");
computerRepo.PrintAll();
double averageRam = computerRepo.CalculateAvgRam();
Console.WriteLine(averageRam);
Console.WriteLine($"La media de la RAM de los ordenadores es {averageRam}");