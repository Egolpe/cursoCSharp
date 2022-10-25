using System;
namespace POO;

public interface IComputerRepository
{
    //recuperar todos los computers
    List<Computer> findAll();
    //recuperar un computer por Id
    Computer findbyId(int id);

    //comprobar si existe por id
    bool ExistById(int id);

    //recuperar por varios por ids

    //Recuperar por rango de memoria(min, max) Ram.
    List<Computer> FindAllByRam(int min, int max);
    //Buscar por Model
    List<Computer> FindAllByModel(string model);
    //Guardaruno
    bool Save(Computer computer);
    //guardar varios
    int SaveAll(List<Computer> computersToAdd);
    // recuperar el número de ordenadores, para saber cuantos ordenadores hay
    int Count();
    //imprimir por consola todos los ordenadores de la lista que ya tenemos
    void PrintAll();
    //modificar un computer que ya está en la lista
    bool update(Computer computer);

    //borrar por id
    bool DeleteById(int id);

    //Borrar por ids
    int DeleteByIds(List<int> ids);


    // borrar todos
    bool DeleteAll();
    //calcular la RAM media de todos los ordenadores
    double CalculateAvgRam();
    //sacar la RAM máxima de todos los ordenador, es decir, comprobar el que tiene más ram y devolver ese número
    int FindMaxRam();
    //sacar la RAM mínima de todos los ordenador, es decir, comprobar el que tiene más ram y devolver ese número
    int FindMinRam();

}

