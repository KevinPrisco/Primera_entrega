using Investigadores.API.Data;
using Investigadores.Shared.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Investigadores.API.Controllers
{

    [ApiController]
    [Route("api/cientificos")]
    public class CientificosController:ControllerBase
    {

        private readonly DataContext _context;


        public CientificosController(DataContext context)
        {
            _context = context;
        }

        //GET CON LISTA
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            //200 TODO OK
            //204
            //400
            //401
            //500 ERROR DE CODIGO
            //AWAIT=ESPERAR
            //DEBE RESPONDER AL CONTEXT DE CIENTIFICOS
            //CUANDO EL METODO ES GET CON PARAMETROS SOLO MUESTRA ALGUNOS DATOS
            //CUANDO EL METODO ES GET SIN PARAMETROS MUESTRA TODOS LOS DATOS (SELECT * FROM CIENTIFICOS)
            return Ok(await _context.Cientificos.ToListAsync());


        }

        // METODO GET CON PARAMETROS
        [HttpGet("{id:int}")]
        public async Task<ActionResult> Get(int id)
        {
            //200 TODO OK
            //204
            //400
            //401
            //500 ERROR DE CODIGO
            //AWAIT=ESPERAR
            //DEBE RESPONDER AL CONTEXT DE CIENTIFICOS
            //CUANDO EL METODO ES GET CON PARAMETROS SOLO MUESTRA ALGUNOS DATOS
            //CUANDO EL METODO ES GET SIN PARAMETROS MUESTRA TODOS LOS DATOS (SELECT * FROM CIENTIFICOS)
            await _context.Cientificos.FirstOrDefaultAsync(x  => x.Id == id);

            return Ok();


        }

        //EL POST PUEDE MODIFICAR LA TABLA
        //INSERTAR UN REGISTRO
        [HttpPost]
        public async Task<ActionResult> Post(Cientifico cientifico)
        {


            _context.Add(cientifico);
            await _context.SaveChangesAsync();  
            return Ok(cientifico);

        }
    }

    /////////////////////////COLABORADORES/////////////////////////////////////
    ///
    [ApiController]
    [Route("api/colaboradores")]
    public class ColaboradoresController : ControllerBase
    {

        private readonly DataContext _context;


        public ColaboradoresController(DataContext context)
        {
            _context = context;
        }

        //GET CON LISTA
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            //200 TODO OK
            //204
            //400
            //401
            //500 ERROR DE CODIGO
            //AWAIT=ESPERAR
            //DEBE RESPONDER AL CONTEXT DE CIENTIFICOS
            //CUANDO EL METODO ES GET CON PARAMETROS SOLO MUESTRA ALGUNOS DATOS
            //CUANDO EL METODO ES GET SIN PARAMETROS MUESTRA TODOS LOS DATOS (SELECT * FROM CIENTIFICOS)
            return Ok(await _context.Colaboradores.ToListAsync());


        }

        // METODO GET CON PARAMETROS
        [HttpGet("{id:int}")]
        public async Task<ActionResult> Get(int id)
        {
            //200 TODO OK
            //204
            //400
            //401
            //500 ERROR DE CODIGO
            //AWAIT=ESPERAR
            //DEBE RESPONDER AL CONTEXT DE CIENTIFICOS
            //CUANDO EL METODO ES GET CON PARAMETROS SOLO MUESTRA ALGUNOS DATOS
            //CUANDO EL METODO ES GET SIN PARAMETROS MUESTRA TODOS LOS DATOS (SELECT * FROM CIENTIFICOS)
            var colaborador = await _context.Colaboradores.FirstOrDefaultAsync(x => x.Id == id);
            if (colaborador == null)
            {

                return NotFound();
            }
            else {

                return Ok(colaborador);

            }
        }

        //EL POST PUEDE MODIFICAR LA TABLA
        //INSERTAR UN REGISTRO
        [HttpPost]
        public async Task<ActionResult> Post(Colaborador colaborador)
        {


            _context.Add(colaborador);
            await _context.SaveChangesAsync();
            return Ok(colaborador);

        }
    }

}
