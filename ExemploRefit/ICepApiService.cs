using System.Threading.Tasks;
using Refit;
namespace ExemploRefit
{
    public interface ICepApiService
    {
        [Get("/ws/{cep}/json")]
        Task<CepResponse> GetAddresAsync(string cep);
    }
}
 