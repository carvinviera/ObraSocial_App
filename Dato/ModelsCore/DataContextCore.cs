namespace Dato.ModelsCore
{
    using Microsoft.EntityFrameworkCore;
    using Entities;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

    public class DataContextCore : IdentityDbContext<User>
    {
        public DbSet<ProductosPruebaCore> ProductosPruebaCores { get; set; }
        public DbSet<Country> Countries { get; set; }
        //public DbSet<User> Users { get; set; }
        public DataContextCore(DbContextOptions<DataContextCore> options) : base(options)
        {

        }
    }
}
