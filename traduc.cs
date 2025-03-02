using System;
using System.Collections.Generic;

class Traductor
{
	static void Main()
	{
		// Diccionario inicial con algunas palabras
		Dictionary<string, string> diccionario = new Dictionary<string, string>()
		{
			{ "tiempo", "time" },
			{ "persona", "person" },
			{ "aC1o", "year" },
			{ "comC:n", "common" },
			{ "dC-a", "day" },
			{ "hombre", "man" },
			{ "mundo", "world" },
			{ "vida", "life" },
			{ "mano", "hand" },
			{ "parte", "part" },
			{ "cinco", "five" },
			{ "ojo", "eye" },
			{ "mujer", "woman" },
			{ "lugar", "place" },
			{ "trabajo", "work" },
			{ "semana", "week" },
			{ "coco", "coconut" },
			{ "gobierno", "government" }
		};
		//Aqui se usaron las palabras en minusculas por que asi se van a usar mas

		while (true)
		{
			// Mostrar menC:
			Console.WriteLine("\nMENU");
			Console.WriteLine("=======================================================");
			Console.WriteLine("1. Traducir una frase");
			Console.WriteLine("2. Ingresar mC!s palabras al diccionario");
			Console.WriteLine("0. Salir");
			Console.Write("Seleccione una opci3n: ");
			int opcion = Convert.ToInt32(Console.ReadLine());

			switch (opcion)
			{
			case 1:
				TraducirFrase(diccionario);
				break;

			case 2:
				AgregarPalabra(diccionario);
				break;

			case 0:
				Console.WriteLine("Saliendo del programa...");
				return;

			default:
				Console.WriteLine("Opcion invalida, por favor ingrese una opcion valida.");
				break;
			}
		}
	}

	// MC)todo para traducir una frase
	static void TraducirFrase(Dictionary<string, string> diccionario)
	{
		Console.Write("Ingrese la frase: ");
		string frase = Console.ReadLine();

		// Dividir la frase en palabras
		string[] palabras = frase.Split(' ');

		// Traducir cada palabra
		for (int i = 0; i < palabras.Length; i++)
		{
			string palabra = palabras[i];
			if (diccionario.ContainsKey(palabra))
			{
				palabras[i] = diccionario[palabra];
			}
			else if (diccionario.ContainsKey(palabra[0] + palabra.Substring(1).ToLower()))
			{
				// Si la palabra estC! en el diccionario pero con la primera letra en mayC:sculas
				palabras[i] = diccionario[palabra[0] + palabra.Substring(1).ToLower()];
			}
		}

		// Imprimir la frase traducida
		string fraseTraducida = string.Join(" ", palabras);
		Console.WriteLine("\nSu frase traducida es: " + fraseTraducida);
	}

	// MC)todo para agregar nuevas palabras al diccionario
	static void AgregarPalabra(Dictionary<string, string> diccionario)
	{
		Console.Write("Ingrese la palabra en ingles: ");
		string palabraIngles = Console.ReadLine();

		Console.Write("Ingrese la traduccion en español: ");
		string palabraEspaC1ol = Console.ReadLine();

		// Agregar la nueva palabra al diccionario
		diccionario[palabraIngles] = palabraEspaC1ol;

		Console.WriteLine($"La palabra '{palabraIngles}' ha sido agregada al diccionario.");
	}
}
