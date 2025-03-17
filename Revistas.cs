using System;
using System.Collections.Generic;

class CatalogoRevistas
{
    static bool BuscarTitulo(List<string> catalogo, string titulo, int indice = 0)
    {
        if (indice >= catalogo.Count)
        {
            return false; // Si hemos recorrido todo el catálogo, no encontramos el título.
        }
        if (catalogo[indice] == titulo)
        {
            return true; // Si encontramos el título, devolvemos true.
        }
        return BuscarTitulo(catalogo, titulo, indice + 1); // Continuamos buscando en el siguiente índice.
    }

    static bool BuscarTitulo2(List<string> catalogo, string titulo)
    {
        foreach (var item in catalogo)
        {
            if (item == titulo)
            {
                return true; // Si encontramos el título, devolvemos true.
            }
        }
        return false; // Si no encontramos el título, devolvemos false.
    }

    static void Main()
    {
        List<string> catalogo = new List<string>();
        // Ingresamos 10 títulos al catálogo
        Console.WriteLine("Ingrese 10 títulos de revistas al catálogo:");
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Ingrese el título de la Revista {i + 1}: ");
            catalogo.Add(Console.ReadLine());
        }

        while (true)
        {
            // Menú de opciones
            Console.WriteLine("\nMenú:");
            Console.WriteLine("1. Buscar un título de Revista");
            Console.WriteLine("2. Salir");
            Console.Write("Elija una opción: ");
            string opcion = Console.ReadLine();

            if (opcion == "1")
            {
                Console.Write("Ingrese el título que desea buscar: ");
                string tituloABuscar = Console.ReadLine();

                bool encontrado = BuscarTitulo(catalogo, tituloABuscar);

                bool encontrado2 = BuscarTitulo2(catalogo, tituloABuscar);

                // Mostramos los resultados
                if (encontrado || encontrado2)
                {
                    Console.WriteLine("Título de Revista encontrado.");
                }
                else
                {
                    Console.WriteLine("Título de Revista no encontrado.");
                }
            }
            else if (opcion == "2")
            {
                Console.WriteLine("Saliendo del programa...");
                break;
            }
            else
            {
                Console.WriteLine("Opción inválida. Por favor, elija una opción válida.");
            }
        }
    }
}
