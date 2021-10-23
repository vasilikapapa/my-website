using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Laboratories.Models;
using Laboratories.Repository;
using Laboratories.ViewModels;

namespace Laboratories.Service
{
    public class GroupServiceImpl : GroupService
    {
        private GroupRepository repository;

        public GroupServiceImpl()
        {
            repository = new GroupRepositoryImpl();
        }
        public void AddGroup(GrupiVM grupiVM)
        {
            var grupi = new Grupi
            {
               CikliStudimit=grupiVM.CikliStudimit,
                 DegaId=grupiVM.DegaId,
                  Emri=grupiVM.EmriGrupit,
                   FakultetiId=grupiVM.FakultetiId,
                    UniversitetiId=grupiVM.UniversitetiId,
                    Perriudha=grupiVM.Perriudha
            };
            repository.AddGroup(grupi);
        }

        public SelectList GetSelectDegreesListForViewBag()
        {
            return repository.GetSelectDegreesListForViewBag(int id);
        }

        public SelectList GetSelectFacultyListForViewBag()
        {
            return repository.GetSelectFacultyListForViewBag(int id);
        }

        public SelectList GetSelectUniversityListForViewBag()
        {
            return repository.GetSelectUniversityListForViewBag();
        }

    }
}