Console.WriteLine("Conversor de dólares para REAL: Cotação atual $1 = R$5");
Console.WriteLine("Informe a quantidade a ser convertida:");
double value = double.Parse(Console.ReadLine());

double newValue = value * 5;

Console.WriteLine($"Valor a ser convertido ${value:F2}, valor após conversão  R${newValue:F2}");


// Stop
Console.ReadKey();