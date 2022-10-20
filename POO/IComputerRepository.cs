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

    //Guardar

    //modificar

    //Borrar

    //Borrar todos

    //borrar por ids
}

