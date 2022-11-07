
using EFCAsociaciones.Models;

namespace EFCAsociaciones.Repositories;

public class AddressDbRepository : IAddressRepository
{

    //Atributos
    private AppDbContext Context;
    //constructores
    public AddressDbRepository(AppDbContext context)
    {
        Context = context;
    }
    public AddressDbRepository()
    {
    }

    public Address Create(Address address)
    {
        Context.Addresses.Add(address);// un libro puede tener author y categories
        Context.SaveChanges();
        return address;
    }

    public List<Address> FindAll()
    {
        return Context.Addresses.ToList();
    }

    public Address FindById(int id)
    {
        return Context.Addresses.Find(id);
    }

    public bool RemoveById(int id)
    {
        Address address = FindById(id);
        if (address == null)
        {
            return false;
        }
        Context.Addresses.Remove(address);// un libro puede tener author y categories
        Context.SaveChanges();
        return true;
    }

    public bool Remove(int id)
    {
        Address address = FindById(id);
        if (address == null)
        {
            return false;
        }
        Context.Addresses.Remove(address);
        Context.SaveChanges();
        return true;
    }
}

