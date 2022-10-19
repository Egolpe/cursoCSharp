using System;
namespace POO;

public class Address
{ 
    public string street;
    public string PostalCode;
    public string City;
    public Country country;//Asociación entre clases: separar a una nueva clse asociada relación de 1 a 1 


    public Address()
    {
    }
}

public class Country
{
    public double Pib;
    public string Nombre;
    public double Población;
    public bool TieneCosta;
    public bool UE;
    public string Capital;
    public List<Language> Languages = new List<Language>();// relación de 1 a n
}

public class Language
{
    public string Nombre;
    public bool Latin;
    public string Characteres;
    public int Year;
}