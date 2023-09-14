using System;
					
public class Program
{
	public static void Main()
	{
		double grausF, grausC;
		Console.WriteLine("Digite a temperatura em graus Fahrenheit para saber o seu equivalente em graus centígrados.");
		grausF = double.Parse(Console.ReadLine());
		grausC = (grausF - 32) / 1.8;
		Console.WriteLine("A temperatura em Fahrenheit {0} tem seu equivalente em graus Celsius é {1}",grausF, grausC.ToString("F1") );
        Console.ReadLine();
	}
}