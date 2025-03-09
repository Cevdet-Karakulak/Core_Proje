using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Contact
{
    public class SendMessage : ViewComponent
    {
        ExperianceManager em = new ExperianceManager(new EfExperianceDal());
        public IViewComponentResult Invoke()
        {
            
            return View();
        }
    }
}