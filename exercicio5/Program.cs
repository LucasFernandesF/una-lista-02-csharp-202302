using System;

public class Program
{
	public static void Main()
	{

		Console.WriteLine("Digite o número de horas trabalhadas no mês:");
		int horasTrabalhadas = int.Parse(Console.ReadLine());
		Console.WriteLine("Digite o valor recebido por hora:");
		double valorHora = double.Parse(Console.ReadLine());
		Console.WriteLine("Qual o valor do sálario família");
		double valorFamilia = double.Parse(Console.ReadLine());
		Console.WriteLine("Quantos filhos de até 14 anos você tem em casa?");
		int qtdFilho = int.Parse(Console.ReadLine());
		double salarioBruto = valorHora * horasTrabalhadas + valorFamilia * qtdFilho;
		Console.WriteLine("O salário bruto a ser recebido por um funcionário em um mês é {0}", salarioBruto.ToString("F"));
        Console.ReadLine();
	}
}