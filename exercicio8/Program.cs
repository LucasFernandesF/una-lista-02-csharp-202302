using System;

public class Program
{
	public static void Main()
	{
		Console.WriteLine("Qual é o total de veiculos no estacionamento?");
		int totalVeiculos = int.Parse(Console.ReadLine());
		Console.WriteLine("Qual é o total de rodas?");
		int totalRodas = int.Parse(Console.ReadLine());
		int carros = (totalRodas - 2 * totalVeiculos) / 2;
		int motos = totalVeiculos - carros;
		Console.WriteLine("O número de carros é {0} e o de motos é {1}", carros, motos);
        Console.ReadLine();
	}
}