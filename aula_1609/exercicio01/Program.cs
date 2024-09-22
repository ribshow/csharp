using System.Collections.Immutable;

Console.WriteLine("Exercício 01");

// declarando um array e o incializando com 10 frutas
string[] fruits = new string[10]
{
    "Maçã", "Banana", "Laranja", "Uva", "Manga", "Pêra", "Abacate","Mamão","Pêssego","Amora"
};

Console.WriteLine("Exibindo os nomes da segunda e da penúltima fruta\n");

// exibindo as frutas pelos seus respectivos indices
Console.WriteLine(
    $"Segunda fruta no array: {fruits[1]}\n" +
    $"Penúltima fruta no array: {fruits[8]}\n");

Console.WriteLine("Alterando o nome da terceira fruta para Kiwi e da última fruta para Caqui e exibindo todas");

// alterando os valores pelo indice do array
fruits[2] = "Kiwi";
fruits[9] = "Caqui";

// usando um foreach para exibir cada elemento dentro do array
foreach (string fruit in fruits)
{
    Console.WriteLine($"{fruit}");
}

Console.WriteLine("\nExiba o nome das frutas no console e a quantidade de elementos do array usando os laços" +
    "for e foreach");
// Percorre todo o array de acordo com o valor de i e o exibe no console junto com o tamanho do array
for(int i = 0; i < fruits.Length; i++)
{
    Console.WriteLine($"{i + 1}-{fruits[i]} - Tamanho do Array: {fruits.Length}");
}

Console.WriteLine("\nOrdene a coleção de frutas na ordem ascendente");

// array sort ordena os itens do array em uma lista ascendente crescente
Array.Sort(fruits);

foreach (string fruit in fruits)
{
    Console.WriteLine(fruit);
}

Console.WriteLine("\nExibindo o array de frutas na ordem inversa");

// Usando um for para percorrer o array de modo inverso
// Nesse caso i iniciliza com valor 9 e soferá um decremento de - 1 a cada passagem do loop
// enquanto o i for maior ou = a 0
for(int i = 9;i >= 0;i--)
{
    Console.WriteLine($"{fruits[i]}");
}

Console.ReadKey();
