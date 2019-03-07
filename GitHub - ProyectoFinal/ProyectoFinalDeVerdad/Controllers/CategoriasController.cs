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
    namespace ProyectoFinalDeVerdad.Controllers
    {
        [Route("api/[controller]")]
        [ApiController]
        public class CategoriasController : Controller
        {
            private Context _context;
            private IConfiguration _config;
            private IMapper _mapper;
            private IUnitOfWork _iunitOfWork;

            public CategoriasController(Context context, IConfiguration config, IMapper mapper, IUnitOfWork iunitOfWork)
            {
                _context = context;
                _config = config;
                _mapper = mapper;
                _iunitOfWork = iunitOfWork;
            }

            // GET api/usuarios
            [HttpGet]
            [Route("/api/categorias")]
            public async Task<IActionResult> GetCategorias()
            {
                IList<CategoriaResource> categorias = _mapper.Map<IList<CategoriaResource>>(await _iunitOfWork.Categorias.GetAll());

                return Ok(categorias);
                //asdasdasdasasdasdasdsa
            }

            // GET api/usuarios/{id}
            [EnableQuery]
            [HttpGet]
            [Route("/api/categorias/{categoriaId}")]
            public async Task<IActionResult> GetCategoria([FromRoute] int categoriaId)
            {
                CategoriaResource categoria = _mapper.Map<CategoriaResource>(await _iunitOfWork.Categorias.Get(categoriaId));

                return Ok(categoria);
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
}