
namespace ObraSocial_App.Web.Data.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class ProducPruebaCore
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(255, ErrorMessage = "El campo {0} solo puede contener {1} caracteres de longitud")]
        [Required]
        public string Name { get; set; }

        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        [Column(TypeName = "decimal(18,4)")]
        public decimal Price { get; set; }

        [Display(Name = "Image")]
        public string ImageUrl { get; set; }

     
        [Display(Name = "Last Purchase")]
        [Column(TypeName = "DateTime")]
        public DateTime? LastPurchase { get; set; }

        [Display(Name = "Last Sale")]
        [Column(TypeName = "DateTime")]
        public DateTime? LastSale { get; set; }

        [Display(Name = "Is Availabe")]
        public bool IsAvailabe { get; set; }


        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = false)]
        public double Stock { get; set; }


    }
}
