using System;
public class exercicio2
{
    public static void Main()
    {
        double produto, produtoFinal;

        Console.WriteLine("Digite o valor do produto para ser acresentado 10% do seu valor:");
        produto = double.Parse(Console.ReadLine());
        produtoFinal = produto + (produto * 0.1);
        Console.WriteLine("O valor final do produto é " + produtoFinal.ToString("F"));
        Console.ReadLine();
    }
}