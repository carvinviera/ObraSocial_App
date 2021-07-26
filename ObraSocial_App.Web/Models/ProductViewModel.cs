namespace ObraSocial_App.Web.Models
{
    using Dato.ModelsCore.Entities;
    using Microsoft.AspNetCore.Http;
    using System.ComponentModel.DataAnnotations;
    public class ProducViewModel : ProductosPruebaCore
    {
        [Display(Name = "Image")]
        public IFormFile ImageFile { get; set; }
    }
}
