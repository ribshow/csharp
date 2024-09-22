using System.Collections;

Console.WriteLine("ArrayList & List - Exemplo");

// criando um arraylist setando valores
ArrayList listB = new ArrayList() { "Paulin", 12, 2.5, true };

foreach(var item  in listB)
{
    Console.WriteLine(item);
}

Console.WriteLine();

// Adicionando a listB
listB.Add("Junin");

foreach (var item in listB)
{
    Console.WriteLine(item);
}


Console.WriteLine();

listB.Insert(2, DateTime.Now);

foreach (var item in listB)
{
    Console.WriteLine(item);
} 

Console.WriteLine();

int[] numbers = { 1, 2, 3, 4 };
int[] numbers2 = { 10, 20, 30, 40 };

listB.AddRange(numbers);
Console.WriteLine("Após adicionar com AddRange");

foreach(var item in listB)
{
    Console.WriteLine(item);
}

Console.WriteLine();

listB.InsertRange(0, numbers2);

Console.WriteLine("Após adicionar com listRange");
foreach(var item in listB)
{
    Console.WriteLine(item);
}

Console.WriteLine();



// declarando um array list vazio
// atualmente suas propriedades count e capacity são = 0
ArrayList list = new ArrayList();

// adicionando dados ao arraylist
list.Add("João");
list.Add(44);

// lendo os dados dentro de arraylist
for(int i = 0; i < list.Count; i++)
{
    Console.WriteLine(list[i]);
}

// criando uma lista
List<string> list2 = new List<string>();

// colocando dados usando insert
list2.Insert(0, "João");
list2.Insert(0, "Peoples");

// criando uma lista que receberá a list2
List<string> list3 = new();

// adicionando uma coleção de dados a uma lista
list3.AddRange(list2);

for(int i = 0;i < list3.Count;i++)
{
    Console.WriteLine(list3[i]);
}

// Array de 4 dimensões
// matematicamente seria uma matrix 4x4
int[,] num = new int[4, 4] { {10,9,30,342 },{22,44,55,321 }, {77,57,797,432 }, {41,31,21,33 } };


Console.WriteLine(num[0,3]);