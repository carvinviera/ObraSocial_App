namespace Dato.ModelsAcceso.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Text;
    using Microsoft.AspNetCore.Identity;

    public partial class ActiveDiretoryUsers //: IdentityUser
    {
        [Key]
        public int id { get; set; }

        [MaxLength(255)]
        [Display(Name = "Usuario")]
        public string Usuario { get; set; }

        [MaxLength(1000)]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }

        [Display(Name = "Legajo")]
        public int? Legajo { get; set; }

        [MaxLength(255)]
        [Display(Name = "Delegación")]
        public string Delegacion { get; set; }

        [MaxLength(1000)]
        [Display(Name = "Mails")]
        public string Mails { get; set; }

        [MaxLength(255)]
        [Display(Name = "Teléfono")]
        public string Telefono { get; set; }

        [Display(Name = "Activo")]
        public bool? Activo { get; set; }

        [Display(Name = "Fecha Relevamiento")]
        public DateTime? FechaDeRelevamiento { get; set; }

    }
}

    //[Table("aplicacion")]
    //public partial class aplicacion
    //{
     
    //    [MaxLength(50, ErrorMessage = "El campo solo permite 50 caracteres.")]
    //    [Display(Name = "Descripción")]
    //    [Required] //Se pueden hace migraciones-.... Migración  a la base cuando es code first.. comandos en consola...
    //    public string descripcion { get; set; }
    //}

