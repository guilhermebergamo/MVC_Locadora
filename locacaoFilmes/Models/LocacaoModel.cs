using locacaoFilmes.Domain.Entity.v1;

namespace locacaoFilmes.Models
{
	public class LocacaoModel
	{
		public int IdLocacao { get; set; }
		public DateTime DataLocacao { get; set; }
		public DateTime DataDevolucao { get; set; }

		//Propriedade de navegação para a entidade Cliente
		public virtual ICollection<ClienteModel> Cliente { get; set; }

		//Propriedade de navegação para a entidade Filme
		public virtual ICollection<Filme> Filmes { get; set; }
	}
}
