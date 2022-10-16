﻿using ClientMVC.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ClientMVC.Controllers
{
	public class FridgeModelsController : Controller
	{
		private readonly FridgeModelService _service;

		public FridgeModelsController(FridgeModelService service)
		{
			_service = service;
		}

		// GET: FridgeModelsController
		public ActionResult Index()
		{
			return View();
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
