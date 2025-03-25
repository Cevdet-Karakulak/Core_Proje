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
            
            var values = em.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddExperiance()
        {
           
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
