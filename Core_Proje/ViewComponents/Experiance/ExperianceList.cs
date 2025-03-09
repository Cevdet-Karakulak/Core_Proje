using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Experiance
{
    public class ExperianceList : ViewComponent
    {
        ExperianceManager em = new ExperianceManager(new EfExperianceDal());
        public IViewComponentResult Invoke()
        {
            var values = em.TGetList();
            return View(values);
        }
    }
}
