using Teste_Playmove.Domain.Entity;

namespace Teste_Playmove.Domain.Interface
{
    public interface IFornecedores
    {
        Task<List<Fornecedores>> GetFornecedores();
        Task<Fornecedores> GetFornecedoresId(int id);
        Task SalvarFornecedor(Fornecedores model);
        Task<bool> UpdateFornecedor(int id, Fornecedores fornecedorAtualizado);
        Task<bool> DeletarFornecedor(int id);
    }
}
