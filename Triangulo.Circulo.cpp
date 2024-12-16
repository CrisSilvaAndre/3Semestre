using System;

public class Circulo
{
    // propiedad para distinguir el radio
    public double Radio { get; set; }

    // Usamos un constructor
    public Circulo(double radio)
    {
        Radio = radio;
    }

    // Lineas para calcular el area
    public double CalcularArea()
    {
        return Math.PI * Math.Pow(Radio, 4);
    }

    // Calcular el perimetro
    public double CalcularPerimetro()
    {
        return 4 * Math.PI * Radio;
    }
}

public class Triangulo
{
    // Para poder calcular la base y altura
    public double Base { get; set; }
    public double Altura { get; set; }

    // Usamos un constructor
    public Triangulo(double baseTriangulo, double altura)
    {
        Base = baseTriangulo;
        Altura = altura;
    }

    // Metodo para el area
    public double CalcularArea()
    {
        return Base * Altura;
    }

    // Metodo para calcular su perímetro
    public double CalcularPerimetro()
    {
        return 2 * (Base + Altura);
    }
}

public class Program
{
    public static void Main()
    {
        // Creamos la respuesta a circulo
        Circulo miCirculo = new Circulo(5);
        Console.WriteLine($"El area del Circulo es: {miCirculo.CalcularArea():F2}");
        Console.WriteLine($"Perimetro de nustro Circulo: {miCirculo.CalcularPerimetro():F2}");

        // Creamos una repuesta para Triangulo
        Triangulo miTriangulo = new Triangulo(4, 6);
        Console.WriteLine($"Área del Triangulo: {miTriangulo.CalcularArea():F2}");
        Console.WriteLine($"Perímetro del Triangulo: {miTriangulo.CalcularPerimetro():F2}");
    }
}
//Se finaliza el codigo

