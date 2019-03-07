using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using ProyectoFinal;
using ProyectoFinal.Resources;
using Microsoft.AspNet.OData;
using ProyectoFinalDeVerdad.Querys;

namespace ProyectoFinalDeVerdad.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JuegosController : Controller
    {
        private Context _context;
        private IConfiguration _config;
        private IMapper _mapper;
        private IUnitOfWork _iunitOfWork;

        public JuegosController(Context context, IConfiguration config, IMapper mapper, IUnitOfWork iunitOfWork)
        {
            _context = context;
            _config = config;
            _mapper = mapper;
            _iunitOfWork = iunitOfWork;
        }

        // GET api/usuarios
        [HttpGet]
        [Route("/api/juegos")]
        public async Task<IActionResult> GetJuegos()
        {
            IList<JuegoResource> juegos = _mapper.Map<IList<JuegoResource>>(await _iunitOfWork.Juegos.GetAll());

            return Ok(juegos);
        }

        // GET api/usuarios/{id}
        [EnableQuery]
        [HttpGet]
        [Route("/api/juegos/{juegoId}")]
        public async Task<IActionResult> GetJuego([FromRoute] int juegoId)
        {
            JuegoResource juego = _mapper.Map<JuegoResource>(await _iunitOfWork.Juegos.Get(juegoId));

            return Ok(juego);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
