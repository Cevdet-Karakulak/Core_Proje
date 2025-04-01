using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Dashboard
{
    public class AdminNatificationNavbarList : ViewComponent
    {

        public IViewComponentResult Invoke()
        {
            return View();
        }

    }
}
