using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dato.ModelsAcceso.Entities
{
    public class SeedDb //clase que alimenta la base desde que arranca el programa
                        //ejemplo de una clase con acceso a datos
    {
        private readonly DBConAcceso db;
        private readonly UserManager<ActiveDiretoryUsers> userManager;
        private Random random;

        public SeedDb(DBConAcceso db, UserManager<ActiveDiretoryUsers> userManager)
        {
            this.db = db;
            //this.userManager = userManager;
            this.random = new Random();
        }

        public async Task SeedAsync()
        {
            await this.db.Database.EnsureCreatedAsync();

            //var user = await this.userManager.FindByEmailAsync("carvin.viera@gmail.com"); //Ver si existe el usuario
            //if (user == null)
            //{
            //    var FechaHoy = new DateTime();
            //    FechaHoy = DateTime.Now;
            //    user = new ActiveDiretoryUsers
            //    {
            //        //id
            //        Usuario = "carvin.viera1",
            //        Nombre = "Carvin Jourdan Viera Sanoja 1",
            //        Legajo = 222222,
            //        Delegacion = "0000",
            //        Mails = "carvin.viera@gmail.com",
            //        Telefono = "1122538768",
            //        Activo = true,
            //        FechaDeRelevamiento = FechaHoy,
            //        Email = "carvin.viera@gmail.com",
            //        UserName = "carvin.viera@gmail.com",
            //        PhoneNumber = "1122538768"    
            //    };
                //203    carvin.viera    Carvin Jourdan Viera Sanoja 2939    0000    carvin.viera@osdop.org.ar   NULL    1   2021 - 07 - 02 03:00:00.793
                //var result = await this.userManager.CreateAsync(user, "123456");
                //if (result != IdentityResult.Success)
                //{
                //    throw new InvalidOperationException("No pudo crearse el Usuario en Seeder");
                //}

            //}
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
