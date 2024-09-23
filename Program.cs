Console.WriteLine("Tratamento de exceções!");

try
{
    Console.WriteLine("Digite o dividendo");
    int dividend = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Digite o divisor");
    int divisor = Convert.ToInt32(Console.ReadLine());

    int result = dividend / divisor;

    Console.WriteLine($"Resultado: {result}");
}catch(DivideByZeroException e)
{
    Console.WriteLine($"O divisor não pode ser 0\nError:{e.Message}");
}catch(FormatException e)
{
    Console.WriteLine($"O dividendo e o divisor devem ser números inteiros\nError:{e.Message}");
}catch(OverflowException e)
{
    Console.WriteLine($"Digite números inteiros entre 1 e 2 bilhões\nError:{e.Message}");
}catch(Exception e)
{
    Console.WriteLine(e.Message);
}
finally
{
    Console.WriteLine("Processamento finalizado!");
}
