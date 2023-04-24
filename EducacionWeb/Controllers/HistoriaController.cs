﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EducacionWeb.Controllers
{
    public class HistoriaController : Controller
    {
        // GET: HistoriaController
        public IActionResult Historia()
        {
            return View();
        }

        // GET: HistoriaController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: HistoriaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HistoriaController/Create
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

        // GET: HistoriaController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HistoriaController/Edit/5
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

        // GET: HistoriaController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HistoriaController/Delete/5
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
