using System;

class Hello
{
    static void Main()
   
    {

        bool bandera = true;

        Console.WriteLine("Hola, ingresa el numero de paquetes");
        do
        {
             if(!int.TryParse(Console.ReadLine(), out int num))
        {
            Console.WriteLine("Se pide que sean numeros enteros, intentalo de nuevo");
            bandera = true;
        }
        else
        {
            Console.WriteLine("El numero de cajas es: "+ num/6 + " y el numero de restantes es: "+ num % 6);
            bandera = false;
        }
        } while (bandera);
       
    }
}