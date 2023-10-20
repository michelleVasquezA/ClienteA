using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClienteA.Models
{
    [Table("Inscritos_Vacante")]
    public class InscritosxVacante
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id")]
        public int Id { get; set; }

        [Column("DNI")]
        [Display(Name = "DNI", Prompt ="Ingresa tu DNI")]
        public string? DNI{get; set; }

        [Column("Nombre")]
        [Display(Name = "Nombres", Prompt ="Ingresa tu nombre")]
        public string? Nombre{get; set; }

        [Column("ApellidoPaterno")]
        [Display(Name = "Apellido Paterno", Prompt ="Ingresa tu apellido")]
        public string? ApellidoPaterno {get; set; }

        [Column("ApellidoMaterno")]
        [Display(Name = "Apellido Materno")]
        public string? ApellidoMaterno {get; set; }
        
        [Column("FechaNacimiento")]
        [Display(Name = "FechaNac")]
        public string? FechaNacimiento { get; set; }

        [Column("Grado")]
        [Display(Name = "Grado")]
        public int? Grado { get; set; }

        [Column("Voucher")]
        [Display(Name = "Vocuher")]
        public string? ImageVoucher { get; set; }
        
        [Column("Apoderado")]
        [Display(Name = "Apoderado")]
        public string? Apoderado {get; set; }

        [Column("Celular")]
        [Phone]
        [Display(Name = "Celular",Prompt = "999-999-999")]
        public string? Celular {get; set; }
    }
}