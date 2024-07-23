using Microsoft.AspNetCore.Mvc;
using Teste_Playmove.Domain.Entity;
using Teste_Playmove.Domain.Interface;

namespace Teste_Playmove.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class FornecedoresController : ControllerBase
    {

        private readonly IFornecedores _fornecedores;

       public FornecedoresController(IFornecedores fornecedoresService)
        {
            _fornecedores = fornecedoresService;
      
        }       

        [HttpGet("listarFornecedores")]
        public async Task<List<Fornecedores>> GetFornecedores()
        {
            try
            {
                var result = await _fornecedores.GetFornecedores();

                return result;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro interno ao listar fornecedores.", ex);
            }
        }

        [HttpGet("listarFornecedoresId/{id}")]
        public async Task<IActionResult> ListarFornecedoresId(int id)
        {
            try
            {
                var result = await _fornecedores.GetFornecedoresId(id);
                return Ok(result);
            }
            catch (Exception ex)
            {

                throw new Exception("Erro interno ao obter fornecedores.", ex);
            }
        }

        [HttpPost("salvarFornecedor")]
        public async Task<IActionResult> SalvarFornecedor(Fornecedores model)
        {
            try
            {

                await _fornecedores.SalvarFornecedor(model);
                return Ok();                  
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao salvar fornecedor.", ex);
            }
        }

        [HttpPut("updateFornecedor")]
        public async Task<ActionResult> UpdateFornecedor(int id, Fornecedores fornecedorAtualizado)
        {
            try
            {
                var fornecedoreUpdate = await _fornecedores.UpdateFornecedor(id, fornecedorAtualizado);

                if (fornecedoreUpdate)
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
                throw new Exception("Erro ao alterar o fornecedor.", ex);
            }
        }

        [HttpDelete("deletarFornecedor/{id}")]
        public async Task<ActionResult> DeletarFornecedor(int id)
        {
            try
            {
                var fornecedoresDelete = await _fornecedores.DeletarFornecedor(id);

                return fornecedoresDelete? (ActionResult)Ok() : (ActionResult)BadRequest();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro interno ao deletar fornecedor.", ex);
            }
        }






    }
}
