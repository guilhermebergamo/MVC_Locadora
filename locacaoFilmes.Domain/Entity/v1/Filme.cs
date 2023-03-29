using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace locacaoFilmes.Domain.Entity.v1
{
    public class Filme
    {
        public Filme(Guid id, string nome, string genero, int anoLancamento, bool disponivel, ICollection<Locacao>? locacoes)
        {
            Id = id;
            Nome = nome ?? throw new ArgumentNullException(nameof(nome));
            Genero = genero ?? throw new ArgumentNullException(nameof(genero));
            AnoLancamento = anoLancamento;
            Disponivel = disponivel;
            Locacoes = locacoes;
        }

        public Guid Id { get; set; }
        public string Nome { get; set; }       
        public string Genero { get; set; }
        public int AnoLancamento { get; set; }
        public bool Disponivel { get; set; }

        public virtual ICollection<Locacao>? Locacoes { get; set; }

    }
}
