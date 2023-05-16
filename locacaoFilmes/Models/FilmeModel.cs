using locacaoFilmes.Domain.Entity.v1;

namespace locacaoFilmes.Models
{
    public class FilmeModel
    {
        public FilmeModel(Guid idFilme, string nome, string genero, int anoLancamento, bool disponivel, ICollection<LocacaoModel>? locacaoModel)
        {
            IdFilme = idFilme;
            Nome = nome;
            Genero = genero;
            AnoLancamento = anoLancamento;
            Disponivel = disponivel;
            LocacaoModel = locacaoModel;
        }

        public Guid IdFilme { get; set; }
        public string Nome { get; set; }
        public string Genero { get; set; }
        public int AnoLancamento { get; set; }
        public bool Disponivel { get; set; }
        
        public virtual ICollection<LocacaoModel>? LocacaoModel { get; set; }
    }
}
