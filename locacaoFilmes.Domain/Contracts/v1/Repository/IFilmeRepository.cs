using locacaoFilmes.Domain.Entity.v1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace locacaoFilmes.Domain.Contracts.v1.Repository
{
    public interface IFilmeRepository
    {
        Task<List<Filme>> GetAllFilm();
        Task<Filme> GetByIdFilm(Guid id);
        Task<Filme> CreateFilm(Filme filme);
        Task UpdateFilm(Filme filme);
        Task DeleteFilm(Guid id);

    }
}
