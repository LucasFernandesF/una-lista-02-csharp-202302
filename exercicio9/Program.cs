using System;
					
public class Program
{
	public static void Main()
	{
		double segundos, minutos, horas;
		Console.WriteLine("Digite os segundos para saber os minutos e as horas:");
		segundos = double.Parse(Console.ReadLine());
		minutos = segundos / 60;
		horas = segundos / 3600;
		Console.WriteLine("Os segundos {0} em minutos é {1} e em horas é {2}",segundos, minutos, horas);
        Console.ReadLine();
	}
}