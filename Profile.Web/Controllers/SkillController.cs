using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Profile.Entities;
using Profile.Business;

namespace Profile.Web.Controllers
{
    public class SkillController : Controller
    {
        // GET: Skill
        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public JsonResult GetSkills()
        {
            var listaSkills = new List<SkillDTO>();

            var comp = new SkillComponent();

            listaSkills = comp.GetSkills();


            return Json(listaSkills);
        }
    }
}