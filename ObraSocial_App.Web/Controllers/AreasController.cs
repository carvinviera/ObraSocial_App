using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dato.ModelsRRHH;
using Business;

namespace ObraSocial_App.Web.Controllers
{
    public class AreasController : Controller
    {
        private DBConRRHH db;
        public AreasController(DBConRRHH _context) { db = _context; }

        //private AreasBusiness _AreasBusiness;
        public IActionResult Index()
        {
            //if (_AreasBusiness == null) { _AreasBusiness = new AreasBusiness(); }
            ViewBag.Areas = db.Areas.ToList(); 
            //ViewBag.Areas = _AreasBusiness.getAll();
            return View();
        }
    }
}
