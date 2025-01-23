// Ejercicio Numero 1 de la tarea
using System;

public class Nodo
{
    public int Valor;
    public Nodo Siguiente;

    public Nodo(int valor)
    {
        Valor = valor;
        Siguiente = null;
    }
}

public class ListaEnlazada
{
    private Nodo principal;

    public ListaEnlazada()
    {
        principal = null;
    }

//Agreagar listas al final
    public void Agregar(int valor)
    {
        Nodo nuevoNodo = new Nodo(valor);
        if (principal == null)
        {
            principal = nuevoNodo;
        }
        else
        {
            Nodo actual = principal;
            while (actual.Siguiente != null)
            {
                actual = actual.Siguiente;
            }
            actual.Siguiente = nuevoNodo;
        }
    }

    // Clacular los elementos
    public int ContarElementos()
    {
        int contador = 0;
        Nodo actual = principal;

        while (actual != null)
        {
            contador++;
            actual = actual.Siguiente;
        }

        return contador;
    }
}

class Program
{
    static void Main(string[] args)
    {
        ListaEnlazada lista = new ListaEnlazada();

        // Agregar elementos para ejercicio
        lista.Agregar(5);
        lista.Agregar(8);
        lista.Agregar(15);
        lista.Agregar(20);
        lista.Agregar(70);
        lista.Agregar(110);

        // Calcular el número de elementos
        int numeroDeElementos = lista.ContarElementos();
        Console.WriteLine("Esta lista contiene " + numeroDeElementos + " elementos.");
    }
}
