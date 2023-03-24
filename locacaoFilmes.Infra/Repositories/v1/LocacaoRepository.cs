using locacaoFilmes.Domain.Contracts.v1;
using locacaoFilmes.Domain.Entity.v1;
using locacaoFilmes.Infra.SqlServer.Context.v1;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace locacaoFilmes.Infra.SqlServer.Repositories.v1
{
    public class LocacaoRepository : ILocacaoRepository
    {
        private readonly ApplicationContext _context;

        public LocacaoRepository(ApplicationContext context)
        {
            _context = context;
        }

        public async Task<Locacao> GetByIdLocation(Guid id)
        {
            var location = await _context.Locacao.FindAsync(id);

            if (location is null)
            {
                throw new ArgumentNullException(nameof(location));
            }

            return location;

        }

        public async Task<List<Locacao>> GetAllLocation()
        {
            return await _context.Locacao.ToListAsync();
        }

        public async Task CreateLocation(Locacao location)
        {
            if (location is null)
            {
                throw new ArgumentNullException(nameof(location));
            }

            if (location.DataLocacao > location.DataDevolucao || location.DataLocacao > DateTime.Now)
            {
                throw new ArgumentException("Data de locação inválida.");
            }

            if (_context.Filmes.Find(location.IdFilme) is null)
            {
                throw new ArgumentException("Filme não encontrado.");
            }

            if (_context.Clientes.Find(location.IdCliente) is null)
            {
                throw new ArgumentException("Cliente não encontrado.");
            }

            _context.Locacao.Add(location);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateLocation(Locacao location)
        {
            if (location is null)
            {
                throw new ArgumentNullException(nameof(location));
            }

            if (location.DataLocacao > location.DataDevolucao || location.DataLocacao > DateTime.Now)
            {
                throw new ArgumentException("Data de locação inválida.");
            }

            if (_context.Filmes.Find(location.IdFilme) is null)
            {
                throw new ArgumentException("Filme não encontrado.");
            }

            if (_context.Clientes.Find(location.IdCliente) is null)
            {
                throw new ArgumentException("Cliente não encontrado.");
            }

            _context.Entry(location).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteLocation(Guid id)
        {
            var location = await GetByIdLocation(id);
            if (location is null)
            {
                throw new ArgumentException("Locação não encontrada.");
            }

            _context.Locacao.Remove(location);
            await _context.SaveChangesAsync();
        }
    }
}
