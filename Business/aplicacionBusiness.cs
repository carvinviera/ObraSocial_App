namespace Business
{
    using Dato.ModelsAcceso.Entities;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class aplicacionBusiness
    {
        private readonly IRepository repository; // se inyecta el repo
        public aplicacionBusiness(IRepository repository)
        {
            this.repository = repository;
        } // se inyecta el repo

        public IEnumerable<aplicacion> GetAplicacions()
        {
            IEnumerable<aplicacion> apl = this.repository.GetAplicacions();
            return apl;
        }

        public aplicacion GetAplicacion(int id)
        {
            return this.repository.GetAplicacion(id);
        }

        public void AddAplicacion(aplicacion _aplication)
        {
            this.repository.AddAplicacion(_aplication);
        }

        public void UpdateAplicacion(aplicacion _aplication)
        {
            this.repository.UpdateAplicacion(_aplication);
        }
        public void RemoveAplicacion(aplicacion _aplication)
        {
            this.repository.RemoveAplicacion(_aplication);
        }

        public async Task<bool> SaveAllAsync()
        {
            return await this.repository.SaveAllAsync();
        }

        public bool AplicacionExists(int id)
        {
            return this.repository.AplicacionExists(id);
        }
    }
}

