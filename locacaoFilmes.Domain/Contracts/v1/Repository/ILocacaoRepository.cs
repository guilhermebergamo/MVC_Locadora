using locacaoFilmes.Domain.Entity.v1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace locacaoFilmes.Domain.Contracts.v1.Repository
{
    public interface ILocacaoRepository
    {
        Task<List<Locacao>> GetAllLocation(Guid id);
        Task<Locacao> GetByIdLocation(Guid id);
        Task CreateLocation(Locacao location);
        Task UpdateLocation(Locacao location);
        Task DeleteLocation(Guid id);
    }
}
