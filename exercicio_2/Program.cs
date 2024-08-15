Console.WriteLine("Bem-vindo ao Assistente virtual de Preços #Jarvis");

// Informando o valor de custo do produto
Console.WriteLine("Informe o valor de custo do produto:");
double costValue = double.Parse(Console.ReadLine());

// Informando o valor de venda do produto
Console.WriteLine("Informe o valor de venda do produto");
double sellValue = double.Parse(Console.ReadLine());

// definindo as porcentagens
var tenPercent = costValue * 0.10;
var twentyPercent = costValue * 0.20;

// calculando a diferença entre o valor de custo e valor de venda
var diff = sellValue - costValue;

// criando as condições para que determinada mensagem seja exibida
if (diff <= tenPercent)
{
    Console.WriteLine($"Lucro de R${diff:F2}:  \n - inferior a 10% \nMensagem \n - Baixo lucro");
}
else if (diff <= twentyPercent)
{
    Console.WriteLine($"Lucro de R${diff:F2}: \n - Entre 10% e 20% \nMensagem: \n - Lucro Médio");
}
else if (diff > twentyPercent)
{
    Console.WriteLine($"Lucro de R${diff:F2}: \n - Acima 20% \nMensagem: \n - Lucro Alto");
}


// ponto de pausa do console
Console.ReadKey();