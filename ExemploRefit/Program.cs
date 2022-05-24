using System;
using Refit;
using System.Threading.Tasks;

namespace ExemploRefit 
{
    class MainClass
    {
         static async Task Main(string[] args)
         {
            try
            {
                var cepClient = RestService.For<ICepApiService>("https://viacep.com.br");
                Console.WriteLine("Informe seu CEP:");

                string cepInformado = Console.ReadLine().ToString();
                Console.WriteLine("Consutando informações do CEP: " + cepInformado);

                var address = await cepClient.GetAddresAsync(cepInformado);

                Console.WriteLine($"\nLogradouro:{address.Logradouro}, \nBairro: {address.Bairro}, \nCidade: {address.Localidade} ");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro na consulta de CEP: " + e.Message);

            }
        }
    }


}
