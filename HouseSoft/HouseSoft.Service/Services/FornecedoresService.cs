using Microsoft.EntityFrameworkCore;
using Teste_Playmove.Data.Context;
using Teste_Playmove.Domain.Entity;
using Teste_Playmove.Domain.Interface;

namespace Teste_Playmove.Service.Services
{
    public class FornecedoresService : IFornecedores
    {

        private readonly Context _context;

        public FornecedoresService(Context options)
        {
            _context = options;
        }

        public async Task<List<Fornecedores>> GetFornecedores()
        {
            try
            {         
                var listarFornecedores = await _context.Fornecedores
                .OrderBy(u => u.Id_Fornecedor)
                .ToListAsync();

                if (listarFornecedores == null)
                {
                    return new List<Fornecedores>();
                }

                return listarFornecedores;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao obter lista de Fornecedores: {ex.Message}");
                return new List<Fornecedores>();
            }
        }

        public async Task<Fornecedores> GetFornecedoresId(int id)
        {
            try
            {
                var fornecedorId = await _context.Fornecedores
                    .Where(u => u.Id_Fornecedor == id)
                    .FirstOrDefaultAsync();

                if (fornecedorId == null)
                {

                    return new Fornecedores();
                }

                return fornecedorId;
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Erro ao obter fornecedor por ID: {ex.Message}");
                return new Fornecedores();
            }
        }

        public async Task SalvarFornecedor(Fornecedores model)
        {
            try
            {
                // Utilizado para fazer update alteração no user.
                if (model.Id_Fornecedor > 0)
                {
                    _context.Update(model);
                }
                else
                {
                    var existingUser = await _context.Fornecedores.FirstOrDefaultAsync(u => u.Nome_Fornecedor == model.Nome_Fornecedor);
                    if (existingUser != null)
                    {
                        throw new Exception("Fornecedor já cadastrado.");
                    }
                    _context.Add(model);
                }

                await _context.SaveChangesAsync();
            
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao salvar fornecedor: {ex.Message}");
               
            }
        }

        public async Task<bool> UpdateFornecedor(int id, Fornecedores fornecedorAtualizado)  
        {
            try
            {
                var fornecedorUpdate = await _context.Fornecedores.FirstOrDefaultAsync(x => x.Id_Fornecedor == id);
                if (fornecedorUpdate != null)
                {
                    fornecedorUpdate.Nome_Fornecedor = fornecedorAtualizado.Nome_Fornecedor;
                    fornecedorUpdate.Endereco = fornecedorAtualizado.Endereco;
                    fornecedorUpdate.Telefone = fornecedorAtualizado.Telefone;
                    fornecedorUpdate.Email = fornecedorAtualizado.Email;
                    fornecedorUpdate.Id_Empresa = fornecedorAtualizado.Id_Empresa;

                    await _context.SaveChangesAsync();
                    return true;
                }
                else
                {
                    throw new ApplicationException($"Fornecedor com ID {id} não encontrado.");                   
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao salvar fornecedor.", ex);
            }
        }

        public async Task<bool> DeletarFornecedor(int id)
        {
            try
            {
                var fornecedor = await _context.Fornecedores.FindAsync(id);
                if (fornecedor == null)
                {
                    return false;
                }
                else
                {
                    _context.Fornecedores.Remove(fornecedor);
                    await _context.SaveChangesAsync();
                    return true;
                }             
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao salvar fornecedor.", ex);
            }
        }

    }

}

