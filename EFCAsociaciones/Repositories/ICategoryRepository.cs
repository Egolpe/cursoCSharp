
namespace EFCAsociaciones.Repositories;

public interface IAddressRepository
{
    //buscar por id
    Address FindById(int id);

    //Buscar todos
    List<Address> FindAll();

    //guardar
    Address Create(Address address);
    //actualizar  restringiendo campos
    Address Update(Address address);
    //borrar por id
    bool Remove(int id);
}

