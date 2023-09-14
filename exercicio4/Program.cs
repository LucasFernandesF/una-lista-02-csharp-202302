using System;

public class Program
{
	public static void Main()
	{

		Console.WriteLine("Digite o valor do capital a ser aplicado:");
		double capital = double.Parse(Console.ReadLine());
		Console.WriteLine("Digite o prazo de aplicação em meses:");
		double meses = double.Parse(Console.ReadLine());
		Console.WriteLine("Digite a taxa de juros mensal:");
		double juros = double.Parse(Console.ReadLine());
        juros = juros /100;
		double montante = capital * Math.Pow(1 + juros, meses);
		Console.WriteLine("O valor capital de {0}, no prazo de {1} meses, com a taxa de juros mensais de {2}, gera um montante de {3}", capital, meses, juros, montante.ToString("F"));
        Console.ReadLine();
	}
}