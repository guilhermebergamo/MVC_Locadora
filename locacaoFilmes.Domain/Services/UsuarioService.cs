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
    public class UsuarioService : IUsuarioService ,IUsuarioRepository
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioService(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public async Task AddUser(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public async Task<Usuario> GetUser(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Usuario>> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public async Task RemoveUser(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateUser(Usuario usuario)
        {
            throw new NotImplementedException();       
        }
    }
}
