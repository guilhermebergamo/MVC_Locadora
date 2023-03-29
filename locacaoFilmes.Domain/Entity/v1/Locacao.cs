using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace locacaoFilmes.Domain.Entity.v1
{
    public class Locacao
    {
        public Locacao(Guid id, int idCliente, int idFilme, int idUsuario, DateTime dataLocacao, DateTime dataDevolucao, bool devolvido, Clientes? cliente, ICollection<Filme>? filmes)
        {
            Id = id;
            IdCliente = idCliente;
            IdFilme = idFilme;
            IdUsuario = idUsuario;
            DataLocacao = dataLocacao;
            DataDevolucao = dataDevolucao;
            Devolvido = devolvido;
            Cliente = cliente;
            Filmes = filmes;
        }

        public Guid Id { get; set; }
        public int IdCliente { get; set; }
        public int IdFilme { get; set; }
        public int IdUsuario { get; set; }
        public DateTime DataLocacao { get; set; }
        public DateTime DataDevolucao { get; set; }
        public bool Devolvido { get; set; }

        public virtual Clientes? Cliente { get; set; }
        public virtual ICollection<Filme>? Filmes { get; set; }

    }
}
