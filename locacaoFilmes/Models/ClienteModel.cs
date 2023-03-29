using locacaoFilmes.Domain.Entity.v1;

namespace locacaoFilmes.Models
{
    public class ClienteModel
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }
        public virtual ICollection<ClienteModel>? ClientesModel { get; set; }
    }
}
