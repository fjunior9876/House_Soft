using Microsoft.AspNetCore.Mvc;
using Teste_Playmove.Domain.Entity;
using Teste_Playmove.Domain.Interface;

namespace Teste_Playmove.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class EmpresasController : ControllerBase
    {

        private readonly IEmpresas _empresas;

       public EmpresasController(IEmpresas empresasService)
        {
            _empresas = empresasService;
      
        }

        [HttpGet("listarEmpresas")]
        public async Task<List<Empresas>> GetEmpresas()
        {
            try
            {
                var result = await _empresas.GetEmpresas();

                return result;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro interno ao listar empresas.", ex);
            }
        }

        [HttpGet("listarEmpresasId/{id}")]
        public async Task<IActionResult> ListarEmpresasId(int id)
        {
            try
            {
                var result = await _empresas.GetEmpresaId(id);
                return Ok(result);
            }
            catch (Exception ex)
            {

                throw new Exception("Erro interno ao obter empresa.", ex);
            }
        }

        [HttpPost("salvarEmpresa")]
        public async Task<IActionResult> SalvarEmpresa(Empresas model)
        {
            try
            {

                await _empresas.SalvarEmpresa(model);
                return Ok();                  
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao salvar empresa.", ex);
            }
        }

        [HttpPut("updateEmpresa")]
        public async Task<ActionResult> UpdateEmpresa(int id, Empresas empresaAtualizada)
        {
            try
            {
                var empresasUpdate = await _empresas.UpdateEmpresa(id, empresaAtualizada);

                if (empresasUpdate)
                {
                    return Ok();
                }
                else
                {
                    return BadRequest();
                }
            }

            catch (Exception ex)
            {
                throw new Exception("Erro ao alterar a empresa.", ex);
            }
        }

        [HttpDelete("deletarEmpresa/{id}")]
        public async Task<ActionResult> DeletarEmpresa(int id)
        {
            try
            {
                var empresasDelete = await _empresas.DeletarEmpresa(id); 

                return empresasDelete ? (ActionResult)Ok() : (ActionResult)BadRequest();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro interno ao deletar empresa.", ex);
            }
        }






    }
}
