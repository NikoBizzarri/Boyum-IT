using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models;
using WebApp.Service.Interfaces;

namespace WebApp.Controllers
{
    public class PartecipantsController : Controller
    {
        private readonly IRepository _repo; // todo: wrap the repo into a service class
        public PartecipantsController(IRepository repo)
        {
            _repo = repo;
        }

        // GET: PartecipantsController
        public ActionResult Index()
        {
            var events = _repo.GetEvents();
            var model = new PartecipantViewModel()
            {
                Events = events,
            };
            return View(model);
        }

        public ActionResult List()
        {
            var partecipants = _repo.GetParticipants();
            var model = new PartecipantListViewModel()
            {
                Partecipant = partecipants.ToList()
            };
            return View(model);
        }

        // GET: PartecipantsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PartecipantsController/Create
        public ActionResult Create()
        {
            var events = _repo.GetEvents();
            var model = new PartecipantViewModel()
            {
                Events = events,
            };
            return View(model);
        }

        // POST: PartecipantsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                var dto = new Partecipant()
                {
                    Fullname = collection["Partecipant.Fullname"],
                    Email = collection["Partecipant.Email"],
                    Phone = collection["Partecipant.Phone"],
                    EventId = collection["Partecipant.EventId"]
                };

                _repo.AddPartecipant(dto);
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
