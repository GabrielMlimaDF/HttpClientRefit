using HttpClientApi.Integration.Interfaces;
using HttpClientApi.Integration.Refit;
using Microsoft.AspNetCore.Mvc;

namespace HttpClientApi.Controller
{

    [ApiController]
    public class RequestController: ControllerBase
    {
        private readonly ICepIntegracao _cepIntegracao;

        public RequestController(ICepIntegracao cepIntegracao)
        {
            _cepIntegracao = cepIntegracao;
        }

        [HttpGet("/v1/cep/{cep}")]
        public async Task<IActionResult> Get(string cep)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                var responseCep = await _cepIntegracao.ObterCep(cep);
                if (responseCep == null)
                {
                    return BadRequest("Erro no cep!");
                }
                return Ok(responseCep);
            }
            catch (Exception ex)
            {

                return BadRequest(ex);
            }


        }
    }
}
