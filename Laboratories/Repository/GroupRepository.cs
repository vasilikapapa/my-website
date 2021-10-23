using Laboratories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Laboratories.Repository
{
    interface GroupRepository
    {
        void AddGroup(Grupi grupi);
        SelectList GetSelectUniversityListForViewBag();
        SelectList GetSelectFacultyListForViewBag(int id);
        SelectList GetSelectDegreesListForViewBag(int id);
    }
}
