using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CattleRaising.Models
{
    public class Country
    {
        [Key]
        public int CountryId { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe ser maximo {1} caracteres de longitud")]
        [Display(Name = "País")]
        public string Name { get; set; }

        //public virtual ICollection<Farm> Farms { get; set; }
    }
}