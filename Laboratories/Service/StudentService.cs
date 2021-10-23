using Laboratories.Models;
using Laboratories.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratories.Service
{
    interface StudentService
    {
       // List<Studenti> ListOfStudents();
        
        void StudentRegistration(StudentiVM studentiVM);
        Studenti ConvertToModel(StudentiVM studentiVM, bool trueForCreateFalseForEdit);
    }
}
