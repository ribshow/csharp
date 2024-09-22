using exercicio04;

Console.WriteLine("Objetcs and Lists - 4");

// criando uma lista que irá receber os objetos
List<People> peopleList = new List<People>();

// criando um for para instanciar diferentes objetos dinâmicamente
for(int i = 0; i < 3; i++)
{
    Console.WriteLine("Informe um nome:");
    string? name = Console.ReadLine();

    Console.WriteLine("Informe a idade:");
    int? age = int.Parse(Console.ReadLine());

    People peoplesi = new(name, age);
    peopleList.Add(peoplesi);
}

// foreach para percorrer todos os elementos da lista
foreach(People people in peopleList)
{
    // passo a pessoa para o método show criado na classe People
    people.Show(people);
}

Console.WriteLine("");

// adicionando mais duas pessoas ao array dinamicamente
for(int j = 0; j < 2; j++)
{
    Console.WriteLine("Informe um nome:");
    string? name = Console.ReadLine();

    Console.WriteLine("Informe a idade:");
    int? age = int.Parse(Console.ReadLine());

    People peoplesj = new(name, age);
    peopleList.Add(peoplesj);
}

foreach(People people in peopleList)
{
    people.Show(people);
}

Console.WriteLine("");

// Removendo um objeto da lista, pelo seu indice
// nesse exemplo o último elemento é removido
peopleList.RemoveAt(peopleList.Count - 1);

foreach(People people in peopleList)
{
    people.Show(people);
}