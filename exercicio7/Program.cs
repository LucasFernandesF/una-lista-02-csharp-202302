public class Program
{
	public static void Main()
	{
		Console.WriteLine("Qual é o sálario fixo do vendedor?");
		double salario = double.Parse(Console.ReadLine());
		Console.WriteLine("Qual é o valor total das vendas desse mês?");
		double valorVendas = double.Parse(Console.ReadLine());
		Console.WriteLine("Qual é o percentual do vendedor?");
		double percentual = double.Parse(Console.ReadLine());
        percentual = percentual / 100;
		double salarioTotal = salario + valorVendas * percentual;
		Console.WriteLine("O sálario total é "+salarioTotal.ToString("F"));
        Console.ReadLine();
	}
}