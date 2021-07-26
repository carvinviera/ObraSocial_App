namespace Dato.ModelsCore
{
    using Dato.Helper;
    using Entities;
    using Microsoft.AspNetCore.Identity;
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    public class SeedDbCoreInDato
    {
        private readonly DataContextCore context;
        //private readonly UserManager<User> userManager;
        private readonly IUserHelper userHelper;
        private readonly Random random;

        public SeedDbCoreInDato(DataContextCore context, IUserHelper userHelper)
        {
            this.context = context;
            this.userHelper = userHelper;
            random = new Random();
        }

        public async Task SeedDbCoreInDatoAsync()
        {
            await context.Database.EnsureCreatedAsync();

            //var user = await this.userManager.FindByEmailAsync("carvin.viera@osdop.org.ar");
            var user = await userHelper.GetUserByMailAsync("carvin.viera@osdop.org.ar");
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

                //var result = await this.userManager.CreateAsync(user, "101284");
                var result = await userHelper.AddUserAsync(user, "101284");
                if (result != IdentityResult.Success)
                {
                    throw new InvalidOperationException("Could not create the user in Seeder");
                }
            }

            if (!context.ProductosPruebaCores.Any())
            {
                AddProducts("Iphone X", user);
                AddProducts("I Waths Pro", user);
                AddProducts("Smart Tv 4k", user);
                await context.SaveChangesAsync();
            }
        }

        private void AddProducts(string Name, User user)
        {
            context.ProductosPruebaCores.Add(new ProductosPruebaCore
            {
                Name = Name,
                Price = random.Next(1000),
                IsAvailabe = true,
                Stock = random.Next(100),
                User = user
            });
        }
    }
}