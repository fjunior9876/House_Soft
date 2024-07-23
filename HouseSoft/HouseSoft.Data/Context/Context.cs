using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Teste_Playmove.Domain.Entity;


namespace Teste_Playmove.Data.Context
{
    public class Context : DbContext
    {

        public DbSet<Fornecedores> Fornecedores { get; set; }
        public DbSet<Empresas> Empresas { get; set; }

        private readonly IConfiguration _configuration;

        public Context(IConfiguration configuration, DbContextOptions<Context> options) : base(options)
        {
            _configuration = configuration;

        }
     

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = _configuration.GetConnectionString("Server");
            optionsBuilder.UseMySQL(connectionString);

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configurar a chave primária para a entidade Empresas
            modelBuilder.Entity<Empresas>()
                        .HasKey(e => e.Id_Empresa); // Aqui 'EmpresaId' deve corresponder à sua propriedade de chave primária
            modelBuilder.Entity<Fornecedores>()
                .HasKey(e => e.Id_Fornecedor);
        }




    }


}
