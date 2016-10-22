using POC.TicketSystem.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace POC.TicketSystem.Web.Controllers
{
    public class TicketController : Controller
    {
        TicketDb _db = new TicketDb();

        // GET: Ticket
        public ActionResult Index()
        {
            //return Content("Hello from Ticket !!");


            var model = _db.Tickets.ToList();
            return View(model);
        }

        // GET: Ticket/Details/5
        public ActionResult Details(int id)
        {
            var model = _db.Tickets.Find(id);//  .ToList().Where(t=>t.Id == id).FirstOrDefault();
            return View(model);
        }

        // GET: Ticket/Create
        public ActionResult Create()
        {
            var staticData = StaticDataService.GetStaticData();

            ViewBag.source = new SelectList(staticData.Source);
            ViewBag.Priority = new SelectList(staticData.Priority.Select(x=> x.Key) );
            ViewBag.Status = new SelectList(staticData.Status.Select(x => x.Key));

            //ViewBag.Status = new SelectList(staticData.Status.Select(x => new { Value = x.Value, Text = x.Key }));  

            return View();
        }

        // POST: Ticket/Create
        [HttpPost]
        public ActionResult Create(Ticket ticket)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {
                    _db.Tickets.Add(ticket);
                    _db.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Ticket/Edit/5
        public ActionResult Edit(int id)
        {
            var model = _db.Tickets.Find(id);
            return View(model);
        }

        // POST: Ticket/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
                var model = _db.Tickets.Find(id);

                if (TryUpdateModel(model)){
                    _db.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Ticket/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Ticket/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (_db != null)
            {
                _db.Dispose();
            }

            base.Dispose(disposing);
        }
    }
}
