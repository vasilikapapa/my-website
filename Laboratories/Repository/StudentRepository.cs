using Laboratories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratories.Repository
{
    interface StudentRepository
    {
        List<Studenti> ListOfStudents();
       void StudentRegistration(Studenti studenti);
       
    }
}
