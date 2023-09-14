using System;
public class exercicio1
{
    public static void Main()
    {
        int num1, num2, media;

        Console.WriteLine("Digite dois números para saber a média aritmética");
        Console.WriteLine("Digite o primeiro número:");
        num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segundo número:");
        num2 = int.Parse(Console.ReadLine());
        media = (num1 + num2) / 2;
        Console.WriteLine("A média aritmética é " + media);
        Console.ReadLine();
    }
}