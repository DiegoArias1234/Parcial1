using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Parcial1.API.Data;
using Parcial1.Shared.Entities;

namespace Parcial1.API.Controllers
{
    [ApiController]
    [Route("/api/Registro")]
    public class RegistrosController : ControllerBase
    {
        private readonly DataContext _context;

        public RegistrosController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task< IActionResult> GetAsync()
        {
            return Ok(await _context.Registros.ToListAsync());
        }

        [HttpPost]
        public async Task<ActionResult> PostAsync(Registro registro)
        {
            _context.Registros.Add(registro);
            await _context.SaveChangesAsync();
            return Ok(registro);
        }


    }

}
