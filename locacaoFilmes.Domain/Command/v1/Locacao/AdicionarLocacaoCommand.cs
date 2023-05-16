using locacaoFilmes.Domain.Dto.v1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace locacaoFilmes.Domain.Command.v1.Locacao
{
	public class AdicionarLocacaoCommand : Command
	{
		public AdicionarLocacaoCommand(LocacaoDto locacaoDto)
		{
			LocacaoDto = locacaoDto;
		}

		public LocacaoDto LocacaoDto { get; set; }
	}
}
