using System.Net.Http.Json;

public static class ViaCepConsumidor
{
    public const string URI_BASE = "https://viacep.com.br/ws";
    private static readonly HttpClient client = new HttpClient();

    public static Task<HttpResponseMessage> Consultar(string cep)
    {
        var uri = $"{URI_BASE}/{cep}/json";
        return client.GetAsync(uri);
    }

    public static async Task<string> ConsultarV2(string cep)
    {
        var uri = $"{URI_BASE}/{cep}/json";
        var result = await client.GetAsync(uri);
        if (!result.IsSuccessStatusCode)
        {
            throw new Exception("Falha na consulta ao ViaCep");
        }
        var dados = await result.Content.ReadAsStringAsync();
        return dados;
    }

    public static async Task<ViaCepResposta?> ConsultarV3(string cep)
    {
        var uri = $"{URI_BASE}/{cep}/json";
        var result = await client.GetAsync(uri);
        if (!result.IsSuccessStatusCode)
        {
            throw new Exception("Falha na consulta ao ViaCep");
        }
        return await result.Content.ReadFromJsonAsync<ViaCepResposta>();

    }
}