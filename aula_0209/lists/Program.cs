Console.WriteLine("Exemplo 7 - Lists (Listas)");


string[] numbers =  new string[10]{ "1", "2", "3", "5" , "7", "8", "9", "10", "4", "6" };
List<int> totalIntegers = new List<int>();

totalIntegers.Add(2);
totalIntegers.Add(3);

for(int i = 0; i < totalIntegers.Count; i++)
{
    Console.WriteLine(totalIntegers[i]);
}

Console.ReadKey();