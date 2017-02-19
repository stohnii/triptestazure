using System.Web.Mvc;
using TestTrip.Models;
using TripTest.Bal.Arstract;

namespace TripTest.Web.Controllers
{
    [Authorize]
    public class TripsController : Controller
    {
        private readonly ITripManager _tripManager;

        public TripsController(ITripManager tripManager)
        {
            _tripManager = tripManager;
        }

        // GET: Trips
        [HttpGet]
        public ActionResult Index()
        {
            var trips = User.IsInRole("Admin") ? _tripManager.GetTrips() : _tripManager.GetTrips(User.Identity.Name);
            
            return View(trips);
        }

        public RedirectToRouteResult Delete(int Id)
        {
            _tripManager.DeleteTrip(Id);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Details(int Id)
        {
            var trip = _tripManager.GetTrip(Id);

            return View(trip);
        }

        [HttpGet]
        public ActionResult Edit(int Id)
        {
            var trip = _tripManager.GetTrip(Id);

            return View(trip);
        }

        [HttpPost]
        public ActionResult Edit(Trip trip)
        {
            _tripManager.EditTrip(trip);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Trip newTrip)
        {
            newTrip.Owner = User.Identity.Name;
            _tripManager.AddTrip(newTrip);

            return RedirectToAction("Index");
        }
    }
}