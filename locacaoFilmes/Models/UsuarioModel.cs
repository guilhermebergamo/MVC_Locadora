namespace locacaoFilmes.Models
{
    public class UsuarioModel
    {
        public Guid Id { get; set; }
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public string? Senha { get; set; }
        public DateTime? DataCadastro { get; set; }
        public bool? Ativo { get; set; }
    }
}
