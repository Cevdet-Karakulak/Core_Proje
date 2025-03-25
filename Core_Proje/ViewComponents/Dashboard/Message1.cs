using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Numerics;

namespace Core_Proje.ViewComponents.Dashboard
{
    public class Message1: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
        

    }
}

