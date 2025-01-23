// Ejercicio 3, busqueda 
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
//Aplicamos una lista enlazada

public class ListaEnlazada
{
    private Nodo principal;

    public ListaEnlazada()
    {
        principal = null;
    }

    // Agregamos elementos al final de la lista
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

    // Aplicamos nuestro metodo para contar los elementos
    public int ContarElementos()
    {
        int contador = 0;
        Nodo actual = principal;

        // Recorrer la lista hasta el final
        while (actual != null)
        {
            contador++;
            actual = actual.Siguiente;
        }

        return contador;
    }

    public void Buscar(int valor)
    {
        Nodo actual = principal;
        int contador = 0;

        // Recorremos la lista para buscar el valor
        while (actual != null)
        {
            if (actual.Valor == valor)
            {
                contador++;
            }
            actual = actual.Siguiente;
        }

        // Mostrar el resultado de la búsqueda
        if (contador > 0)
        {
            Console.WriteLine($"El numero {valor} aparece {contador} veces en nuestra lista.");
        }
        else
        {
            Console.WriteLine($"El numero {valor} no aparece en la lista.");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        ListaEnlazada lista = new ListaEnlazada();

        // Agregar algunos elementos
        lista.Agregar(3);
        lista.Agregar(55);
        lista.Agregar(3);
        lista.Agregar(3);
        lista.Agregar(3);
        lista.Agregar(10);
        lista.Agregar(3);
        lista.Agregar(43);
        lista.Agregar(3);
        lista.Agregar(43);
        lista.Agregar(8);
        lista.Agregar(3);
        lista.Agregar(9);

        lista.Buscar(3); 

        lista.Buscar(88);
    }
}