using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers
{
    public class ExperianceController : Controller
    {
        ExperianceManager em = new ExperianceManager(new EfExperianceDal());
        public IActionResult Index()
        {
            ViewBag.v1 = "Deneyim Listesi";
            ViewBag.v2 = "Deneyimler";
            ViewBag.v3 = "Deneyim Listesi";
            var values = em.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddExperiance()
        {
            ViewBag.v1 = "Deneyim Ekleme";
            ViewBag.v2 = "Deneyimler";
            ViewBag.v3 = "Deneyim Ekleme";
            return View();
        }
        [HttpPost]
        public IActionResult AddExperiance(Experiance experiance)
        {
            em.TAdd(experiance);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteExperiance(int id)
        {
            var values = em.TGetById(id);
            em.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditExperiance(int id)
        {
            ViewBag.v1 = "Düzenleme";
            ViewBag.v2 = "Deneyimler";
            ViewBag.v3 = "Deneyim Güncelleme";
            var values = em.TGetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditExperiance(Experiance p)
        {
            em.TUpdate(p);
            return RedirectToAction("Index");
        }
    }
}
