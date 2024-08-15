Console.WriteLine("Bem-vindo ao identificador de Triângulos 2.0");
Console.WriteLine("Informe as dimensões do triângulo =>");

// lado 1
Console.WriteLine("Lado 1:");
double sideOne = double.Parse(Console.ReadLine());

// lado 2
Console.WriteLine("Lado 2:");
double sideTwo = double.Parse(Console.ReadLine());

// lado 3

Console.WriteLine("Lado 3:");
double sideThree = double.Parse(Console.ReadLine());

// triângulo equilatero
if (sideOne == sideTwo && sideOne == sideThree)
{
    Console.WriteLine("De acordo com os lados fornecidos, você especificou um triângulo equilatero.");
}
// triângulo isósceles lado 1 e lado 2 =, ou lado 1 e lado 3 =, ou lado 2 e 3 =
else if (sideOne == sideTwo || sideOne == sideThree || sideTwo == sideThree)
{
    Console.WriteLine("De acordo com os lados fornecidos, você especificou um triângulo isósceles.");
}
// triângulo escaleno todos os lados diferentes
else if (sideOne != sideTwo && sideOne != sideThree && sideTwo != sideThree)
{
    Console.WriteLine("De acordo com os lados fornecidos, você especificou um triângulo escaleno.");
}

// ponto de pausa
Console.ReadKey();
