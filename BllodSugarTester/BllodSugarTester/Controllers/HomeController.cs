

using System.Web.Mvc;
using System.Data.Entity;
using BllodSugarTester.Models;

namespace BllodSugarTester.Controllers
{

    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult google()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        
        public ActionResult AddingSugar()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        public ActionResult AddingSugar(BloodSugars BS)
        {
            BloodSugars data = new BloodSugars();
            data = new BloodSugars { Time = BS.Time, Date = BS.Date, BloodSugar = BS.BloodSugar, UserId = BS.UserId };
            
            db.BloodSugar.Add(data);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}