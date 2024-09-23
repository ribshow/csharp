try
{
    Console.WriteLine("Digite da URL da página: ");
    string? url = Console.ReadLine();
    // criando uma requisição 
    HttpClient client = new();
    // caputrando a requisição e recebendo o resultado
    HttpResponseMessage response = client.GetAsync(url).Result;

    // Em caso de sucesso
    if(response.IsSuccessStatusCode)
    {
        Console.WriteLine("Acesso bem sucedido");
        // retorna uma string
        Console.WriteLine("Código Status" + response.StatusCode);
    }
    else
    {
        // retorna o código do erro
        throw new HttpRequestException("Erro:" + (int)response.StatusCode);
    }
}// filtrando código erro 404
catch(HttpRequestException e) when (e.Message.Contains("404"))
{
    Console.WriteLine("Página não encontrada " + e.Message);
}// filtrando código erro 400
catch(HttpRequestException e) when (e.Message.Contains("400"))
{
    Console.WriteLine("Requisição inválida " + e.Message);
}// capturando outros erros genéricos
catch(Exception e)
{
    Console.WriteLine(e.Message);
}
finally
{
    Console.WriteLine("Fim");
}
