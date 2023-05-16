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
		Task CadastrarLocacao(Locacao locacao);
        //Task<List<Locacao>> GetAllLocation();
  //      Task<Locacao> GetByIdLocation(Guid id);        
  //      Task UpdateLocation(Locacao location);
  //      Task DeleteLocation(Guid id);
    }
}
