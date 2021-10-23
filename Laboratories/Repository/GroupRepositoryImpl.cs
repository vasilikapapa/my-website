using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Laboratories.Models;

namespace Laboratories.Repository
{
    public class GroupRepositoryImpl : GroupRepository
    {
            private LaboratoriesEntities db;

        public GroupRepositoryImpl()
        {
            db = new LaboratoriesEntities();
        }
        public void AddGroup(Grupi grupi)
        {
            db.Grupis.Add(grupi);
            db.SaveChanges();

        }

        public SelectList GetSelectDegreesListForViewBag(int id)
        {
            return new SelectList(db.Degas.Where(m=>m.FakultetiId.Equals(id)), "Id", "Emri");
        }

        public SelectList GetSelectFacultyListForViewBag(int id)
        {
            return new SelectList(db.Fakultetis.Where(m => m.UniversitetiId.Equals(id)), "Id", "Emri");
        }

        public SelectList GetSelectUniversityListForViewBag()
        {
            return new SelectList(db.Universitetis, "Id", "Emri");
        }
    }
}