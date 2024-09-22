using System;
using System.Globalization;
using System.Security;

Console.WriteLine("Bem-vindo ao ArraysDivertidos encontre seu número aqui:\n");
Console.WriteLine("Quantos númreros você quer colocar no array?");
int quantity = int.Parse(Console.ReadLine());

int[] numbers = new int[quantity];

for(int i = 0; i < quantity; i++)
{
    Console.WriteLine("Digite um valor para colocar no array:");
    int number = int.Parse(Console.ReadLine());
    numbers[i] = number;
}

foreach(int number in numbers)
{
    Console.WriteLine($"Número: {number}");
}

Console.WriteLine("Digite um número:");
int value = int.Parse(Console.ReadLine());

// Expressão lambda(é uma função), Action é usado quando um valor especifíco não é retornado
// caso houvesse um return, a palavra chave seria Func <T1, T2, TResult>
Action<int[], int> verifyNumber = (nums, val) =>
{
    // inicio uma variável como false para evitar múltiplas mensagens 
    // de número não encontrado
    bool found = false;
    foreach(int num in nums)
    {
        if (num == val)
        {
            Console.WriteLine($"O número {num} está no array.");
            // se o número estiver dentro do array found se torna true
            found = true;
            break;
        }
    }
    // !found = não encontrado, que significa true, então ele entra no if
    if (!found)
    {
        Console.WriteLine($"O número {val} não está no array");
    }
};

// a expressão lambda(função) recebe dois parâmetros, o array a ser percorrido e o valor
// a ser procurado
verifyNumber(numbers, value);

bool? opt = true;
string? end = "fim";
string? compare = "compare";

do
{
    Console.WriteLine("Digite um número:");
    int num = int.Parse(Console.ReadLine());
    verifyNumber(numbers, num);

    Console.WriteLine($"Deseja continuar? Continuar: sim, Encerrar: fim");
    compare = Console.ReadLine();
    // equals verifica se o valor de end é igual ao de compare
    if (end.Equals(compare))
    {
        opt = false;
    }

} while (opt == true);


Console.WriteLine("Programa encerrado, até mais!");
Console.ReadKey();
