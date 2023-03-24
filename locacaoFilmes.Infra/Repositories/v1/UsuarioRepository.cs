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
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly ApplicationContext _context;

        public UsuarioRepository(ApplicationContext context)
        {
            _context = context;
        }

        public async Task AddUser(Usuario usuario)
        {
            await _context.Usuarios.AddAsync(usuario);            
        }

        public async Task<Usuario> GetUser(Guid id)
        {
            var User = await _context.Usuarios!.FindAsync(id);

            if (User is null)
            {
                throw new Exception("Usuario não encontrato !");
            }

            return User;
        }

        public async Task<List<Usuario>> GetAllUsers()
        {
            var Users = await _context.Usuarios!.ToListAsync();

            if (Users is null)
            {
                throw new Exception("Users não encontrato !");
            }

            return Users;
        }

        public async Task RemoveUser(Guid id)
        {
            var User = await _context.Usuarios.FindAsync(id);

            if (User is null)
            {
                throw new Exception("Users não encontrato !");
            }

            _context.Usuarios!.Remove(User);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateUser(Usuario usuario)
        {
            _context.Entry(usuario).State = EntityState.Modified;
            await _context.SaveChangesAsync();

        }
    }
}
