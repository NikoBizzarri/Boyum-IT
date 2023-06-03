﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Controllers
{
    public class PartecipantsController : Controller
    {
        // GET: PartecipantsController
        public ActionResult Index()
        {
            return View();
        }

        // GET: PartecipantsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PartecipantsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PartecipantsController/Create
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

        // GET: PartecipantsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PartecipantsController/Edit/5
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

        // GET: PartecipantsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PartecipantsController/Delete/5
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
