namespace HttpClientApi.Integration.Interfaces
{
    public interface ICepIntegracao
    {
        Task<CepModel> ObterCep(string cep);
    }
}
