using Refit;

namespace HttpClientApi.Integration.Refit
{
    public interface ICepRefit
    {
        [Get("/ws/{cep}/json")]
        Task<ApiResponse<CepModel>> GetResponseAsync(string cep);
    }
}
