using exercicio1;

// instanciando pessoa
//People people1 = new("Heryson");
//People people2 = new("Robert Dupreeh");
//People people3 = new("General Kingsley");

// instanciando aluno
Student student1 = new("123.547.789", "Heryson");

// instanciando author
Author author1 = new("Britânico", "Robert Dupreeh");

// instanciando editora
Publisher publisher1 = new("542.457.8779", "General Kingsley");

// instanciando publicação
Publication publication1 = new("2024-05-12", "American Pie", publisher1);
Publication publication2 = new("2005-06-22", "Piratas do Caribe", publisher1);

// definindo a editora das publicações
publication1.Publisher = publisher1;
publication2.Publisher = publisher1;

// adicionando autor nas publicações
publisher1.Publications.Add(publication1);
publisher1.Publications.Add(publication2);


// instanciando genêros
Gender gender1 = new("Comédia");
Gender gender2 = new("Ação");

// instanciando revista
Magazine magazine1 = new("12547", "254789", publication1.Date_publication, publication1.Title, publisher1);

// instanciando livros
Book book1 = new("Comédia besteirol americano", "12547", publication1.Date_publication, publication1.Title, publisher1);

Book book2 = new("Ação no caribe em 1600", "25479", publication2.Date_publication, publication2.Title, publisher1);

// adicionando o genêro dos livros
book1.Gender.Add(gender1);
book2.Gender.Add(gender2);

// instanciando empréstimo
Loan loan1 = new("2024-06-15", student1, "2024-06-30", book1);

Console.WriteLine("Empréstimo\n");
Console.WriteLine($"Aluno: {loan1.Student.Name}\nRa: {loan1.Student.Ra}");
Console.WriteLine($"Data do empréstimo: {loan1.Date_loan}");

foreach (Item loan in loan1.Items)
{
    for(var i = 0; i<loan.Books.Count; i++)
    {
        Console.WriteLine(
        $"Data da devolução: {loan.Date_return}\n" +
        $"Livro: {loan.Books[i].Title}\n" +
        $"Sinopse: {loan.Books[i].Sinopse}\n" +
        $"ISBN: {loan.Books[i].Isbn}\n" +
        $"Data da publicação: {loan.Books[i].Date_publication}\n" +
        $"Gênero: {loan.Books[i].Gender[0].Description}\n" +
        $"Editora: {loan.Books[i].Publisher.Name}\n"
        );
    }
}


Console.ReadKey();



