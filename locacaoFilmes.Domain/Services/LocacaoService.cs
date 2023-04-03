using locacaoFilmes.Domain.Contracts.v1.Repository;
using locacaoFilmes.Domain.Contracts.v1.Service;
using locacaoFilmes.Domain.Entity.v1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace locacaoFilmes.Domain.Services
{
    public class LocacaoService : ILocacaoService, ILocacaoRepository
    {
        private readonly ILocacaoRepository _locacaoRepository;
        public LocacaoService(ILocacaoRepository locacaoRepository)
        {
            _locacaoRepository = locacaoRepository;
        }

        public async Task<Locacao> GetByIdLocation(Guid id)
        {
            var result = await _locacaoRepository.GetByIdLocation(id);

            return result;

        }

        public async Task<List<Locacao>> GetAllLocation()
        {         
			throw new NotImplementedException();
        }

        public async Task CreateLocation(Locacao location)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateLocation(Locacao location)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteLocation(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
