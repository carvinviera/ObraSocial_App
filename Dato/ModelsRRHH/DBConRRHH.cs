namespace Dato.ModelsRRHH
{
    using System;
    using Microsoft.EntityFrameworkCore;

    public class DBConRRHH: DbContext
    {
        public DBConRRHH(DbContextOptions<DBConRRHH> options): base(options)  { }
        public DbSet<Areas> Areas { get; set; }
    }
}
