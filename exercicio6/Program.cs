using System;
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Digite o primeiro número:");
		double num1 = double.Parse(Console.ReadLine());
		Console.WriteLine("Digite o segundo número que será a base do logaritmo");
		double baseLogaritmo = double.Parse(Console.ReadLine());
		double logaritmo = Math.Log(num1, baseLogaritmo);
		Console.WriteLine("O logaritmo é "+ logaritmo.ToString("F"));
        Console.ReadLine();
        }
}