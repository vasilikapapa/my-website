using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboratories.ViewModels
{
    public class LaboratoriVM
    {
        public int Id { get; set; }
        public string Emri { get; set; }
        public string Lenda { get; set; }
        public int CikliStudimit { get; set; }
        public string Perriudha { get; set; }
        public int PedagoguId { get; set; }
    }
}