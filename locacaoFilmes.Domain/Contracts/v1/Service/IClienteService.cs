using locacaoFilmes.Domain.Entity.v1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace locacaoFilmes.Domain.Contracts.v1.Service
{
    public interface IClienteService
    {
        Task<Clientes> CreateClient(Clientes cliente);
        Task DeleteClient(Guid id);
        Task<List<Clientes>> GetAllClient();
        Task<Clientes> GetByIdClient(Guid id);
        Task UpdateClient(Clientes cliente);

    }
}
