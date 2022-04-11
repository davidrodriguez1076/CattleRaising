using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CattleRaising.Models
{
    public class Municipality
    {
        [Key]
        public int Municipalityid { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Range(1, double.MaxValue, ErrorMessage = "You must enter a {0}")]
        public int DepartmentId { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Display(Name = "Municipio")]
        public string Name { get; set; }
        //relaciones
        public virtual Department Department { get; set; }

        //public virtual ICollection<Farm> Farms { get; set; }
    }
}