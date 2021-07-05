using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dato.ModelsAcceso;

namespace ObraSocial_App.Web.Controllers
{
    public class aplicacionController : Controller
    {
        //private DBConAcceso db; se quito para inyectar repo y no el dbcontext
        //public aplicacionController(DBConAcceso _context) { db = _context; }se quito para inyectar repo y no el dbcontext
        private readonly IRepository repository; // se inyecta el repo
        public aplicacionController(IRepository repository) {
            this.repository = repository;
        } // se inyecta el repo
        public IActionResult Index()
        {
            //ViewBag.Aplicacion = this.repository.GetAplicacions();
            IEnumerable<aplicacion> apl = this.repository.GetAplicacions();
            return View(apl);
        }

        // GET: aplicacionController/Details/5
        public IActionResult Details(int id)
        {
            //if (id == null)
            //{
            //    return NotFound(); 
            //}

            var _aplicacion = this.repository.GetAplicacion(id);
            if (_aplicacion == null)
            {
                return NotFound();
            }

            return View(_aplicacion);
        }

        // GET: aplicacionController/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: aplicacionController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(aplicacion _aplicacion)
        {
            //try
            //{
                if (ModelState.IsValid)
                {
                    this.repository.AddAplicacion(_aplicacion);
                    await this.repository.SaveAllAsync();
                    return RedirectToAction(nameof(Index));
                }
                return View(_aplicacion);
            //}
            //catch
            //{
            //    return View();
            //}
        }

        // GET: aplicacionController/Edit/5
        public IActionResult Edit(int id)
        {
            //if (id == null)
            //{
            //    return NotFound();
            //}

            var _aplicacion = this.repository.GetAplicacion(id);
            if (_aplicacion == null)
            {
                return NotFound();
            }

            return View(_aplicacion);

        }

        // POST: aplicacionController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(aplicacion aplicacion)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    this.repository.UpdateAplicacion(aplicacion);
                    await this.repository.SaveAllAsync();
                }
                catch
                {
                    if (!this.repository.AplicacionExists(aplicacion.id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }     
                }
                return RedirectToAction(nameof(Index));
            }
            return View(aplicacion);
            
        }

        // GET: aplicacionController/Delete/5
        public IActionResult Delete(int id)
        {
            //if (id == null)
            //{
            //    return NotFound();
            //}

            var aplicacion = this.repository.GetAplicacion(id);
            if (aplicacion == null)
            {
                return NotFound();
            }

            return View(aplicacion);
        }

        // POST: aplicacionController/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var aplicacion = this.repository.GetAplicacion(id);
            this.repository.RemoveAplicacion(aplicacion);
            await this.repository.SaveAllAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
