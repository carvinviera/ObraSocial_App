using System;
using System.Collections.Generic;
using System.Text;
using Dato.ModelsAcceso;

namespace Dato
{
    public class Repository
    {
       
        private readonly DBConAcceso db;
        public Repository(DBConAcceso db)
        {
            this.db = db;
        }
    }
}



