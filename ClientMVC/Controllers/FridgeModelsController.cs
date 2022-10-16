using ClientMVC.Services;
using Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ClientMVC.Controllers
{
	public class FridgeModelsController : Controller
	{
		private readonly IFridgeModelService _service;

		public FridgeModelsController(IFridgeModelService service)
		{
			_service = service;
		}

		// GET: FridgeModelsController
		public async Task<ActionResult> Index()
		{
			var content = await _service.GetAll();
			return View(content);
		}

		// GET: FridgeModelsController/Details/5
		public ActionResult Details(int id)
		{
			return View();
		}

		// GET: FridgeModelsController/Create
		public ActionResult Create()
		{
			return View();
		}

		// POST: FridgeModelsController/Create
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

		// GET: FridgeModelsController/Edit/5
		public ActionResult Edit(int id)
		{
			return View();
		}

		// POST: FridgeModelsController/Edit/5
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

		// GET: FridgeModelsController/Delete/5
		public ActionResult Delete(int id)
		{
			return View();
		}

		// POST: FridgeModelsController/Delete/5
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
