using locacaoFilmes.Domain.Contracts.v1;
using locacaoFilmes.Domain.Entity.v1;
using locacaoFilmes.Infra.SqlServer.Context.v1;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace locacaoFilmes.Infra.SqlServer.Repositories.v1
{
    public class FilmeRepository : IFilmesRepository
    {
        private readonly ApplicationContext _context;

        public FilmeRepository(ApplicationContext context)
        {
            _context = context;
        }

        public async Task<List<Filmes>> GetAllFilm()
        {
            return await _context.Filmes.ToListAsync();
        }

        public async Task<Filmes> GetByIdFilm(Guid id)
        {
            var Film =  await _context.Filmes.FindAsync(id);

            if (Film is null)
            {
                throw new ArgumentNullException(nameof(Film));
            }

            return Film;
        }

        public async Task<Filmes> CreateFilm(Filmes filme)
        {
            if (filme == null)
            {
                throw new ArgumentNullException(nameof(filme));
            }

            await _context.Filmes.AddAsync(filme);
            await _context.SaveChangesAsync();

            return filme;
        }

        public async Task UpdateFilm(Filmes film)
        {
            if (film == null)
            {
                throw new ArgumentNullException(nameof(film));
            }

            _context.Entry(film).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await Exists(film.Id))
                {
                    throw new Exception("Filme não encontrado.");
                }
                else
                {
                    throw;
                }
            }
        }

        public async Task DeleteFilm(Guid id)
        {
            var film = await _context.Filmes.FindAsync(id);

            if (film == null)
            {
                throw new Exception("Filme não encontrado.");
            }

            _context.Filmes.Remove(film);
            await _context.SaveChangesAsync();
        }

        private async Task<bool> Exists(Guid id)
        {
            return await _context.Filmes.AnyAsync(e => e.Id == id);
        }

    }
}
