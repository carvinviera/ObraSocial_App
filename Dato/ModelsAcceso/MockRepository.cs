using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Dato.ModelsAcceso.Entities
{
    public class MockRepository : IRepository
    {
        public void AddAplicacion(aplicacion _aplication)
        {
            throw new NotImplementedException();
        }

        public bool AplicacionExists(int id)
        {
            throw new NotImplementedException();
        }

        public aplicacion GetAplicacion(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<aplicacion> GetAplicacions()
        {
            var _aplicacion = new List<aplicacion>();
            _aplicacion.Add(new aplicacion { id = 1, descripcion = "Aplicaciones nuevas de prueba" });
            _aplicacion.Add(new aplicacion { id = 2, descripcion = "Aplicaciones nuevas de prueba 1" });
            _aplicacion.Add(new aplicacion { id = 3, descripcion = "Aplicaciones nuevas de prueba 2" });
            _aplicacion.Add(new aplicacion { id = 4, descripcion = "Aplicaciones nuevas de prueba 3" });
            return _aplicacion;
        }

        public void RemoveAplicacion(aplicacion _aplication)
        {
            throw new NotImplementedException();
        }

        public Task<bool> SaveAllAsync()
        {
            throw new NotImplementedException();
        }

        public void UpdateAplicacion(aplicacion _aplication)
        {
            throw new NotImplementedException();
        }
    }
}
