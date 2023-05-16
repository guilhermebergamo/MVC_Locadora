using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace locacaoFilmes.Domain.Command.v1
{
	public abstract class CommandHandler<TCommand> : IRequestHandler<TCommand, Unit> 
		where TCommand : IRequest<Unit>
	{
		public abstract Task<Unit> Handle(TCommand command, CancellationToken cancellationToken);
	}
}
