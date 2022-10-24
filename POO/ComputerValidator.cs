using System;
namespace POO;

// TODO: crear una clase ComputerValidator con un método validate que reciba un Computer

// devuelva true o false si cumple una serie de condiciones:
// Id que no sea nulo y que si sea mayor que 0
// RAM mayor que 2 y menor que 256
// Model no puede ser nulo ni estar vacío y tiene que tener una longitud superior a 3 letras
// Utilizar este validador antes de guardar un ordenador
// Opcional: comprobar el atributo Model utilizando una expresión regular




public class ComputerValidator
{
    public ComputerValidator()
    {
    }

    public bool Validate(Computer computer)
    {
        //1.Id que no sea nulo y que si sea mayor que 0

        if ( computer == null || computer.Id == 0)
        {
            return false;//El computer es incorrecto
        }

        if (computer.Ram >= 256 || computer.Ram <= 2)
        {
            return false;//El computer es incorrecto
        }
        if (computer.Model == null || computer.Model.Length <= 3)
            return false;//El computer es incorrecto
        {

        }
        return true;
    }
}

