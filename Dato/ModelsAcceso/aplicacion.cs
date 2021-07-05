using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Dato.ModelsAcceso;

namespace Dato.ModelsAcceso
{
    [Table("aplicacion")]
    public partial class aplicacion
    {
        [Key]
        public int id { get; set; }

        [MaxLength(50, ErrorMessage = "El campo solo permite 50 caracteres.")]
        [Display(Name = "Descripción")]
        [Required] //Se pueden hace migraciones-.... Migración  a la base cuando es code first.. comandos en consola...
        public string descripcion { get; set; }
    }
}

