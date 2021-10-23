using Laboratories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratories.Repository
{
    interface ProfessorRepository
    {
        IQueryable<Pedagogu> ListOfProfessors(string query);
        void ProfessorRegistration(Pedagogu pedagogu);
        Pedagogu GetProfessorById(int id);
        List<Pedagogu> ListOfProfessors();
        Pedagogu Login(Pedagogu pedagogu);
    }
}
