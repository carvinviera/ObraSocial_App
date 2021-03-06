namespace Dato.ModelsAcceso.Entities
{
    using Dato.ModelsCore.Entities;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    public interface IRepository
    {
        void AddAplicacion(aplicacion _aplication);

        bool AplicacionExists(int id);

        aplicacion GetAplicacion(int id);

        IEnumerable<ProductosPruebaCore> GetProducts();

        IEnumerable<aplicacion> GetAplicacions();

        void RemoveAplicacion(aplicacion _aplication);

        Task<bool> SaveAllAsync();

        void UpdateAplicacion(aplicacion _aplication);

    }
}