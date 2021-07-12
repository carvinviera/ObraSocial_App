namespace Dato.ModelsAcceso.Entities
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    public class Repository : IRepository
    {
        private readonly DBConAcceso db;
        public Repository(DBConAcceso db)
        {
            this.db = db;
        }

        public IEnumerable<aplicacion> GetAplicacions()
        {
            return this.db.aplicacion.OrderBy(p => p.id);
        }

        public aplicacion GetAplicacion(int id)
        {
            return this.db.aplicacion.Find(id);
        }

        public void AddAplicacion(aplicacion _aplication)
        {
            this.db.aplicacion.Add(_aplication);
        }

        public void UpdateAplicacion(aplicacion _aplication)
        {
            this.db.aplicacion.Update(_aplication);
        }
        public void RemoveAplicacion(aplicacion _aplication)
        {
            this.db.aplicacion.Remove(_aplication);
        }

        public async Task<bool> SaveAllAsync()
        {
            return await this.db.SaveChangesAsync() > 0;
        }

        public bool AplicacionExists(int id)
        {
            return this.db.aplicacion.Any(p => p.id == id);
        }
    }
}


