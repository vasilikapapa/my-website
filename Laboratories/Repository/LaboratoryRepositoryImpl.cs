using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Laboratories.Models;
using Laboratories.ViewModels;

namespace Laboratories.Repository
{
    public class LaboratoryRepositoryImpl : LaboratoryRepository
    {
        private LaboratoriesEntities db;

        public LaboratoryRepositoryImpl()
        {
            db = new LaboratoriesEntities();
        }
        public void CreateLaboratory(Laboratori laboratori)

        { 
            db.Laboratoris.Add(laboratori);
            db.SaveChanges();
        }

        public Laboratori GetLaboratoryById(int id)
        {
            return db.Laboratoris.Find(id);
        }

        public List<Laboratori> ListOfLaboratories()
        {
            return db.Laboratoris.ToList();
        }

        public List<Laboratori> ListOfLaboratoriesById(int id)
        {
            return db.Laboratoris.Where(m => m.PedagoguId.Equals(id)).ToList();
        }
    }
}