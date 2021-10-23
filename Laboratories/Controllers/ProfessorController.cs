using Laboratories.Models;
using Laboratories.Service;
using Laboratories.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Laboratories.Controllers
{
    public class ProfessorController : Controller
    {
       
        private ProfessorService service;

        public ProfessorController()
        {
            service = new ProfessorServiceImpl();

        }
        // GET: Professor
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Create()
        {
            //  ViewBag.MembershipTypeId = membershipTypeService.GetSelectListForViewBag();
            // ViewBag.Operation = new string[2] { "Add new", "Add" };
            return View("Save", new PedagoguVM());
        }
        [HttpPost]
        public ActionResult Save(PedagoguVM pedagoguVM)
        {

            if (!ModelState.IsValid)
                return View("save", pedagoguVM);


            service.ProfessorRegistration(pedagoguVM);
            return RedirectToAction("Index", "Home");
        }
        //Login
       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Pedagogu pedagogu)
        {
            if (ModelState.IsValid)
            {
                var user = service.Login(pedagogu);
               if (user!=null)
                    {
                        Session["UserID"] = user.Id;
                        Session["UserName"] = user.Emri.ToString();
                        return RedirectToAction("AfterLogin");
                    }
                
            }
            return View(pedagogu);
        }

        public ActionResult AfterLogin()
        {
            if (Session["UserID"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }
        //Logout
        public ActionResult LogOut()
        {
            Session["UserID"] = null;
            Session.Abandon();
          
            return RedirectToAction("Index", "Home");
        }
       
        
    }

}
