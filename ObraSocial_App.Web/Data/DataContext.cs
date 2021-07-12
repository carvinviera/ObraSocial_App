
namespace ObraSocial_App.Web.Data
{
    using Microsoft.EntityFrameworkCore;
    using Entities;
    public class DataContext : DbContext
    {
        public DbSet<ProducPruebaCore> ProducPruebaCores { get; set; }
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
           
        }
    }
}
