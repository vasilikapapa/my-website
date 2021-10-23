using Laboratories.Models;
using Laboratories.Service;
using Laboratories.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Laboratories.Controllers
{
    public class LaboratoryController : Controller
    {
        private LaboratoryService service;
        private ProfessorService professoService;
       
       
        public LaboratoryController()
        {
            service = new LaboratoryServiceImpl();
           
        }
        // GET: Laboratory
        public ActionResult Index()
        {
            return View();
        }
  
        public ActionResult Create()
        {

            //  ViewBag.MembershipTypeId = membershipTypeService.GetSelectListForViewBag();
            // ViewBag.Operation = new string[2] { "Add new", "Add" };
           
            int id = Convert.ToInt32(Session["UserID"]);
            ViewData["laboratories"] = service.ListOfLAboratoriesById(id);
                return View("Save", new LaboratoriVM());
            
           
        }
        [HttpPost]
        public ActionResult Save(LaboratoriVM laboratoriVM)
        {

            if (!ModelState.IsValid)
                return View("save", laboratoriVM);

            service.CreateLaboratory(laboratoriVM);
            ViewData["laboratories"] = laboratoriVM;
            return RedirectToAction("Create");
        }

    }
}