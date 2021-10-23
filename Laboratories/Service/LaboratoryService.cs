using Laboratories.Models;
using Laboratories.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratories.Service
{
    interface LaboratoryService
    {
        void CreateLaboratory(LaboratoriVM laboratoriVM);
      
      Laboratori ConvertToModel(LaboratoriVM laboratoriVM, bool trueForCreateFalseForEdit);
        List<Laboratori> ListOfLAboratories();
        List<Laboratori> ListOfLAboratoriesById(int id);

        Laboratori GetLaboratoryById(int id);
        LaboratoriVM ConvertToViewModel(Laboratori laboratori);
    }
}
