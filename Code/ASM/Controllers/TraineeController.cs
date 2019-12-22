using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASM.Models;

namespace ASM.Controllers
{
    public class TraineeController : Controller
    {
        // GET: Trainee
        public ActionResult ProfileTrainee()
        {

            Training_managementEntities db = new Training_managementEntities();
            return View();
        }
    }
}