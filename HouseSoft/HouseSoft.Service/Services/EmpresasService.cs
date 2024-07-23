using Microsoft.EntityFrameworkCore;
using Teste_Playmove.Data.Context;
using Teste_Playmove.Domain.Entity;
using Teste_Playmove.Domain.Interface;

namespace Teste_Playmove.Service.Services
{
    public class EmpresasService : IEmpresas
    {
        private readonly Context _context;

        public EmpresasService(Context options)
        {
            _context = options;
        }

        public async Task<List<Empresas>> GetEmpresas()
        {
            try
            {
                var listarEmpresas = await _context.Empresas
                .OrderBy(u => u.Id_Empresa).ToListAsync();

                if (listarEmpresas == null)
                {
                    return new List<Empresas>();
                }

                return listarEmpresas;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao obter lista de Fornecedores: {ex.Message}");
                return new List<Empresas>();
            }
        }       

        public async Task<Empresas> GetEmpresaId(int id)
        {
            try
            {
                var fornecedorId = await _context.Empresas
                    .Where(u => u.Id_Empresa == id)
                    .FirstOrDefaultAsync();

                if (fornecedorId == null)
                {

                    return new Empresas();
                }

                return fornecedorId;
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Erro ao obter fornecedor por ID: {ex.Message}");
                return new Empresas();
            }
        }

        public async Task SalvarEmpresa(Empresas model)
        {   
            try
            {
                // Utilizado para fazer update alteração no user.
                if (model.Id_Empresa > 0)
                {
                    _context.Update(model);
                }
                else
                {
                    var existingUser = await _context.Empresas.FirstOrDefaultAsync(u => u.Nome_Empresa == model.Nome_Empresa);
                    if (existingUser != null)
                    {
                        throw new Exception("Empresa já cadastrada.");
                    }
                    _context.Add(model);
                }

                await _context.SaveChangesAsync();

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao salvar empresa: {ex.Message}");

            }
        }

        public async Task<bool> UpdateEmpresa(int id, Empresas empresaAtualizada)
        {
            try
            {
                var empresaUpdate = await _context.Empresas.FirstOrDefaultAsync(x => x.Id_Empresa == id);
                if (empresaUpdate != null)
                {
                   empresaUpdate.Nome_Empresa = empresaAtualizada.Nome_Empresa;
                   empresaUpdate.Endereco = empresaAtualizada.Endereco;
                   empresaUpdate.Telefone = empresaAtualizada.Telefone;
                   empresaUpdate.Email = empresaAtualizada.Email;

                    await _context.SaveChangesAsync();
                    return true;

                }
                else
                {
                    throw new ApplicationException($"Empresa com ID {id} não encontrada.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao salvar empresa.", ex);
            }
        }

        public async Task<bool> DeletarEmpresa(int id)
        {
            try
            {
                var empresa = await _context.Empresas.FindAsync(id);
                if (empresa == null)
                {
                    return false;
                }
                else
                {
                    _context.Empresas.Remove(empresa);
                    await _context.SaveChangesAsync();
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao salvar empresa.", ex);
            }
        }

    }

}
