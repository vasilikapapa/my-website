using AutoMapper;
using Laboratories.Models;
using Laboratories.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboratories.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Pedagogu, PedagoguDTO>();
  
 
        }
    }
}