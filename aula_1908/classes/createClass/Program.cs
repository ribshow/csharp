Console.WriteLine("Exemplo de Classe");

// Three forms of instance an object
Client customer1 = new Client(1,"Heryson", "444.555.333-12");
var customer2 = new Client(2, "444.555.333-12");
Client customer3 = new();

// inserting values into the object
customer3.Id = 3;
customer3.Name = "Heryson Andrade";
customer3.Cpf = "444.555.333-22";

Console.WriteLine("Id = " + customer1.Id);
Console.WriteLine("Name = " + customer1.Name);
Console.WriteLine("Cpf = " + customer1.Cpf);

Console.WriteLine("Id = " + customer2.Id);
Console.WriteLine("Name = " + customer2.Name);
Console.WriteLine("Cpf = " + customer2.Cpf );

Console.WriteLine("Id = " + customer3.Id);
Console.WriteLine("Name = " + customer3.Name);
Console.WriteLine("Cpf = " + customer3.Cpf);

// call method Show
customer1.Show(customer1);
customer1.ShowObject();






Console.ReadKey();

public class Client
{
    // attributes
    public int Id { get; set; }
    public string? Name { get; set; }

    public string? Cpf { get; set; }
    // methods
    // passing an object to the method
    public void Show(Client cus)
    {
        // I can instance one object into the method
        //Client customer4 = new(4, "Heryson");
        //Console.WriteLine($" Customer = {customer4.Id} Name = {customer4.Name}");
        Console.WriteLine($" Id: {cus.Id} - Name = {cus.Name} - CPF: {cus.Cpf}");
    }
    public void ShowObject()
    {
        Show(this);
    }

    // constructor methods that initializes with id and name
    public Client(int id, string? name, string? cpf):this(id, cpf)
    {
        // If attribute and parameter have the same writing, it necessary
        // use this to do reference at attribute
        // Caso o atributo e o parâmetro possuam a mesma grafia
        // é obrigatório o uso do this para fazer referência ao atributo
        // this.id = id; / this.name = name;
        //Id = id;
        Name = name;
    }

    // constructor method that initializes with id
    public Client(int id, string? cpf)
    {
        Id = id;
        Cpf = cpf;
    }
    /* public Client(ind id)=> id; */

    // constructor method default, empty
    public Client(){}
}
