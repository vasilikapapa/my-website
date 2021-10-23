using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboratories.ViewModels
{
    public class GrupiVM
    {
        public int Id { get; set; }
        public string EmriGrupit { get; set; }
        public int CikliStudimit { get; set; }
        public int Viti { get; set; }
        public string Perriudha { get; set; }
        public int UniversitetiId { get; set; }
        public int FakultetiId { get; set; }
        public int DegaId { get; set; }
    }
}