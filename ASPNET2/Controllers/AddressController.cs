using System;
namespace ASPNET2.Controllers;

[ApiController]
[Route("api/addresses")]
public class AddressController
{
    private IAddressRepository AddressRepo;


    public AddressController(IAddressRepository addressRepository)
    {
        AddressRepo = addressRepository;
    }

    [HttpGet("/all")]
    public List<Address> FindAll()
    {
        return AddressRepo.FindAll();
    }

    [HttpGet("{id}")]
    public Address FindById(int id)
    {
        return AddressRepo.FindById(id);
    }

    [HttpPost]
    public Address Create(Address address)
    {
        return AddressRepo.Create(address);
        
    }

    [HttpPut]
    public Address Update(Address address)
    {
        return AddressRepo.Update(address);
    }

    [HttpDelete("{id}")]
    public void DeleteById(int id)
    {
        AddressRepo.RemoveById(id);
    }
}

