Console.WriteLine("Bem vindo ao cálculo de nota fácil.exe");

// declaração de variáveis para calcular as médias
float grade1 = 0;
float grade2 = 0;
float gradeGroup1 = 0;
float gradeGroup2 = 0;
float averageGroup1 = 0;
float averageGroup2 = 0;


// o array é flexível e o usuário escolhe quantos grupos terão
// e quantas alunos terão cada grupo
// número de grupos  = linha
// número de alunos = coluna
Console.WriteLine("Digite o número de grupos (linhas):");
int groups = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o número de alunos por grupo (colunas):");
int students = int.Parse(Console.ReadLine());

// criando o array dimensional que irá armazenar todos os dados
float[,] gradesArray = new float[groups, students];

// Recebendo as notas do grupo 01
for(int i = 0; i < students; i++)
{
    Console.WriteLine($"Digite a nota do aluno: {i + 1}");
    gradesArray[0, i] = float.Parse(Console.ReadLine());
}

// recebendo as notas do grupo 02
for(int j = 0; j < students; j++)
{
    Console.WriteLine($"Digite a nota do aluno: {j + 1}");
    gradesArray[1, j] = float.Parse(Console.ReadLine());
}

// calculando a média das notas no grupo 1
for(int k = 0; k < gradesArray.GetLength(1); k++)
{
    grade1 = gradesArray[0, k];
    gradeGroup1 += grade1;
}

averageGroup1 = gradeGroup1 / gradesArray.GetLength(1);
Console.WriteLine($"A média das notas do grupo 1 é de: {averageGroup1}");

// calculando a média das notas no grupo 2
for (int l = 0; l < gradesArray.GetLength(1); l++)
{
    grade2 = gradesArray[1, l];
    gradeGroup2 += grade2;
}

averageGroup2 = gradeGroup2 / gradesArray.GetLength(1);
Console.WriteLine($"A média das notas do grupo 2 é de : {averageGroup2}");
