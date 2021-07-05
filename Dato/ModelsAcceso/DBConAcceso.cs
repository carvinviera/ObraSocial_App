using System;
using System.Collections.Generic;
using System.Text;

namespace Dato.ModelsAcceso
{
    using System;
    using Microsoft.EntityFrameworkCore;

    public class DBConAcceso : DbContext
    {
        public DBConAcceso(DbContextOptions<DBConAcceso> options) : base(options) { }
        public DbSet<aplicacion> aplicacion { get; set; }
    }
}

