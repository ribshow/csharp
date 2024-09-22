Console.WriteLine("Exemplo 3 - Encapsulamento");

Product product = new("Capacete", "Tam 58", 129.90);

Product product1 = new Product("Roseira", "Rosas vermelhas", 500);

Product product3 = new("Bic", "Caneta esferográfica azul", 0.89);

Console.WriteLine(
    $"Produto: {product3.Name} - " +
    $"Descrição: {product3.Descrption}" +
    $"Preço: {product3.Price} - " +
    $"Tipo: {product3.Type} - " +
    $"Desconto: R${product3._Discount},00 - " +
    $"Preço com desconto R${product3.PriceWithDescount().ToString("F2")}");

Console.WriteLine(
    $"Produto: {product.Name} - "
    + $"Descrição: {product.Descrption} - "
    + $"Preço: {product.Price} - "
    + $"Tipo: {product.Type} - "
    + $"Desconto: R${product._Discount},00 - "
    // ToString("F2") indica o número de casas decimais
    + $"Preço com desconto R${product.PriceWithDescount().ToString("F2")}");

Console.WriteLine(
    $"Produto: {product1.Name} - " +
    $"Descrição: {product1.Descrption} - " +
    $"Preço: {product1.Price} - " +
    $"Desconto: R${product._Discount},00 - " +
    $"Tipo: {product1.Type} - " +
    $"Preço com desconto: R${product1.PriceWithDescount().ToString("F2")}");


Console.ReadKey();

/*O problema principal no seu código é que você está tentando usar a propriedade Name 
 * como um campo de armazenamento e ao mesmo tempo como um getter e setter. Isso cria 
 * um loop recursivo infinito e, portanto, não funciona como esperado. Para corrigir isso
 * , você precisa usar um campo de apoio privado para armazenar o valor da propriedade Name.  */

public class Product
{
    // para incluir uma validação, você deve criar um atributo que irá ser testado
    // e outro para exibir o retorno após a validação
    private string? _name;
    public string? Name 
    { 
        get { return _name; }
        set 
        {
            if (value?.Length >= 4)
            {
                _name = value;
            }
            else
            {
                Console.WriteLine("Nome possuí menos de 4 caracteres, valor não atribuído");
            }
        } 
    }
    // o método static não pode ser public
    // criar o método static e depois criar um método público que irá manipulá-lo
    private static readonly string type = "Tipo A";

    public string? Type
    {
        get { return type; }
    }

    // método static para Discount
    private static int Discount = 10;
    // método public que retorna o Discount
    public int _Discount
    {
        get { return Discount; }
    }

    public string? Descrption { get; set; }
    public double Price { get; private set; }

    // método construtor da classe Product
    public Product(string name, string description, double price)
    {
        Name = name;
        Descrption = description;
        Price = price;
    }

    // método interno que que calcula o desconto entre os atributos
    // price e discount
    public double PriceWithDescount()
    {
        return Price - Price * Discount / 100;
    }
}