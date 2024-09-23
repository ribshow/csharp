using excecaoPersonalizada;

try
{
    throw new CustomException("Minha exceção personalizada!");
}
catch(CustomException e)
{
    Console.WriteLine(e.Message);
    Console.WriteLine(e.StackTrace);
}
finally
{
    Console.WriteLine("Fim");
}