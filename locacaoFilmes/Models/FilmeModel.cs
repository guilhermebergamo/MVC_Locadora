using locacaoFilmes.Domain.Entity.v1;

namespace locacaoFilmes.Models
{
    public class FilmeModel
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Genero { get; set; }
        public int AnoLancamento { get; set; }
        public bool Disponivel { get; set; }
        public virtual ICollection<LocacaoModel>? LocacaoModel { get; set; }
    }
}
