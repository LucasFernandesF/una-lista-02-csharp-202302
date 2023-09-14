using System;

public class Program
{
	public static void Main()
	{
		double num1, num2, num3, mediaAritmetica, mediaHarmonica, mediaGeometrica, multiplicacao;
		Console.WriteLine("Digite o primeiro número:");
		num1 = double.Parse(Console.ReadLine());
		Console.WriteLine("Digite o segundo número:");
		num2 = double.Parse(Console.ReadLine());
		Console.WriteLine("Digite o terceiro número:");
		num3 = double.Parse(Console.ReadLine());
		mediaAritmetica = (num1 + num2 + num3) / 3;
		mediaHarmonica = 3 / (1 / num1 + 1 / num2 + 1 / num3);
		multiplicacao = num1 * num2 * num3;
		mediaGeometrica = Math.Cbrt(multiplicacao);
		Console.WriteLine("A média aritmética é {0}\nA média harmônica é {1}\nA média geométrica é {2}", mediaAritmetica, mediaHarmonica.ToString("F"), mediaGeometrica.ToString("F"));
		Console.ReadLine();
	}
}