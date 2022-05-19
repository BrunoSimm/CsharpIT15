try
{
    // var result = await ViaCepConsumidor.Consultar("90240650");
    // var dados = await result.Content.ReadAsStringAsync();
    // Console.WriteLine(dados);

    // var dados = await ViaCepConsumidor.ConsultarV2("90240650");
    // Console.WriteLine(dados);

    var dados = await ViaCepConsumidor.ConsultarV3("90240650");
    Console.WriteLine(dados);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}