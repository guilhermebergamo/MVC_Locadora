namespace locacaoFilmes.Domain.Entity.v1
{
    public class Usuario
    {
        public Usuario(Guid id, string nome, string email, string senha, DateTime dataCadastro, bool ativo)
        {
            Id = id;
            Nome = nome ?? throw new ArgumentNullException(nameof(nome));
            Email = email ?? throw new ArgumentNullException(nameof(email));
            Senha = senha ?? throw new ArgumentNullException(nameof(senha));
            DataCadastro = dataCadastro;
            Ativo = ativo;
        }

        public Guid Id { get; set; }
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public string? Senha { get; set; }
        public DateTime? DataCadastro { get; set; }
        public bool? Ativo { get; set; }

    }
}