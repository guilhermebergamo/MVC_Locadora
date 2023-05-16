using locacaoFilmes.Domain.Dto.v1;
using locacaoFilmes.Domain.Entity.v1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace locacaoFilmes.Domain.Contracts.v1.Service
{
    public interface ILocacaoService
    {
		Task CadastrarLocacao(Locacao location);

		//Task<List<Locacao>> GetAllLocation();
  //      Task<Locacao> GetByIdLocation(Guid id);     
  //      Task DeleteLocation(Guid id);
    }
}
