namespace Dato.ModelsCore
{
    using Entities;
    using Microsoft.AspNetCore.Identity;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    public class SeedDbCoreInDato
    {
        private readonly DataContextCore context;
        private readonly UserManager<User> userManager;
        private Random random;

        public SeedDbCoreInDato(DataContextCore context, UserManager<User> userManager)
        {
            this.context = context;
            this.userManager = userManager;
            this.random = new Random();
        }

        public async Task SeedDbCoreInDatoAsync()
        {
            await this.context.Database.EnsureCreatedAsync();

            var user = await this.userManager.FindByEmailAsync("carvin.viera@osdop.org.ar");
            if (user == null)
            {
                user = new User
                {
                    Id = "1",
                    FirstName = "Carvin Jourda",
                    LastName = "Viera Sanoja",
                    Email = "carvin.viera@osdop.org.ar",
                    UserName = "carvin.viera@osdop.org.ar",
                    PhoneNumber = "5491122538768",
                    LockoutEnd = DateTime.Now,
                };

                var result = await this.userManager.CreateAsync(user, "101284");
                if (result != IdentityResult.Success)
                {
                    throw new InvalidOperationException("Could not create the user in Seeder");
                }
            }

            if (!this.context.ProductosPruebaCores.Any())
            {
                this.AddProducts("Iphone X", user);
                this.AddProducts("I Waths Pro", user);
                this.AddProducts("Smart Tv 4k", user);
               await this.context.SaveChangesAsync();
            }
        }

        private void AddProducts(string Name, User user)
        {
            this.context.ProductosPruebaCores.Add(new ProductosPruebaCore
            {
                Name = Name,
                Price = this.random.Next(1000),
                IsAvailabe = true,
                Stock = this.random.Next(100),
                User = user
            });
        }
    }
}