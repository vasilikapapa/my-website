using Laboratories.Models;
using Laboratories.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratories.Repository
{
    interface LaboratoryRepository
    {
        void CreateLaboratory(Laboratori laboratori);
      
        Laboratori GetLaboratoryById(int id);
        List<Laboratori> ListOfLaboratories();
        List<Laboratori> ListOfLaboratoriesById(int id);

    }
}
