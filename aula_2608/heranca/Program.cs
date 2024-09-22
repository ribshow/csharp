Console.WriteLine("Exemplo 5 - Herança");

Teacher teacher = new("Mestre", "Tiago");
Console.WriteLine($"Professor: {teacher.Name} - Titulação: {teacher.Titration}");



Console.ReadKey();

public class People
{
    public string? Name;

    public People(string? name)
    {
        Name = name;
    }
}

public class Teacher : People
{
    // Tritation = Titulação
    public string? Titration;

    public Teacher(string? titration, string? Name) : base(Name)
    {
        Titration = titration;
    }
}