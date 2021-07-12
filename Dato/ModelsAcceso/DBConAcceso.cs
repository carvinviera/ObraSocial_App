
//namespace Dato.ModelsAcceso
//{
//    using System;
//    using Microsoft.EntityFrameworkCore;

//    public class DBConAcceso : DbContext
//    {
//        public DBConAcceso(DbContextOptions<DBConAcceso> options) : base(options) { }
//        public DbSet<aplicacion> aplicacion { get; set; }
//    }
//}

//se cambia de esta manera para hacerlo aun mas generico  no terminado

namespace Dato.ModelsAcceso.Entities
{
    using System;
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.Text;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

    public class DBConAcceso : DbContext
    {
        public DBConAcceso(DbContextOptions<DBConAcceso> options) : base(options) { }
        public DbSet<aplicacion> aplicacion { get; set; }
    }
}

