using ClientMVC.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ClientMVC.Controllers
{
	public class FridgesController : Controller
	{
		private readonly FridgeService _service;

		public FridgesController(FridgeService service)
		{
			_service = service;
		}

		// GET: FridgesController
		public ActionResult Index()
		{
			return View();
		}

		// GET: FridgesController/Details/5
		public ActionResult Details(int id)
		{
			return View();
		}

		// GET: FridgesController/Create
		public ActionResult Create()
		{
			return View();
		}

		// POST: FridgesController/Create
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

		// GET: FridgesController/Edit/5
		public ActionResult Edit(int id)
		{
			return View();
		}

		// POST: FridgesController/Edit/5
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

		// GET: FridgesController/Delete/5
		public ActionResult Delete(int id)
		{
			return View();
		}

		// POST: FridgesController/Delete/5
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
