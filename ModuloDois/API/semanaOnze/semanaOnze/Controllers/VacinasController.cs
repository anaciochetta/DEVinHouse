using Microsoft.AspNetCore.Mvc;
using semanaOnze.Models;
using semanaOnze.Data;

namespace semanaOnze.Controllers
{
    [ApiController]
    [Route("api/vacinas")] //colocar manualmente a rota
    public class VacinasController : ControllerBase
    {
        //declarar dependência
        private readonly ProjetoDbContext _context;
        //injetar dependência no construtor
        public VacinasController(ProjetoDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<List<Vacina>> Get(
            [FromQuery] string nomeFiltro,
            [FromQuery] int? numeroDosesFiltro
        )
        {
            //SELECT * FROM VACINAS WHERE NUMERODOSES = ?
            var query = _context.Vacinas.AsQueryable();

            if (!string.IsNullOrEmpty(nomeFiltro))
            {
                //filtra por nome da vacina
                query = query.Where(v => v.Nome == nomeFiltro);
            }

            if (numeroDosesFiltro.HasValue && numeroDosesFiltro.Value > 0)
            {
                //filtra pelo numero de doses
                query = query.Where(v => v.NumeroDoses == numeroDosesFiltro);
            }

            //a consulta é feita na aplicação
            return Ok(
            query
            .OrderBy(v => v.Nome)
            .ToList()
        );
        }

        [HttpGet("{id}")]
        public ActionResult<Vacina> GetById([FromRoute] int id)
        {
            //pega pelo id
            return Ok(_context.Vacinas.Find(id));
        }

        [HttpPost]
        public ActionResult<Vacina> Post(
            [FromBody] Vacina body
        )
        {
            _context.Vacinas.Add(body);
            _context.SaveChanges();

            //status 201 created - recurso novo criado
            return Created("api/vacinas", body);
        }

        [HttpPut("{id}")]
        public ActionResult<Vacina> Put(
            [FromBody] Vacina body,
            [FromRoute] int id
        )
        {
            var vacina = _context.Vacinas.Find(id);

            if (vacina == null) return NotFound();

            vacina.Nome = body.Nome;
            vacina.NumeroDoses = body.NumeroDoses;

            _context.SaveChanges();

            return Ok(vacina);
        }

        [HttpDelete("{id}")]
        public ActionResult Delete([FromRoute] int id)
        {
            var vacina = _context.Vacinas.Find(id);

            if (vacina == null) return NotFound();

            _context.Vacinas.Remove(vacina);

            _context.SaveChanges();

            return NoContent();
        }
    }
}