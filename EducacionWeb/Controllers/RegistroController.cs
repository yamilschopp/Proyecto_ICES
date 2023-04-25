using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EducacionWeb.Models;

namespace EducacionWeb.Controllers
{
    public class RegistroController : Controller
    {

        private readonly EducacionWebContext _context;
        public RegistroController(EducacionWebContext context)
        {
            _context = context;
        }

        // Crear un registro
        public IActionResult CrearRegistro()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CrearRegistro([Bind("Nombre", "Apellido", "Genero", "FechaNacimiento", "Ciudad")] Registro registro)
        {
            if (ModelState.IsValid)
            {
                _context.Add(registro);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(registro);
        }

        // Lista todos los registros
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return View(await _context.Registro.ToListAsync());
        }



    }
}
