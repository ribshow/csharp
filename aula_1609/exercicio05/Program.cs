using exercicio05;
using System.Linq;
// ao usar decimal deve-se adicionar um "m" junto do valor para diferenciar de double
Product clips = new("Clipes", 3.95m);
Product pen = new("Caneta", 5.99m);
Product pencil = new("Lápis", 4.15m);
Product pencilcase = new("Estojo", 6.99m);
Product notebook = new("Caderno", 7.55m);

List<Product> products = new();
products.Add(clips);
products.Add(pen);
products.Add(pencil);
products.Add(pencilcase);
products.Add(notebook);

foreach(Product product in products)
{
    product.Show(product);
}

// quebra linha kkk
Console.WriteLine("");

Console.WriteLine("Soma, média e quantidade de produtos");
decimal sum = 
    products[index: 0].Sum(
        products[index: 0],
        products[index: 1],
        products[index: 2],
        products[index: 3],
        products[index: 4]
    );
Console.WriteLine($"Soma: {sum}");

decimal average =
    products[index: 0].Average(
        products[index: 0],
        products[index: 1],
        products[index: 2],
        products[index: 3],
        products[index: 4]
    );

Console.WriteLine($"Média: {average}");
Console.WriteLine($"Quantidade: {products.Count}");

// Quebra linha
Console.WriteLine("");

Product bag = new("Mochila", 22.44m);
products.Add(bag);

foreach(Product product in products)
{
    product.Show(product);
}

// quebra linha
Console.WriteLine("");

// Usando orderBy e uma expressão lambida para ordernar todos os objetos
// dentro da lista
var productsOrderned = products.OrderBy(p => p.Name).ToList();

foreach(Product product in productsOrderned)
{
    product.Show(product);
}

// quebra linha
Console.WriteLine("");

var pBiggerSeven = products.FindAll(p => p.Price < 5);

Console.WriteLine("Exibindo todos produtos cujo preço seja inferior a 5");
foreach( Product product in pBiggerSeven)
{
    product.Show(product);
}

// quebra linha
Console.Write("\n");

Console.WriteLine("Exibindo um item especificamente");
static bool pencilCase(string item)
{
    return item.Contains("Estojo");
}

foreach(Product product in products)
{
    if(pencilCase(product.Name))
    {
        product.Show(product);
    }
}


