using ClientMVC.Services;
using Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ClientMVC.Controllers
{
	public class ProductsController : Controller
	{
		private readonly IProductService _service;

		public ProductsController(IProductService service)
		{
			_service = service;
		}

		// GET: ProductsControllerController
		public async Task<ActionResult> Index()
		{
			var content = await _service.GetAll();
			return View(content);
		}

		// GET: ProductsControllerController/Details/5
		public ActionResult Details(int id)
		{
			return View();
		}

		// GET: ProductsControllerController/Create
		public ActionResult Create()
		{
			return View();
		}

		// POST: ProductsControllerController/Create
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

		// GET: ProductsControllerController/Edit/5
		public ActionResult Edit(int id)
		{
			return View();
		}

		// POST: ProductsControllerController/Edit/5
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

		// GET: ProductsControllerController/Delete/5
		public ActionResult Delete(int id)
		{
			return View();
		}

		// POST: ProductsControllerController/Delete/5
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
