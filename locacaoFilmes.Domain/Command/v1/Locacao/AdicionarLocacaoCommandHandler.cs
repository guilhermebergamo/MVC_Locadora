using AutoMapper;
using locacaoFilmes.Domain.Contracts.v1.Service;
using locacaoFilmes.Domain.Dto.v1;
using locacaoFilmes.Domain.Entity.v1;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace locacaoFilmes.Domain.Command.v1.Locacao
{
	public class AdicionarLocacaoCommandHandler : CommandHandler<AdicionarLocacaoCommand>
	{
		private readonly ILocacaoService _locacaoService;
		private readonly IMapper _mapper;

		public AdicionarLocacaoCommandHandler(ILocacaoService locacaoService, IMapper mapper)
		{
			_locacaoService = locacaoService ?? 
				throw new ArgumentNullException(nameof(locacaoService));

			_mapper = mapper ?? 
				throw new ArgumentNullException(nameof(mapper));
		}

		public override async Task<Unit> Handle(AdicionarLocacaoCommand command, CancellationToken cancellationToken)
		{
			var locacao = _mapper.Map<Entity.v1.Locacao>(command.LocacaoDto);
			await _locacaoService.CadastrarLocacao(locacao);

			return Unit.Value;
		}
	}
}
