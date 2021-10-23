using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboratories.ViewModels
{
    public class PedagoguVM
    {
        public int Id { get; set; }
        public int NrPersonal { get; set; }
        public string Emri { get; set; }
        public string Mbiemri { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}