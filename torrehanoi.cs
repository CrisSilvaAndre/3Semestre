using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int numDiscos = 3; // 3 son las torres de Hanoi
        HanoiTorres(numDiscos, 'A', 'C', 'B');
    }

    // Método iterativo para resolver las Torres de Hanoi
    static void HanoiTorres(int n, char inicio, char fin, char medio)
    {
        // Creamos datos para las 3 torres
        Stack<int> torreinicio = new Stack<int>();
        Stack<int> torrefin = new Stack<int>();
        Stack<int> torremedio = new Stack<int>();

        // Inicializar la torre de inicio con los discos
        for (int i = n; i > 0; i--)
        {
            torreinicio.Push(i);
        }

        // Número de movimientos posibles, que es (3^n) - 1
        int totalMovimientos = (int)Math.Pow(3, n) - 1;

        // Usar variables para que lleven registro a que torre moverse
        for (int i = 1; i <= totalMovimientos; i++)
        {
            if (i % 3 == 1)
            {
                // Mover disco entre inicio y fin
                MoverDisco(torreinicio, torrefin, inicio, fin);
            }
            else if (i % 3 == 2)
            {
                // Mover disco entre inicio y medio
                MoverDisco(torreinicio, torremedio, inicio, medio);
            }
            else
            {
                // Mover disco entre medio y fin
                MoverDisco(torremedio, torrefin, medio, fin);
            }
        }
    }

    // Método para mover el disco de una torre a otra
    static void MoverDisco(Stack<int> torreinicio, Stack<int> torrefin, char inicio, char fin)
    {
        // Verificar que existan anillos en la torre inicial
        if (torreinicio.Count > 0)
        {
            int disco = torreinicio.Pop();
            Console.WriteLine($"Mover disco {disco} de {inicio} a {fin}");
            torrefin.Push(disco);
        }
    }
}
