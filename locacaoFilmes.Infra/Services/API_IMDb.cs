using locacaoFilmes.Domain.Contracts.v1.API;
using locacaoFilmes.Domain.Entity.v1;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace locacaoFilmes.Infra.SqlServer.Services
{
	//public class API_IMDb : IAPI_IMDb
	//{

	//	private const string _baseUrl = "http://www.omdbapi.com/";
	//	private const string _apiKey = "<Your API Key>";

	//	public async Task<Filme> GetMovieInfoAsync(string title)
	//	{
	//		string url = $"{_baseUrl}?apikey={_apiKey}&t={title}";

	//		using (var client = new HttpClient())
	//		{
	//			var response = await client.GetAsync(url);				

	//			//if (!response.IsSuccessStatusCode)
	//			//	throw new Exception($"Failed to retrieve data from OMDB API.Status code: {response.StatusCode}");

	//			//var content = await response.Content.ReadAsStringAsync();
	//			//var result = JsonConvert.DeserializeObject<FilmeModel>(content);

	//			//if (result.Response == "False")
	//			//	throw new Exception($"Failed to retrieve data from OMDB API. Error message: {result.Error}");

	//			//return result;
	//		}
	//	}

	//}
}
