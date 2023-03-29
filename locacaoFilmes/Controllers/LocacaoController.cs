using locacaoFilmes.Domain.Contracts.v1.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace locacaoFilmes.Controllers
{
    public class LocacaoController : Controller		
    {
		private readonly ILocacaoService _locacaoService;

		public LocacaoController(ILocacaoService locacaoService)
		{
			_locacaoService = locacaoService;
		}

		// GET: LocacaoController1
		public async ActionResult Index(Guid id)
        {
            var result = await _locacaoService.GetAllLocation(id);



			return View();
        }

        // GET: LocacaoController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: LocacaoController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LocacaoController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: LocacaoController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: LocacaoController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: LocacaoController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: LocacaoController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
