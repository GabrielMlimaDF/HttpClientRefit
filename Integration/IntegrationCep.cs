using HttpClientApi.Integration.Interfaces;
using HttpClientApi.Integration.Refit;

namespace HttpClientApi.Integration
{
    public class IntegrationCep : ICepIntegracao
    {
        private readonly ICepRefit _cepRefit;

        public IntegrationCep(ICepRefit cepRefit)
        {
            _cepRefit = cepRefit;
        }

        public async Task<CepModel> ObterCep(string cep)
        {
            var responseCep = await _cepRefit.GetResponseAsync(cep);
            if (responseCep != null && responseCep.IsSuccessStatusCode)
            {
                return responseCep.Content;
            }
            return null;
        }
    }
}
