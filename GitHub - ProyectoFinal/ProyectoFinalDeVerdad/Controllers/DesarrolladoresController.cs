using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using ProyectoFinal;
using ProyectoFinal.Resources;
using Microsoft.AspNet.OData;

namespace ProyectoFinalDeVerdad.Controllers
{
        [Route("api/[controller]")]
        [ApiController]
        public class DesarrolladoresControler : Controller
        {
            private Context _context;
            private IConfiguration _config;
            private IMapper _mapper;
            private IUnitOfWork _iunitOfWork;

            public DesarrolladoresControler(Context context, IConfiguration config, IMapper mapper, IUnitOfWork iunitOfWork)
            {
                _context = context;
                _config = config;
                _mapper = mapper;
                _iunitOfWork = iunitOfWork;
            }

            // GET api/usuarios
            [HttpGet]
            [Route("/api/desarrolladores")]
            public async Task<IActionResult> GetDesarrolladores()
            {
                IList<DesarrolladorResource> desarrolladores = _mapper.Map<IList<DesarrolladorResource>>(await _iunitOfWork.Desarrolladores.GetAll());

                return Ok(desarrolladores);
            }

            // GET api/usuarios/{id}
            [EnableQuery]
            [HttpGet]
            [Route("/api/desarrolladores/{desarrolladorId}")]
            public async Task<IActionResult> GetDesarrllador([FromRoute] int desarrolladorId)
            {
                DesarrolladorResource desarrollador = _mapper.Map<DesarrolladorResource>(await _iunitOfWork.Desarrolladores.Get(desarrolladorId));

                return Ok(desarrollador);
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

