using Laboratories.Models;
using Laboratories.Repository;
using Laboratories.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboratories.Service
{
    public class StudentServiceImpl : StudentService
    {
        private StudentRepository repository;

        
        public StudentServiceImpl()
        {
            repository = new StudentRepositoryImpl();
          

        }

        public void StudentRegistration(StudentiVM studentiVM)
        {
          Studenti studenti = ConvertToModel(studentiVM, true);
            repository.StudentRegistration(studenti);
        }

        

        public Studenti ConvertToModel(StudentiVM studentiVM, bool trueForCreateFalseForEdit)
        {
            var studenti = new Studenti
            {
              
                Emri = studentiVM.Emri,
                Mbiemri = studentiVM.Mbiemri,
                NrPersonal = studentiVM.NrPersonal,
                Email = studentiVM.Email,
                Password = studentiVM.Password
                


            };
            if (!trueForCreateFalseForEdit)
            {
                studenti.Id = studentiVM.Id;
            }

            return studenti;
        }

    }
}