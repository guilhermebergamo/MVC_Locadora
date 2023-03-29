using locacaoFilmes.Domain.Contracts.v1.Repository;
using locacaoFilmes.Domain.Contracts.v1.Service;
using locacaoFilmes.Domain.Entity.v1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace locacaoFilmes.Domain.Services
{
    public class ClienteService : IClienteService , IClienteRepository
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteService)
        {
            _clienteRepository = clienteService;
        }

        public async Task<Clientes> CreateClient(Clientes cliente)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteClient(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Clientes>> GetAllClient()
        {
            throw new NotImplementedException();
        }

        public async Task<Clientes> GetByIdClient(Guid id)
        {
            throw new NotImplementedException();
        }
   
        public async Task UpdateClient(Clientes cliente)
        {
            throw new NotImplementedException();
        }
    }
}
