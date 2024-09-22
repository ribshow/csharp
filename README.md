**C# tem dois conceitos, solução e projeto:**
  - Solução é um conjunto de projetos
  - Projeto é criado a partir de um template

**Verificar se existe dotnet instalado:**
  - dotnet --version

**Comandos principais**
  - dotnet --list-sdks (todas versões instaladas)

  - dotnet new --list (todos os templates de projetos)

  - dotnet new (os principais templates instalados)

  - dotnet --info (informações sobre o dotnet)

  - dotnet run (para rodar um projeto)

  - dotnet new sln -o name_solution (Para criar uma solução)

  - dotnet new console -o name_project (Para criar um projeto para console)

  (Vincula o projeto à solução)
  - dotnet sln name_solu.sln add name_project/name_project.csproj

**Fundamentos do C#**
  - Tipos de dados básicos (int, boolean...) são criados na área da memória STACK(usa modelo lifo)

  - Tipos como (string, object, array, dinamic) são tipos por referência e são guardados na área da memória HEAP

  **Alguns tipos de dados'**
  Alias     /  tipo dotnet
  - int         System.Int32          valor padrão 0          Stack
  - double  /   System.Double         valor padrão 0          Stack
  - bool    /   System.Boolean        valor padrão false      Stack
  - char    /   System.Char(usar '')  valor padrão \0(u+0000) Stack
  - string  /   System.String(user "")valor padrão null       Heap
  - DateTime/ valor padrão 01/01/0001 00:00:00                Stack

  **Nullable Types(tipos nulos)**
  - nullable <tipo><nome_variavel> = null;
  - nullable <int> x = null;
  - int? x = null; (simplificado)
  - int? x = null; (declarei x como nulo)
  - int a = x ?? 0; (atribui x para A, se x for nulo será atribuido 0)

  **Classes**
  - public class Nome {
    "atributos"

    "metodos"
  }

  - public class Name
  {
    // atributo
    - public int Id { get; set; }

    // metodo
    - Se não houver tipo usar void
    - public int Receive() {}
  }

  - Caso atributo e parâmetro possuam a mesma grafia é necessário
  usar this para fazer referência this.name = name;
  
  **Uso do this**
  - Pode ser usado para identificar atributo
  - Para evitar redundância dentro dos construtores
  - Identificar o objeto

  **Instanciando objetos**
  - className variableName = new className();
  - var variableName = new className();
  - className variableName = new();

  # Array

  - Os arrays(matrizes) são de um tipo só
  - São criadas memórias heap
  - A inicialização é opcional
  - A quantidade é obrigatória
  - string[] cars = new string[4]{"Uno","Punto","Up","Duster"};
  - Usa-se para saber a quantidade length
  - for(int i=0; i < cars.length; i++){}

  # List

  - São armazenadas na memória heap
  - São dinâmicas
  - Usa-se count para saber a quantidade de Elementos
  - List <type> nameList = new List <type>();

  **Para adicionar elementos a lista**
  - nameList.Add(valor);
  - nameList.Insert(indice, valor);
  - nameList.AddRange(coleção);
  - nameList.InsertRange(indice, coleção);

  **Para remover da lista**
  - nameList.Remove(valor);

  **Para procurar na lista**
  - Find() - retorna o primeiro elemento que corresponda ao predicado fornecido
  - FindLast() - retorna o útlimo elemento que corresponda ao predicado fornecido
  - FindIndex()- retorna o índice do 1° elemento que corresponda ao predicado fornecido
  - FindAll() - retorna todos os elementos que corresponda ao predicado fornecido

  **O que é**
  - Predicado: é uma função/método de argumento único que retorna booleano
  - Expressão lambda: é uma função anônima
  
  # Arrays Multidimensionais

  - Declaração:
  - Duas dimensões =>
  - tipo [,] nome;
  - Três dimensões =>
  - tipo [,,] nome;

  **Exemplos**
  - int [,] a = new int [2,2] {{0,1}, {1,2}};
  - int [,] á = {{0,1}, {1,2}};

  - Referência : a[0,1]

  **Para obter as dimensões:**
  - a.GetLength(0) -> número de linhas
  - a.GetLength(1) -> número de colunas

  # ArrayList
  - Ele aceita diferentes tipos de dados, porém diminui a performance

  **Todo ArrayList possuí duas propriedades, sendo elas**
  - count = 0
  - capacity = 0

  **Declaração**
  - ArrayList()
  - ArrayList(int) -> o int é a propriedade(capacidade)
  - ArrayList(ICollection)

  **Exemplos**
  - ArrayList lista = new ArrayList();
  - ArrayList lista = new();
  - ArrayList lista = new ArrayList(5);

  **Para adicionar dados ao ArrayList**
  - lista.Add("Jubileu")
  - lista.Add(4)
  - ArrayList lista = new ArrayList(){"Paulo,15,2.4,true};

# List & ArrayList

**Adicionar lista** 
- Add
- Insert
- AddRange
- InsertRange

**Remover da lista**
- Remove(valor)
- RemoveAt(Index)
- RemoveRange(Index,count)
- Remove.Clear() -> Remove tudo

**Verificar se existe na lista**
- Contains(o que procurar) -> retorna true ou false

**Ordenar**
- Em ArrayList só funciona se todos os valores forem do mesmo tipo
- Sort() - de forma ascendente

