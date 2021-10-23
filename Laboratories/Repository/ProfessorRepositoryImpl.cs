using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Laboratories.Models;

namespace Laboratories.Repository
{
    public class ProfessorRepositoryImpl : ProfessorRepository
    {
        private LaboratoriesEntities db;

        public ProfessorRepositoryImpl()
        {
            db = new LaboratoriesEntities();
        }

        public Pedagogu Login(Pedagogu pedagogu)
        {
           var user= db.Pedagogus.Where(m => m.Email.Equals(pedagogu.Email) && m.Password.Equals(pedagogu.Password)).FirstOrDefault();
            return user;
        }

        public Pedagogu GetProfessorById(int id)
        {
            return db.Pedagogus.Find(id);
        }

        public List<Pedagogu> ListOfProfessors()
        {
            return db.Pedagogus.ToList();
        }

        public IQueryable<Pedagogu> ListOfProfessors(string query)
        {
            var professors= db.Pedagogus.Where(c => c.Emri.Contains(query));

            return professors;
        }

        public void ProfessorRegistration(Pedagogu pedagogu)
        {
            db.Pedagogus.Add(pedagogu);
            db.SaveChanges();
        }

        
    }
}