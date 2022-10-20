using System;

namespace POO;

public class ComputerListRepositoryImpl : IComputerRepository 
{
    //Atributos
    private List<Computer> computers;

    //Constructor
    public ComputerListRepositoryImpl()
    {
        computers = new List<Computer>
        {
            new Computer{ Id = 1, Model = "Macbook Pro", Ram = 16},
            new Computer{ Id = 2, Model = "MSI Modern", Ram = 32},
            new Computer{ Id = 3, Model = "Assus A55a", Ram = 8}

        };
    }

   

    //implementar metodos de interfaz
    public List<Computer> findAll()
    {
        return computers;
    }

    public Computer findbyId(int id)
    {
        foreach(Computer computer in computers)
        {
            if(computer.Id == id)
            {
                return computer;
            }
        }
        return null;
    }

    public bool ExistById(int id)
    {
        /* foreach (Computer computer in computers)
         {
             if (computer.Id == id)
             {
                 return true;
             }
         }
         return false;*/
        return findbyId(id) != null;
    }

    public List<Computer> FindAllByRam(int min, int max)
    {
        List<Computer> computersByRam = new List<Computer>();

        foreach (Computer computer in computers)
        {
            if (computer.Ram >= min && computer.Ram <= max)
            {
                //añado el  ordenador que cumple los filtros de Ram a la nueva lista
                computersByRam.Add(computer);
            }
        }
        return computersByRam;
    }
}

