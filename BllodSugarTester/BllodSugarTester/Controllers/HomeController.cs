using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using System.Web.Mvc;
using System.Data.Entity;
using BllodSugarTester.Models;

namespace BllodSugarTester.Controllers
{

    public class HomeController : Controller
    {
        private ApplicationDbContext _context;
        private ApplicationDbContext db = new ApplicationDbContext();

        public HomeController()
        {
            _context = new ApplicationDbContext();

        }
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
            var currentUser = _context.Users.FirstOrDefaultAsync(m => m.UserName == User.Identity.GetUserName());
            
            return View(currentUser);
        }

        [HttpPost]
        public ActionResult AddingSugar(BloodSugars BS)
        {
            BloodSugars data = new BloodSugars();
            data = new BloodSugars { Time = BS.Time, Date = BS.Date, BloodSugar = BS.BloodSugar, UserId = BS.UserId, };
            db.Entry(data).State = EntityState.Modified;
            db.BloodSugar.Add(data);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DisplayNumbers()
        {
            var x = db.BloodSugar;
            return View(x);
        }
    }
}