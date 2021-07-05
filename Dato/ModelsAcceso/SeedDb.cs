
namespace Dato.ModelsAcceso
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class SeedDb //clase que alimenta la base desde que arranca el programa
                        //ejemplo de una clase con acceso a datos
    {
        private readonly DBConAcceso db;
        private Random random;

        public SeedDb(DBConAcceso db)
        {
            this.db = db;
            this.random = new Random();
        }

        public async Task SeedAsync()
        {
            await this.db.Database.EnsureCreatedAsync();

            if (!this.db.aplicacion.Any()) //si no hay ningun registro //por ahora lo quito para probar
            {
                this.AddAplicacion("Aplicacion Nueva una");
                this.AddAplicacion("Aplicacion Nueva dos");
                this.AddAplicacion("Aplicacion Nueva tres");
                await this.db.SaveChangesAsync();
            }
        }

        private void AddAplicacion(string descrip)
        {
            this.db.aplicacion.Add(new aplicacion
            {
                descripcion = descrip
                //,Price = this.random.Next(1000) //uso de random => numeros aleatorios 
            });
        }
    }
}
