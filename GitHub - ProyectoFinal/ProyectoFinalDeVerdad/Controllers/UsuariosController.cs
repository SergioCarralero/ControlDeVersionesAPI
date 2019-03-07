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
    public class UsuariosController : ControllerBase
    {

        private Context _context;
        private IConfiguration _config;
        private IMapper _mapper;
        private IUnitOfWork _iunitOfWork;

        public UsuariosController(Context context, IConfiguration config, IMapper mapper, IUnitOfWork iunitOfWork)
        {
            _context = context;
            _config = config;
            _mapper = mapper;
            _iunitOfWork = iunitOfWork;
        }

        // GET api/usuarios
        [HttpGet]
        [Route("/api/usuarios")]
        public async Task<IActionResult> GetUsuarios()
        {
            //IList<UsuarioResource> usuarios = _mapper.Map<IList<UsuarioResource>>(await _iunitOfWork.Usuarios.GetAll());

            //return Ok(usuarios);

            IList<UsuarioResource> usuarios = _mapper.Map<IList<UsuarioResource>>(await _iunitOfWork.Usuarios.GetAll());

            return Ok(usuarios);
        }

        // GET api/usuarios/{id}
        [EnableQuery]
        [HttpGet]
        [Route("/api/usuarios/{usuarioId}")]
        public async Task<IActionResult> GetUsuario( [FromRoute] int usuarioId)
        {
            UsuarioResource usuario = _mapper.Map<UsuarioResource>(await _iunitOfWork.Usuarios.Get(usuarioId));

            return Ok(usuario);
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
