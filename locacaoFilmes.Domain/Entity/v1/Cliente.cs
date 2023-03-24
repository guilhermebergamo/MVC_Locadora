using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace locacaoFilmes.Domain.Entity.v1
{
    public class Clientes
    {
        public Clientes(Guid id, string nome, string endereco, string telefone, DateTime dataCadastro, bool ativo, ICollection<Locacao>? locacoes)
        {
            Id = id;
            Nome = nome ?? throw new ArgumentNullException(nameof(nome));
            Endereco = endereco ?? throw new ArgumentNullException(nameof(endereco));
            Telefone = telefone ?? throw new ArgumentNullException(nameof(telefone));
            DataCadastro = dataCadastro;
            Ativo = ativo;
            Locacoes = locacoes;
        }

        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }

        public virtual ICollection<Locacao>? Locacoes { get; set; }

        

    }
}
