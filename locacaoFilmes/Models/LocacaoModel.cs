using locacaoFilmes.Domain.Entity.v1;

namespace locacaoFilmes.Models
{
    public class LocacaoModel
    {
		public Guid Id
		{
			get
			{
				return Guid.NewGuid();
			}
		}

		//public int IdCliente { get; set; }
		//public int IdFilme { get; set; }
		//public int IdUsuario { get; set; }
		//public DateTime DataLocacao { get; set; }
		//public DateTime DataDevolucao { get; set; }
		//public bool Devolvido { get; set; }
		//public virtual ICollection<ClienteModel>? ClienteModel { get; set; }
		//public virtual ICollection<FilmeModel>? FilmeModel { get; set; }
	}
}
