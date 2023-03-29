using locacaoFilmes.Domain.Entity.v1;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace locacaoFilmes.Infra.SqlServer.Context.v1
{
    public class ApplicationContext : DbContext
    {
        private readonly IConfiguration _configuration;

        public ApplicationContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("SQLConnection"));
        }

        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Clientes> Clientes { get; set; }

        public DbSet<Filme> Filmes { get; set; }

        public DbSet<Locacao> Locacao { get; set; }
    }
}