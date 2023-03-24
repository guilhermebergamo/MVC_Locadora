using locacaoFilmes.Domain.Entity.v1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace locacaoFilmes.Domain.Contracts.v1
{
    public interface IClienteRepository
    {
        Task<List<Clientes>> GetAllClient();
        Task<Clientes> GetByIdClient(Guid id);
        Task<Clientes> CreateClient(Clientes cliente);
        Task UpdateClient(Clientes cliente);
        Task DeleteClient(Guid id);

    }
}
