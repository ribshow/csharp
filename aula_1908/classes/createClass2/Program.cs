Console.WriteLine("Exemplo 2 - Passagem parâmetro por valor e referência");
Calculator calc = new();
int n1 = 1;
int n2 = 2;
int n3 = 3;

calc.Sum(n1,n2);
Console.WriteLine(calc.Sum(n1,n3));

calc.SumRef(ref n1,ref n2,ref n3);
Console.WriteLine(calc.SumRef(ref n1,ref n2,ref n3));

Console.ReadKey();

public class Calculator
{
    //
    public int Sum(int n1, int n2)
    {
        return n1+n2;
    }

    public int SumRef(ref int n1, ref int n2, ref int n3)
    {
        n3 = 5;
        return n1 + n2 + n3;
    }
}