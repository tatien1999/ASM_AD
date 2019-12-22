using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASM.Models;

namespace ASM.Controllers
{
    public class TrainerController : Controller
    {
        // GET: Trainer
        public ActionResult ProfileTrainer()
        {
            Training_managementEntities db = new Training_managementEntities();
            List<Profile_User> pro = db.Profile_User.ToList();
            return View();

        }

    }
}