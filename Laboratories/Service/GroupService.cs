using Laboratories.Models;
using Laboratories.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Laboratories.Service
{
    interface GroupService
    {

        void AddGroup(GrupiVM grupiVM);
      
        SelectList GetSelectUniversityListForViewBag();
        SelectList GetSelectFacultyListForViewBag(int id);
        SelectList GetSelectDegreesListForViewBag(int id);

    }
}
