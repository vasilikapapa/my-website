using Laboratories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboratories.Repository
{
    public class StudentRepositoryImpl : StudentRepository
    {
        private LaboratoriesEntities db;

        public StudentRepositoryImpl()
        {
            db = new LaboratoriesEntities();
        }

        public List<Studenti> ListOfStudents()
        {
            return db.Studentis.ToList();
        }

        public void StudentRegistration(Studenti studenti)
        {
            db.Studentis.Add(studenti);
            db.SaveChanges();
        }
    }
}