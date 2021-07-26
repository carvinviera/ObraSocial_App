namespace Dato.ModelsCore.Entities
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IEntity //obliga a que en todas las entities tenga explicitamente la propiedad Id
    {
        int Id { get; set; }
        //bool WasDeleted { get; set; } //en un futuro para quizas recuperar un borrado

        //(algo asi como auditar hacer lo mismo para iAuditar en Osdop) solo que en la deficinio de la clase si se debe colocar explicitamente
    }
}
