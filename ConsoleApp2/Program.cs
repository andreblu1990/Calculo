using System;

public class Program
{
	public static void Main()
	{
		Console.WriteLine("Média dos numeros");

		int numero1 = 0;
		int numero2 = 0;
		int numero3 = 0;
		int numero4 = 0;

		string texto1 = "";
		string texto2 = "";
		string texto3 = "";
		string texto4 = "";

		Console.WriteLine("Escreva um numero");
		
		while (!int.TryParse(texto1, out numero1))
		{
			texto1 = Console.ReadLine();
		}
		Console.WriteLine("Escreva um numero");

		while (!int.TryParse(texto2, out numero2))
		{
			texto2 = Console.ReadLine();
		}
		Console.WriteLine("Escreva um numero");

		while (!int.TryParse(texto3, out numero3))
		{
			texto3 = Console.ReadLine();
		}
		Console.WriteLine("Escreva um numero");


		while (!int.TryParse(texto4, out numero4))
		{
			texto4 = Console.ReadLine();
		}
		
		int suma0 = numero1 + numero2 + numero3 + numero4;
		int division0 = suma0 / 2;

		Console.WriteLine("A media dos numeros " + numero1 + ", " + numero2 + ", " + numero3 + " , " + numero4 + " é: " + division0);
	}

}       