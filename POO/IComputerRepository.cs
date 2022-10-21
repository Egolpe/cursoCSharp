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

    //Varios por ids

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
    //modificar

    //Borrar

    //Borrar todos

    //borrar por ids

}

