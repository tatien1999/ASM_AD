using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASM.Models;

namespace ASM.Controllers
{
    public class AdminController : Controller
    {
        
        // GET: Admin
        public ActionResult Staff()
        {
            Training_managementEntities db = new Training_managementEntities();
            var acc = db.User_Account.Where(a => a.Position == "trainer" | a.Position == "staff");
            List<User_Account> staff = acc.ToList();
            return View(staff);
        }
        
        // CRUD staff/trainer account
        public ActionResult AddAccount()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddAccount(User_Account acc)
        {
            using (Training_managementEntities db = new Training_managementEntities())
            {
                if (ModelState.IsValid)
                {
                    db.User_Account.Add(acc);
                    if(acc.Position == "trainer" | acc.Position == "staff")
                    {
                        db.SaveChanges();
                    }
                    else
                    {
                        return RedirectToAction("Staff", "Admin");
                    }
                    return RedirectToAction("Staff", "Admin");
                }
            }
            return View();
        }
        public ActionResult EditAccount(int id)
        {
            Training_managementEntities db = new Training_managementEntities();
            var acc = db.User_Account.FirstOrDefault(x => x.UserID == id);
            return View(acc);
        }
        [HttpPost]
        public ActionResult EditAccount(User_Account acc)
        {
            Training_managementEntities db = new Training_managementEntities();
            User_Account us = new User_Account();
            us.UserID = acc.UserID;
            us.UserName = acc.UserName;
            us.Password = acc.Password;
            us.Position = acc.Position;
            db.Entry(us).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Staff", "Admin");
        }

        public ActionResult DeleteAccount(int id)
        {
            Delete(id);
            return RedirectToAction("Staff", "Admin");
        }
        [HttpPost]
        private void Delete(int id)
        {
            Training_managementEntities db = new Training_managementEntities();
            var acc = db.User_Account.FirstOrDefault(x => x.UserID == id);
            db.User_Account.Remove(acc);
            db.SaveChanges();
        }

        //check value exits 
        public JsonResult CheckValue(int check )
        {
            System.Threading.Thread.Sleep(200);
            Training_managementEntities db = new Training_managementEntities();
            var searchID = db.User_Account.Where(x => x.UserID == check).SingleOrDefault();
            if(searchID != null)
            {
                return Json(1);
            }
            else
            {
                return Json(0);
            }
        }

        public JsonResult CheckName(string username)
        {
            System.Threading.Thread.Sleep(500);
            Training_managementEntities db = new Training_managementEntities();
            var searchName = db.User_Account.Where(x => x.UserName == username).SingleOrDefault();
            if (searchName != null)
            {
                return Json(1);
            }
            else
            {
                return Json(0);
            }
        }
    }
}