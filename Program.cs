using exercicio;

Account account = new(1234567, "José Ailton", 500.50m);
int value = 600;
try
{
    account.Retire(account, value);
    throw new OperatorException();
}
catch(OperatorException e)
{
    Console.WriteLine(e.Message);
}

