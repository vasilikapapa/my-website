using Laboratories.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Laboratories.ViewModels
{
    public class StudentiVM
    {
        public int Id { get; set; }
        [Required]
        public string Emri { get; set; }
        [Required]
        public string Mbiemri { get; set; }
        public int NrPersonal { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        public int GrupiId { get; set; }
        public int GrupiLabId { get; set; }
        public virtual Grupi Grupi { get; set; }

    }
}