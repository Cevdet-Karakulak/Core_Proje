using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Skill
{
    public class SkillList : ViewComponent
    {
        SkillManager skillm = new SkillManager(new EfSkillDal());
        public IViewComponentResult Invoke()
        {
            var values = skillm.TGetList();
            return View(values);
        }
    }
}
