using ClientMVC.Services;
using Contracts;
using Entities.DataTransferObjects;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace ClientMVC.Controllers
{
	public class FridgesController : Controller
	{
		private readonly IFridgeService _service;

		public FridgesController(IFridgeService service)
		{
			_service = service;
		}

		// GET: FridgesController
		public async Task<ActionResult> Index()
		{
			var content = await _service.GetAll();
			return View(content);
		}

		// GET: FridgesController/Details/5
		public async Task<ActionResult> Details(Guid id)
		{
			var fridge_with_prods = await _service.GetFridge(id);
			if (fridge_with_prods == null)
				return Redirect("Index");
			return View(fridge_with_prods);
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
		public async Task<ActionResult> Edit(Guid id)
		{
			var fridge = await _service.GetFridge(id);
			if (fridge == null)
				return RedirectToAction("Index");
			var fridgeToUpdate = new FridgeDTO { Id = fridge.FridgeId, Name = fridge.FridgeName, OwnerName = fridge.OwnerName };
			return View(fridgeToUpdate);
		}

		// POST: FridgesController/Edit/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<ActionResult> Edit(Guid id, [FromForm] FridgeToUpdateDTO fridge)
		{
			if (ModelState.IsValid)
			{
				bool success = await _service.EditFridge(id, fridge);
				if (success)
					return RedirectToAction("Index");
				else
					ModelState.AddModelError("Model", "Error in model");
			}

			var fridgeToUpdate = new FridgeDTO { Id = id, Name = fridge.Name, OwnerName = fridge.OwnerName };

			return View(fridgeToUpdate);
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
