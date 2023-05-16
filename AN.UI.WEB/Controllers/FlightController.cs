using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AN.UI.WEB.Controllers
{
    public class FlightController : Controller

    {
        IServiceFlight serviceFlight;
        IServicePlane servicePlane;
        public FlightController(IServiceFlight serviceFlight, IServicePlane servicePlane)
        {
            this.serviceFlight = serviceFlight;
            this.servicePlane = servicePlane;


        }
        // GET: FlightController
        public ActionResult Index()
        {
            var flights = serviceFlight.GetAll().ToList();
            return View(flights);
        }

        // GET: FlightController/Details/5
        public ActionResult Details(int id)
        {
            var flight = serviceFlight.GetById(id);
            return View(flight);
        }

        // GET: FlightController/Create
        public ActionResult Create()
        {
            ViewBag.Plane = new SelectList(servicePlane.GetAll(), "PlaneId", "Information");
            return View();
        }

        // POST: FlightController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Flight collection, IFormFile PiletFile)
        {
            try
            {
                if (PiletFile != null)
                {
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Uploads", PiletFile.FileName);
                    var stream = new FileStream(path, FileMode.Create);
                    PiletFile.CopyTo(stream);
                    collection.Pilet = PiletFile.FileName;
                }


                serviceFlight.Add(collection);
                serviceFlight.Commit();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }


        // GET: FlightController/Edit/5
        public ActionResult Edit(int id)
        {
            Flight flight = serviceFlight.GetById(id);
            var list = servicePlane.GetAll();
            ViewBag.Planes = new SelectList(list, "PlaneId", "Information");
            return View(flight);
        }


        public ActionResult search(string departure, string destination)
        {
            if (departure != null)
            {
                var flights = serviceFlight.GetAll().ToList().Where(f => f.Departure.Contains(departure));
                return View("index", flights);

            }
            else
            {
                var flights = serviceFlight.GetAll().ToList().Where(f => f.Destination.Contains(destination));
                return View("index", flights);
            }
        }

        // POST: FlightController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Flight collection)
        {
            try
            {
                serviceFlight.Update(collection);
                serviceFlight.Commit();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: FlightController/Delete/5
        public ActionResult Delete(int id)
        {
            var flight = serviceFlight.GetById(id);
            return View(flight);
        }

        // POST: FlightController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                var flight = serviceFlight.GetById(id);
                serviceFlight.Delete(flight);
                serviceFlight.Commit();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
