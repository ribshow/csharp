Console.WriteLine("Exemplo 8 - Associação");

// INSTANCIANDO ESTUDANTES
Student student = new(12547854, "Heryson", "457897458", "14998784599");
Student student2 = new(1254784, "Joseilton", "547841542", "1498784524");

// INSTANCIANDO PROFESSOR
Professor professor = new("Mestre", "William Bigode", "154789754", "254784781");

// INSTANCIANDO CURSO
Course course = new("Desenvolvimento de Software Multiplataforma", "6 semestres", professor);

// adicionando estudantes ao curso
course.Students.Add(student);
course.Students.Add(student2);

// adicionando um curso ao estudante
student.Courses.Add(course);

// exibindo dados do curso
Console.WriteLine(
    $"Curso: {course.Course_Name}\n" +
    $"Carga horária: {course.Workload}\n" +
    $"Professor titular: {course.Professor.Name} \n" +
    $"Titulação: {course.Professor.Titration}\n" +
    $"Alunos: "
    );

// exemplo com foreach
foreach (var students in course.Students)
{
    Console.WriteLine(students.Name);
}

// espaço no console
Console.WriteLine();

// exibindo dados do aluno
Console.WriteLine(
    $"Nome: {student.Name}\n" +
    $"CPF: {student.Cpf}\n" +
    $"Telefone: {student.Phone}\n" +
    $"Registro: {student.Register}\n" +
    $"Curso:"
    );

foreach(var courses in student.Courses)
{
    Console.WriteLine(courses.Course_Name);
}



Console.ReadKey();

// Criando a classe Pessoas
// a classe pessoas possuí três atributos, nome, cpf e telefone
public class People
{
    public string? Name;

    public string? Cpf;

    public string? Phone;

    // método construtor da classe pessoa, você não consegue instanciar a classe
    // sem obrigatoriamente declarar os três atributos requeridos do método construtor
    public People(string? name, string? cpf, string? phone)
    {
        Name = name;
        Cpf = cpf;
        Phone = phone;
    }

}

// Criando a classe professor que herda os atributos de pessoa
// a classe professor só tem um atributo próprio, que é o título do professor
public class Professor : People
{
    public string? Titration;
    // o : base indica para o contrutor que ele deve buscar nome,cpf e telefone na classe pessoa
    // Você não precisa atribuir valores aos atributos herdados, pois isso já foi feito na classe pai(PESSOA)
    public Professor(string? titration, string? Name, string? Cpf, string? Phone) : base(Name, Cpf, Phone)
    {
        Titration = titration;
    }
}

// Criando a classe estudante que herda os atributos de pessoa
// estudante só possuí um atributo próprio que é seu número de registro
public class Student : People
{
    public int Register;
    // Associação bidirecional, estudante recebe curso
    public List<Course> Courses { get; set; } = new List<Course>();
    // o : base indica para o contrutor que ele deve buscar nome,cpf e telefone na classe pessoa
    // Você não precisa atribuir valores aos atributos herdados, pois isso já foi feito na classe pai(PESSOA)
    public Student(int register, string? Name, string? Cpf, string? Phone)
        : base(Name,Cpf,Phone)
    {
        Register = register;
    }
}

// criando a classe course, que está associada a professor e a estudante
// a associação com professor é unidirecional/unária, um curso possuí um professor
public class Course
{
    public string? Course_Name;
    // workload = carga horária
    public string? Workload;
    // Associação unidirecional, curso recebe um professor
    public Professor? Professor { get; set; }
    // Associação bidirecional, curso recebe aluno e aluno recebe curso
    public List<Student> Students { get; set; }

    public Course(string? course_name, string? workload, Professor _professor)
    {
        Course_Name = course_name;
        Workload = workload;
        Professor = _professor;
        Students = new List<Student>();
    }
}
