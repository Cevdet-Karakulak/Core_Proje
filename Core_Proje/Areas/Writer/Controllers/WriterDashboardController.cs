using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Core_Proje.Areas.Writer.Controllers
{
    [Area("Writer")]
    public class WriterDashboardController : Controller
    {
        private readonly UserManager<WriterUser> _userManager;

        public WriterDashboardController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.v=values.Name + ""+ values.SurName;

            string api = "1e3f64357f4b1a4eba75abf41df096cc";
            string connection = "http://api.openweathermap.org/data/2.5/weather?q=edirne&mode=xml&lang=tr&units=metric&appid=" + api;
            XDocument document = XDocument.Load(connection);
            ViewBag.v5 = document.Descendants("temperature").ElementAt(0).Attribute("value").Value;

            Context c=new Context();
            ViewBag.v1 = 0;
            ViewBag.v2 = c.announcements.Count();
            ViewBag.v3 = 0;
            ViewBag.v4 = c.Skills.Count();

            return View();
        }
    }
}
