/*
using Investigadores.API.Data;
using Investigadores.Shared.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace Investigadores.API.Controllers
{
    [ApiController]
    [Route("api/Proyectos")]
    public class ProyectosController: ControllerBase
    {
        private readonly DataContext _context;

        public ProyectosController(DataContext context)
        {
            _context = context;
        }


        [HttpGet]
        public async Task<ActionResult> Get() 
        {
            return Ok(await _context.Proyectos.ToListAsync());
        }

        [HttpGet("{Id:int}")]
        public async Task<ActionResult> Get(int Id)
        {
            await _context.Cientificos.FirstOrDefaultAsync(x => x.Id == Id);

            return Ok();
        }

        [HttpPost]
        public async Task<ActionResult> Post(Proyecto proyecto)
        {
            _context.Add(proyecto);
            await _context.SaveChangesAsync();
            return Ok(proyecto);
        }
    }
}
*/