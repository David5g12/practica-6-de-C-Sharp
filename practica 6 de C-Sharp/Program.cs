using System;
using System.Collections.Generic;

class program
{
    static void Main()
    {
        //Declare una lista de cadenas
        Console.WriteLine("                    C-Sharp");
        Console.WriteLine("           David Hernandez Hernandez");
        Console.WriteLine("           Proyecto de estructura de datos");
        Console.WriteLine("\n");
        List<string> aves = new List<string> { "Loro gris", "Paloma de diamante", "Coctel" };
        Console.WriteLine("------------------------------------------------------------------");
        Console.WriteLine("   Los valores de la lista antes de insertar las demas aves:     |");
        Console.WriteLine("------------------------------------------------------------------");
        //itera sobre la lista para imprimir los valores 
        foreach (string ave in aves)
        {
            Console.Write(ave + "          |");
        }
        Console.WriteLine();
        Console.WriteLine("------------------------------------------------------------------");
        Console.WriteLine("\n");
        //Agregar tres valores al final de la lista utilizando el metodo Add()
        aves.Add("Mayna");
        aves.Add("periquitos");
        aves.Add("cacatua");
        Console.WriteLine("-------------------------------------------------------------------------------------");
        Console.WriteLine("           Los valores de la lista despues de insertar las demas aves es:           |");
        Console.WriteLine("-------------------------------------------------------------------------------------");
        //iterar sobre la lista para imprimir los valores
        foreach (string ave in aves)
        {
            Console.Write( ave + "    |");
        }
        Console.WriteLine();
        Console.WriteLine("-------------------------------------------------------------------------------------");
        Console.ReadKey();
    

    }
}