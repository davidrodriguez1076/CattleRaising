using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CattleRaising.Models
{
    public class Farm
    {
        [Key]
        public int FarmId { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe ser maximo {1} caracteres de longitud")]
        [Display(Name = "Nombre granja")]
        public string Name { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Display(Name = "País")]
        public int CountryId { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Display(Name = "Departamento")]
        public int DepartmentId { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Display(Name = "Municipio")]
        public int Municipalityid { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Display(Name = "Municipio")]
        public int ExploitationId { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe ser maximo {1} caracteres de longitud")]
        [Display(Name = "Localidad")]
        public string Location { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe ser maximo {1} caracteres de longitud")]
        [Display(Name = "Longitud")]
        public string Length { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe ser maximo {1} caracteres de longitud")]
        [Display(Name = "Latitud")]
        public string Latitude { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe ser maximo {1} caracteres de longitud")]
        [Display(Name = "Hectarias")]
        public string Hectares { get; set; }

        public virtual Country Country { get; set; }
        public virtual Department Department { get; set; }
        public virtual Municipality Municipality { get; set; }
        public virtual Exploitation Exploitation { get; set; }        
    }
}