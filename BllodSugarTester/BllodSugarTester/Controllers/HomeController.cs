using Microsoft.AspNet.Identity;
using System.Web.Mvc;
using System.Data.Entity;
using BllodSugarTester.Models;
using System.Linq;
using BllodSugarTester.Models;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

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
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Contact(EmailFormModel model)
        {
            if (ModelState.IsValid)
            {
                var body = "<p>Email From: {0} ({1})</p><p>Message:</p><p>{2}</p>";
                var message = new MailMessage();
                message.To.Add(new MailAddress("ninja1702@hotmail.com"));  // replace with valid value 
                message.From = new MailAddress("aspnet101attempt@outlook.com");  // replace with valid value
                message.Subject = "Your email subject";
                message.Body = string.Format(body, model.FromName, model.FromEmail, model.Message);
                message.IsBodyHtml = true;

                using (var smtp = new SmtpClient())
                {
                    var credential = new NetworkCredential
                    {
                        UserName = "aspnet101attempt@outlook.com",  // replace with valid value
                        Password = "Tested101"  // replace with valid value
                    };
                    smtp.Credentials = credential;
                    smtp.Host = "smtp-mail.outlook.com";
                    smtp.Port = 587;
                    smtp.EnableSsl = true;
                    await smtp.SendMailAsync(message);
                    return RedirectToAction("Index");
                }
            }
            return View(model);
        }

        public ActionResult google()
        {
            var x = db.caltoid;
            return View(x);
        }

        public ActionResult Calendar()
        {
            var x = db.caltoid;
            return View(x);
        }

        public ActionResult AddingSugar()
        {
            ViewBag.Message = "Your contact page.";
            //var currentUser = _context.Users.FirstOrDefault(m => m.UserName == User.Identity.GetUserName());
            var x = db.caltoid;
            return View(x);
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
        public ActionResult Insulin()
        {
            return View();
        }
        public ActionResult DisplayNumbersMonth()
        {
            var x = db.BloodSugar;
            return View(x);
        }
        public ActionResult GettingStarted()
        {
            return View();
        }
    }
}