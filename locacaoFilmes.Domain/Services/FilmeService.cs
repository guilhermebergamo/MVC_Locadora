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
    public class FilmeService : IFilmeService, IFilmeRepository
    {
        private readonly IFilmeRepository _filmesRepository;
        public FilmeService(IFilmeRepository filmesRepository)
        {
            _filmesRepository = filmesRepository;
        }

        public async Task<List<Filme>> GetAllFilm()
        {
            throw new NotImplementedException();
        }

        public async Task<Filme> GetByIdFilm(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<Filme> CreateFilm(Filme filme)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateFilm(Filme film)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteFilm(Guid id)
        {
          throw new NotImplementedException();
        }   

    }
}
