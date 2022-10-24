using System;
using System.Reflection;
using System.Text;

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

    

    public List<Computer> FindAllByModel(string model)
    {
        List<Computer> computersByModel = new List<Computer>();
        foreach (Computer computer in computers)
        {
            if (computer.Model.ToLower().Equals(model.ToLower()))
            {
               computersByModel.Add(computer);
            }
        }
        return computersByModel;
    }

    public bool Save(Computer computer)
    {
        Console.WriteLine(computer);
        //comprobar si existe
        bool exists = ExistById(computer.Id);
        //si existe no lo añado a la lista
        if (exists)
        {
            return false;
        }
        // si no existe lo añado y devuelvo true
        computers.Add(computer);
        return true;
    }

    public int Count()
    {
        //int NumPc = computers.Count();
        //return NumPc;

        int contador = 0;
        foreach (Computer computer in computers)
            contador++;
        return contador;
    }

    public int SaveAll(List<Computer> computersToAdd)
    {   //computersToAdd es la nueva lista de ordenadores a agregar
        //computers es la lista de ordenadores que ya tenemos
        //computers.AddRange(computersToAdd);
        int contador = 0;
        foreach (Computer computer in computersToAdd)
        {
            bool saved = Save(computer);
            if (saved) contador++;
        }
        return contador;
    }

    public void PrintAll()
    {
        //Opción 1
        foreach (Computer computer in computers)
        {
            Console.WriteLine(computer);//Debe estar el metodo ToString en la clase computer
        }


        //OPcion 2
        //Console.WriteLine(string.Join(",", computers));
        //Opcion 3 
        //StringBuilder sb = new StringBuilder();
        //foreach (Computer computer in computers)
        //    sb.Append(computer).Append(".");
        //Console.WriteLine(sb);

    }

    public bool update(Computer computer)
    {
        //comprobar si existe
        if (!ExistById(computer.Id))
        {
            return false;
        }
        //si existe devolver true
        for(int i = 0; i < computers.Count; i++)
        {
            if(computers[i].Id == computer.Id)
            {
                //Actualizar atributos del computer de la lista
                //del computer que llega como parametro
                computers[i].Model = computer.Model;
                computers[i].Ram = computer.Ram;
                return true;// una vez modificado salimos del método
            }

        }
        return false;  

    }

    public bool DeleteById(int id)
    {
        if (!ExistById(id))
        {
            return false;
        }
        for (int i = 0; i < computers.Count; i++)
        {
            if (computers[i].Id == id)
            {
                computers.RemoveAt(i);
                return true;
            }
        }
        return false;
    }
}

