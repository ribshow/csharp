Console.WriteLine("Exemplo 6 - Arrays (Matrizes)");

string[] store = new string[4];

string[] cars = new string[4] { "Uno", "Punto", "Up", "Duster" };

for(int i = 0; i < cars.Length; i++)
{
    store[i] = cars[i];
    Console.WriteLine($"Carro {cars[i]} adicionando ao estaciomento.");
}

Console.ReadKey();

