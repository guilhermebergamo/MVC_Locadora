using locacaoFilmes.Domain.Command.v1.Locacao;
using locacaoFilmes.Domain.Contracts.v1.Service;
using locacaoFilmes.Domain.Dto.v1;
using locacaoFilmes.Domain.Entity.v1;
using locacaoFilmes.Models;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace locacaoFilmes.Controllers
{
    public class LocacaoController : Controller		
    {
		private readonly ILocacaoService _locacaoService;
		private readonly IMediator _mediator;

		public LocacaoController(ILocacaoService locacaoService, IMediator mediator)
		{
			_locacaoService = locacaoService;
			_mediator = mediator;
		}

		
		public ActionResult<LocacaoModel> Index()
        {
            return View();
        }        

		[HttpPost(nameof(CadastrarLocacao))]
		public async Task<ActionResult> CadastrarLocacao(LocacaoDto locacao)
        {
			try
			{
				await _mediator.Send(new AdicionarLocacaoCommand(locacao));
			}
			catch (Exception)
			{

				throw;
			}
			

			return Ok();
        }





		//[HttpPost(nameof(AtualziarLocacao))]
		//public ActionResult AtualziarLocacao(Guid? id)
  //      {
  //          return View();
  //      }

       
  //      public ActionResult Create()
  //      {
	 //       return View();
  //      }

        
  //      [HttpPost]
  //      [ValidateAntiForgeryToken]
  //      public ActionResult Create(IFormCollection collection)
  //      {
		//	return View();
		
		//}

      
  //      public ActionResult Edit(int id)
  //      {
  //          return View();
  //      }

    
     
  //      public ActionResult Edit(int id, IFormCollection collection)
  //      {
		//	return View();			
		//}

   
  //      public ActionResult Delete(int id)
  //      {
  //          return View();
  //      }
     
  
  //      public ActionResult Delete(int id, IFormCollection collection)
  //      {            
  //          return View();            
  //      }

		public ActionResult Cadastrar()
		{
			var clientes = new List<SelectListItem>
			{
				new SelectListItem { Text = "Cliente 1", Value = "1" },
				new SelectListItem { Text = "Cliente 2", Value = "2" },
				new SelectListItem { Text = "Cliente 3", Value = "3" }
			};

			var filmes = new List<SelectListItem>
			{
				new SelectListItem { Text = "Filme 1", Value = "1" },
				new SelectListItem { Text = "Filme 2", Value = "2" },
				new SelectListItem { Text = "Filme 3", Value = "3" }
			};

			ViewBag.Clientes = clientes;
			ViewBag.Filmes = filmes;

			var _locacaoModel = new LocacaoModel
			{
				DataLocacao = DateTime.Now,
				DataDevolucao = DateTime.Now
			};

			return View(_locacaoModel);
		}
	}
}
