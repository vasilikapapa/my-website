using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Laboratories.DTO;
using Laboratories.Models;
using Laboratories.Repository;
using Laboratories.ViewModels;

namespace Laboratories.Service
{
    public class ProfessorServiceImpl : ProfessorService
    {
        private ProfessorRepository repository;
        public ProfessorServiceImpl()
        {
            repository = new ProfessorRepositoryImpl();


        }

        public Pedagogu ConvertToModel(PedagoguVM pedagoguVM, bool trueForCreateFalseForEdit)
        {
            var pedagogu = new Pedagogu
            {
                
                Emri = pedagoguVM.Emri,
                Mbiemri = pedagoguVM.Mbiemri,
                NrPersonal = pedagoguVM.NrPersonal,
                Email = pedagoguVM.Email,
                Password = pedagoguVM.Password 
                 



            };
            if (!trueForCreateFalseForEdit)
            {
                pedagogu.Id =pedagoguVM.Id;
            }

            return pedagogu;
        }

        public PedagoguVM ConvertToViewModel(Pedagogu pedagogu)
        {
            var pedagoguVM = new PedagoguVM
            {
                Id = pedagogu.Id,
                Email=pedagogu.Email,
                 Emri=pedagogu.Emri,
                  Mbiemri=pedagogu.Mbiemri,
                   NrPersonal=pedagogu.NrPersonal,
                     Password =pedagogu.Password
                       

            };

            return pedagoguVM;
        }

        public Pedagogu GetProfessorById(int id)
        {
            return repository.GetProfessorById(id);
        }

        public List<Pedagogu> ListOfProfessors()
        {
            return repository.ListOfProfessors();
        }

        public List<PedagoguDTO> ListOfProfessors(string query = null)
        {
            return repository.ListOfProfessors(query)
                          .Select(Mapper.Map<Pedagogu, PedagoguDTO>)
                          .ToList();
        }

        public Pedagogu Login(Pedagogu pedagogu)
        {
          return  repository.Login(pedagogu);

        }

        public void ProfessorRegistration(PedagoguVM pedagoguVM)
        {
            Pedagogu pedagogu = ConvertToModel(pedagoguVM, true);
            repository.ProfessorRegistration(pedagogu);
        }

    }


}