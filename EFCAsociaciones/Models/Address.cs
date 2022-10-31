
namespace EFCAsociaciones.Models;
[Table("addresses")]
public class Address
{
    //Atributos
    [Key, Column("id", Order = 0)]
    public int Id { get; set; }

    public string Street { get; set; }

    public string City { get; set; }


    //Asociaciones

    //COnstuctores
    public Address()
    {
    }
}

