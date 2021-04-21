using System.Collections.Generic;
using System.Linq;
using Gimnasio.Data;
using Microsoft.AspNetCore.Mvc;


namespace Gimnasio.Controllers
{
    public class GimnasioController : Controller
    {
        private GimnasioContext _context;
        public GimnasioController(GimnasioContext context)
        {
            _context = context;
        }

        public IActionResult Nuevo() {
            return View();
        }

        [HttpPost]
        public IActionResult Nuevo(Gimnasio p) {
            if (ModelState.IsValid) {
                // Guardar el objeto Pokemon (p)
                _context.Add(p);
                _context.SaveChanges();
                
                return RedirectToAction("Lista");
            }
            
            return View(p);
        }

        public IActionResult Lista() {
            var gimnasios = _context.Gimnasios.OrderBy(x => x.Nombre).ToList();
            return View(gimnasios);
        }
    }
}