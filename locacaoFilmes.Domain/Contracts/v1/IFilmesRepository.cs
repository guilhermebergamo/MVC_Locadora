using locacaoFilmes.Domain.Entity.v1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace locacaoFilmes.Domain.Contracts.v1
{
    public interface IFilmesRepository
    {        
        Task<List<Filmes>> GetAllFilm();
        Task<Filmes> GetByIdFilm(Guid id);
        Task<Filmes> CreateFilm(Filmes filme);
        Task UpdateFilm(Filmes filme);
        Task DeleteFilm(Guid id);
        
    }
}
