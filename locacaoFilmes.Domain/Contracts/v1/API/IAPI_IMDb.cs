using locacaoFilmes.Domain.Entity.v1;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace locacaoFilmes.Domain.Contracts.v1.API
{
	public interface IAPI_IMDb
	{
		Task<Filme> GetMovieInfoAsync(string title);
	}
}
