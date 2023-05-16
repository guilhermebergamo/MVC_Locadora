using locacaoFilmes.Domain.Entity.v1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace locacaoFilmes.Domain.Dto.v1
{
	public class LocacaoDto
	{
		public LocacaoDto(Guid id, int idCliente, int idFilme, int idUsuario, DateTime dataLocacao, DateTime dataDevolucao, bool devolvido, Clientes? cliente, ICollection<Filme>? filmes)
		{
			Id = id;
			IdCliente = idCliente;
			IdFilme = idFilme;
			IdUsuario = idUsuario;
			DataLocacao = dataLocacao;
			DataDevolucao = dataDevolucao;
			Devolvido = devolvido;
			Cliente = (ICollection<Clientes>?)cliente;
			Filmes = filmes;
		}

		public Guid Id { get; set; }
		public int IdCliente { get; set; }
		public int IdFilme { get; set; }
		public int IdUsuario { get; set; }
		public DateTime DataLocacao { get; set; }
		public DateTime DataDevolucao { get; set; }
		public bool Devolvido { get; set; }
		public virtual ICollection<Clientes>? Cliente { get; set; }
		public virtual ICollection<Filme>? Filmes { get; set; }
	}
}
