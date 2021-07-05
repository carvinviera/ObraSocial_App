using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Dato.ModelsRRHH;

namespace Dato.ModelsRRHH
{
    [Table("Areas")]
    public partial class Areas
    {
        [Key]
        public int id { get; set; }
        public string nombre { get; set; }
        public string observaciones { get; set; }
        public string estado { get; set; }

    }

    public class AreasRepository
    {

    //    private DBCon db;
    //    public AreasRepository(DBCon _context) { db = _context; }


    //    public List<Areas> getAll()
    //    {
    //        return new List<Areas>(); // db.Areas.ToList();
    //    }


    }




}
