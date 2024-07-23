using Teste_Playmove.Domain.Entity;

namespace Teste_Playmove.Domain.Interface
{
    public interface IEmpresas
    {
        Task<List<Empresas>> GetEmpresas();
        Task<Empresas> GetEmpresaId(int id);
        Task SalvarEmpresa(Empresas model);
        Task<bool> UpdateEmpresa(int id, Empresas empresaAtualizada);
        Task<bool> DeletarEmpresa(int id);
    }
}
