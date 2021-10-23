using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Laboratories.Models;
using Laboratories.Repository;
using Laboratories.ViewModels;

namespace Laboratories.Service
{
    public class LaboratoryServiceImpl : LaboratoryService
    {
        private LaboratoryRepository repository;
        public LaboratoryServiceImpl()
        {
            repository = new LaboratoryRepositoryImpl();


        }

        public Laboratori ConvertToModel(LaboratoriVM laboratoriVM, bool trueForCreateFalseForEdit)
        {
            var laboratori = new Laboratori
            {
               Emri=laboratoriVM.Emri,
                Lenda=laboratoriVM.Lenda,
                 CikliStudimit=laboratoriVM.CikliStudimit,
                  Perriudha=laboratoriVM.Perriudha,
                  PedagoguId=laboratoriVM.PedagoguId



            };
            if (!trueForCreateFalseForEdit)
            {
                laboratori.Id = laboratoriVM.Id;
            }

            return laboratori;
        }

        public LaboratoriVM ConvertToViewModel(Laboratori laboratori)
        {
            var laboratoriVM = new LaboratoriVM
            {
                Id = laboratori.Id,
                Emri = laboratori.Emri,
                Lenda =laboratori.Lenda,
                 CikliStudimit= laboratori.CikliStudimit,
                  Perriudha=laboratori.Perriudha,
                   PedagoguId=laboratori.PedagoguId


            };

            return laboratoriVM;
        }

        public void CreateLaboratory(LaboratoriVM laboratoriVM)
        {

            Laboratori laboratori = ConvertToModel(laboratoriVM, true);
            repository.CreateLaboratory(laboratori);
        }

        public Laboratori GetLaboratoryById(int id)
        {
            return repository.GetLaboratoryById(id);
        }

        public List<Laboratori> ListOfLAboratories()
        {
            return repository.ListOfLaboratories();
        }

        public List<Laboratori> ListOfLAboratoriesById(int id)
        {
            return repository.ListOfLaboratoriesById(id);
        }
    }
}