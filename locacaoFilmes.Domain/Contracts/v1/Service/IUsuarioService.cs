using locacaoFilmes.Domain.Entity.v1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace locacaoFilmes.Domain.Contracts.v1.Service
{
    public interface IUsuarioService
    {
        Task AddUser(Usuario usuario);
        Task<List<Usuario>> GetAllUsers();
        Task<Usuario> GetUser(Guid id);
        Task RemoveUser(Guid id);
        Task UpdateUser(Usuario usuario);
    }
}
