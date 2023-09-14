# Lista de Exercícios II: Estrutura Sequencial
1. Escreva um algoritmo que leia dois números informados pelo usuário a partir do teclado e que apresente o resultado da média aritmética dos dois números informados.
```
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
```

2. Escreva um algoritmo que leia o preço de um produto a partir do teclado e apresente na tela o valor do produto acrescido de 10% de seu valor original. 
Exemplo:
Informe o valor do produto: 50.00
Novo valor do produto: 55.00

```
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
```

3. Escreva um algoritmo que leia uma temperatura fornecida pelo usuário a partir do teclado em graus Fahrenheit e a converta para o seu equivalente em graus centígrados.
OBS.: °C = (°F − 32) / 1,8
```
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
```

4. Escreva um algoritmo para calcular os juros compostos de uma aplicação financeira. O algoritmo deve ler o valor do capital a ser aplicado, o prazo de aplicação em meses, a taxa de juros mensal e apresentar na tela o montante a ser recebido.
OBS: M = C × (1 + i) n  em que M é o montante a ser recebido, C é o capital
aplicado, i é a taxa de juros e n é o prazo da aplicação.
```
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
```

5. Escreva um algoritmo para calcular e imprimir o salário bruto a ser recebido por um funcionário em um mês. O programa deverá utilizar os seguintes dados:
a. Número de horas que o funcionário trabalhou no mês.
b. Valor recebido por hora de trabalho.
c. Valor do salário família.
d. Número de filhos com idade menor que 14 anos, para calcular o salário família

```
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
```

6. Escreva um algoritmo que receba dois números a partir do teclado. O algoritmo deve imprimir o logaritmo do primeiro número na base representada pelo segundo número

```
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
```

7-Escreva um algoritmo que leia o salário fixo de um vendedor, o valor total das vendas que ele realizou no mês e o percentual que ele ganha sobre o total das vendas mensais. O algoritmo deve calcular o salário total do vendedor e apresentá-lo na tela.
```
using System

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
```
8. Em um estacionamento há carros e motos. Escreva um algoritmo que solicite ao usuário o total de veículos e o total de rodas. O algoritmo deve determinar quantos carros e quantas motos há no estacionamento. O resultado deve ser apresentado na tela para o usuário.
 ```
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
```

9-Escreva um algoritmo que receba um número inteiro de segundos a partir do teclado e imprima na tela a quantidade correspondente em horas, minutos e segundos.
```
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
```
10-Escreva um algoritmo que, dados três valores, calcule e imprima as médias aritmética, harmônica e geométrica destes valores.
```
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
```
