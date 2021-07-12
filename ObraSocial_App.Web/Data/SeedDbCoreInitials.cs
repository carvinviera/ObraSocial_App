namespace ObraSocial_App.Web.Data
{
    using Entities;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    public class SeedDbCoreInitials
    {
        private readonly DataContext context;
        private Random random;

        public SeedDbCoreInitials(DataContext context)
        {
            this.context = context;
            this.random = new Random();
        }

        public async Task SeedDbCoreInitialsAsync()
        {
            if (!this.context.ProducPruebaCores.Any())
            {
                this.AddProducts("First Product");
                this.AddProducts("Second Product");
                this.AddProducts("Third Product");
                await this.context.SaveChangesAsync();
            }
        }

        private void AddProducts(string Name)
        {
            this.context.ProducPruebaCores.Add(new ProducPruebaCore
            {
                Name = Name,
                Price = this.random.Next(1000),
                IsAvailabe = true,
                Stock = this.random.Next(100)
            });
        }
    }
}
