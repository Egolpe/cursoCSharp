
namespace ASPNET2.Repositories;

public interface IAddressRepository
{
    
    Address FindById(int id);

    List<Address> FindAll();

    Address Create(Address address);

    Address Update(Address address);

    bool RemoveById(int id);
}

