using Laboratories.Service;
using Laboratories.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Laboratories.Controllers
{
    public class StudentController : Controller
    {
        private StudentService service;
        private GroupService groupService;

        public StudentController()
        {
            service = new StudentServiceImpl();
            groupService = new GroupServiceImpl();
        }
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Create()
        {
            //  ViewBag.MembershipTypeId = membershipTypeService.GetSelectListForViewBag();
            // ViewBag.Operation = new string[2] { "Add new", "Add" };
            ViewBag.UniversitetiId = groupService.GetSelectUniversityListForViewBag();
            ViewBag.MembershipTypeId = groupService.GetSelectFacultyListForViewBag();
            ViewBag.MembershipTypeId = groupService.GetSelectDegreesListForViewBag();
            return View("Save",new IndexModelView());
        }
        [HttpPost]
        public ActionResult Save(StudentiVM studentiVM)
        {

            if (!ModelState.IsValid)
                return View("save",studentiVM);
           

            service.StudentRegistration(studentiVM);
            return RedirectToAction("Index", "Home");
        }

    }
}