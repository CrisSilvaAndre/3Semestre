using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Generamos los conjuntos como se nos pide para cada Ciudadano
        HashSet<string> todosLosCiudadanos = new HashSet<string>();
        for (int i = 1; i <= 500; i++)
        {
            todosLosCiudadanos.Add($"Ciudadano {i}");
        }

        // 75 Ciudadanos para Pfizer
        HashSet<string> vacunadosPfizer = new HashSet<string>();
        for (int i = 1; i <= 75; i++)
        {
            vacunadosPfizer.Add($"Ciudadano {i}");
        }

        // Otros 75 para Astrazeneca
        HashSet<string> vacunadosAstraZeneca = new HashSet<string>();
        for (int i = 76; i <= 150; i++)
        {
            vacunadosAstraZeneca.Add($"Ciudadano {i}");
        }

        // Operaciones de conjuntos

        // Ciudadanos que no se han vacunado, exeptuamos los 150 vacunados
        HashSet<string> noVacunados = new HashSet<string>(todosLosCiudadanos);
        noVacunados.ExceptWith(vacunadosPfizer);
        noVacunados.ExceptWith(vacunadosAstraZeneca);

        // Ciudadanos que han recibido las dos vacunas
        HashSet<string> vacunadosConAmbas = new HashSet<string>(vacunadosPfizer);
        vacunadosConAmbas.IntersectWith(vacunadosAstraZeneca);

        // Ciudadanos que solamente han recibido la vacuna de Pfizer
        HashSet<string> soloPfizer = new HashSet<string>(vacunadosPfizer);
        soloPfizer.ExceptWith(vacunadosAstraZeneca);

        // Ciudadanos que solamente han recibido la vacuna de AstraZeneca
        HashSet<string> soloAstraZeneca = new HashSet<string>(vacunadosAstraZeneca);
        soloAstraZeneca.ExceptWith(vacunadosPfizer);

        // Mostramos los resultados
        Console.WriteLine("Ciudadanos que no se han vacunado:");
        foreach (var ciudadano in noVacunados)
        {
            Console.WriteLine(ciudadano);
        }

        Console.WriteLine("\nCiudadanos que han recibido las dos vacunas:");
        foreach (var ciudadano in vacunadosConAmbas)
        {
            Console.WriteLine(ciudadano);
        }

        Console.WriteLine("\nCiudadanos que han recibido la vacuna de Pfizer:");
        foreach (var ciudadano in soloPfizer)
        {
            Console.WriteLine(ciudadano);
        }

        Console.WriteLine("\nCiudadanos que han recibido la vacuna de AstraZeneca:");
        foreach (var ciudadano in soloAstraZeneca)
        {
            Console.WriteLine(ciudadano);
        }
    }
}
