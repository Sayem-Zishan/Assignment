using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Agent.Gateway;
using Agent.Models;

namespace Agent.Controllers
{
    public class AgentController : Controller
    {
        DBContext db = new DBContext();
        // GET: Agent
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AgentList()
        {

            return View(db.Users.ToList());
        }

        public ActionResult  AddAgent()
        { 
            return View();
        }
        [HttpPost]
        public ActionResult AddAgent(User s)
        {
           s.Created= DateTime.Now;
            db.Users.Add(s);
            db.SaveChanges();

            return RedirectToAction("AgentList");
        }


        public ActionResult Details(int id)
        {
           
            var k = db.Users.Find(id);

            return View(k);
        }

        public ActionResult Edit(int id)
        {
            
            var k = db.Users.Find(id);

            return View(k);
        }
        [HttpPost]
        public ActionResult Edit(User s)
        {
            
            var k = db.Users.Find(s.ID);
            k.Code = s.Code;
            k.Name = s.Name;
            k.Markup = s.Markup;
            k.Email = s.Email;
            k.Mobile = s.Mobile;
            k.Phone = s.Phone;
            k.Address = s.Address;
            k.City = s.City;
            k.State = s.State;
            k.PostalCode = s.PostalCode;

            db.SaveChanges();

            return View();
        }

        public ActionResult Delete(int id)
        {
           
            var k = db.Users.Find(id);

            return View(k);
        }

        [HttpPost]
        public ActionResult Delete(User s)
        {
            var k = db.Users.Find(s.ID);
            db.Users.Remove(k);
            db.SaveChanges();

            return RedirectToAction("AgentList");
        }


        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult IDelete(int ID)
        {
            var k = db.Users.Find(ID);
            db.Users.Remove(k);
            db.SaveChanges();

            return Json("", JsonRequestBehavior.AllowGet);
        }

    }
}