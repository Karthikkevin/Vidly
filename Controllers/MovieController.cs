using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Random()
        {
            var movie = new Movie()
            {
                Id = 1,
                Name = "Testing Name"
            };
            // View or Partial View
            //return View(movie);

            // Content
            //return Content("Hello  Guys");

            // HttpNotFound
            //return HttpNotFound();

            // Empty Result
            //return new EmptyResult();

            // Redirect to Action Result
            return RedirectToAction("Index", "Home");
        }

    }
}