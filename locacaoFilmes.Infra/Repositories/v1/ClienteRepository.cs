using locacaoFilmes.Domain.Contracts.v1.Repository;
using locacaoFilmes.Domain.Entity.v1;
using locacaoFilmes.Infra.SqlServer.Context.v1;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace locacaoFilmes.Infra.SqlServer.Repositories.v1
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly ApplicationContext _context;

        public ClienteRepository(ApplicationContext context)
        {
            _context = context;
        }

        public async Task<Clientes> GetByIdClient(Guid id)
        {
            var Client = await _context.Clientes.FindAsync(id);

            if (Client is null)
            {
                throw new ArgumentNullException(nameof(Client));
            }

            return Client;
        }

        public async Task<List<Clientes>> GetAllClient()
        {
            return await _context.Clientes!.ToListAsync();
        }

        public async Task<Clientes> CreateClient(Clientes client)
        {
            if (client is null)
            {
                throw new ArgumentNullException(nameof(client));
            }

            await _context.Clientes.AddAsync(client);
            await _context.SaveChangesAsync();

            return client;
        }

        public async Task UpdateClient(Clientes client)
        {
            if (client is null)
            {
                throw new ArgumentNullException(nameof(client));
            }

            _context.Entry(client).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteClient(Guid id)
        {
            var client = await _context.Clientes.FindAsync(id);

            if (client == null)
            {
                throw new ArgumentNullException(nameof(client));
            }

            _context.Clientes.Remove(client);
            await _context.SaveChangesAsync();
        }

        //verifica se uma entidade existe no banco de dados com base em uma condição específica.
        public async Task<bool> Exists(Guid id)
        {
            return await _context.Clientes.AnyAsync(c => c.Id == id);
        }
    }
}
