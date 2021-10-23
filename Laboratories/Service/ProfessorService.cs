using Laboratories.DTO;
using Laboratories.Models;
using Laboratories.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratories.Service
{
    interface ProfessorService
    {
        void ProfessorRegistration(PedagoguVM pedagoguVM);
        Pedagogu ConvertToModel(PedagoguVM studentiVM, bool trueForCreateFalseForEdit);
        List<Pedagogu> ListOfProfessors();
       List<PedagoguDTO> ListOfProfessors(string query = null);
        Pedagogu GetProfessorById(int id);
        PedagoguVM ConvertToViewModel(Pedagogu pedagogu);
        Pedagogu Login(Pedagogu pedagogu);
       
    }
}
