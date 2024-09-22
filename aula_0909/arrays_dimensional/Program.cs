
Console.WriteLine("Arrays dimensionais - Exemplo");

// declarando um array dimensional de 2 linhas e 2 colunas
// utilizando new int e especificando seu número de linha e colunas
// dessa forma ele não precisa ser inicializado com valores
// dessa forma ele não precisa ser inicializado com valores
int[,] ints = new int[2, 2] { {22,33}, {44,55 } };

for(int i = 0; i < ints.GetLength(0); i++)
{
    for(int j = 0; j < ints.GetLength(1); j++)
    {
        Console.WriteLine(ints[i, j]);
    }
}

// Declarando um array dimensional sem especificar sua dimensão
// dessa forma ele precisa ser inicilizado com valores sempre
// e serão eles que irão definir o número de dimensões do array
string[,] names = { { "José", "Raimundo", "Bethoven" }, { "Arleilton", "Thomas", "Simas" } };

foreach(string name in names)
{
    Console.WriteLine(name);
}
