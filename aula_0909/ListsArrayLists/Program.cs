using System.Collections;

Console.WriteLine("Lists & ArrayLists - Exemplos");

List<string> names = new List<string>() {"Bruce", "Barry", "Peter", "Oliver", "Kara" };
List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };

foreach (string name in names)
{
    Console.WriteLine(name);
}

// Removendo da lista com base em valor
names.Remove("Bruce"); // remove o bruce

// Removendo da lista com base em indice
names.RemoveAt(1); // remove o elemento 2 da lista, porém como indice começa em 0 1 é 2 aqui

names.RemoveRange(0, 2); // remove 2 elementos a partir do indice 0

Console.WriteLine();

foreach (string name in names)
{
    Console.WriteLine(name);
}

// limpando a lista
names.Clear();

Console.WriteLine(names.Count);

List<string> cars =  new List<string>() {"Uno", "Gol Bolinha", "Gol Quadrado","Peugeot","Fiat-147", "Punto" };

Console.WriteLine(cars.Contains("Gol Bolinha"));

cars.Sort();

foreach(string car in cars)
{
    Console.WriteLine(car);
}

Console.WriteLine();

// predicado
static bool findCars(string item)
{
    return item.Contains('l');
    //return item.StartsWith('G');
}

// retorna a primeira correspondência ao predicado passado nesse caso "findCars"
Console.WriteLine(cars.Find(findCars));

// retorna a útlima correspondência ao predicado passado nesse caso "findCars"
Console.WriteLine(cars.FindLast(findCars));

// FindIndex Retorna o indice do primeiro elemento que corresponder ao predicado
Console.WriteLine(cars[cars.FindIndex(findCars)]);

// retornando todos os parâmetros que correspondem com a busca
foreach (string car in cars.FindAll(findCars)){
    Console.WriteLine(car);
}

// Usando expressão lambda
// essa função retorna a primeira ocorrência do prendicado "P" informado
// nesse caso o retorno será Peugeot
string? return6 = cars.Find(i => i.Contains('P'));

Console.WriteLine($"Retonro 6 \n {return6}");

// retorna o primeiro número maior que 3 na lista de numbers
int return7 = numbers.Find(i => i > 3);

Console.WriteLine($"Retorno 7 \n {return7}");