using System;
namespace POO;


/*
 * Las interfaces son tipos abstractos, es decir, no implementan los métodos, solo los declaran
 * 
 * */


public interface ISaludo
{
    //Métodos para trabajar con clientes

    //crear un cliente
    void Saludar();// declara el metodo dice que hay que hacer pero no el como 
    void Saludar(string nombre);
}

