using System.Web.Mvc;
using NLog;
namespace SignalR_Test.Controllers
{
    public class HomeController : Controller
    {
        private readonly Logger Logger = LogManager.GetCurrentClassLogger();

        public ActionResult Index()
        {
            Logger.Info("Visiting Index page...");
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            Logger.Info("Visiting about page...");
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            Logger.Info("Vising contact page...");
            return View();
        }

        public ActionResult Chat()
        {
            return View();
        }

        public ActionResult Logs()
        {
            Logger.Info("Log Monitor window...");
            return View();
        }
    }
}