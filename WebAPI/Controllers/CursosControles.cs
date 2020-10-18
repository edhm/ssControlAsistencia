using System.Collections.Generic;
using System.Threading.Tasks;
using aplicacion.Cursos;
using Dominio;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class CursosControles : ControllerBase
    {
        private readonly IMediator _mediator;
        public CursosControles(IMediator mediator)
        {
            _mediator = mediator;
        }
        public async Task<ActionResult<List<Curso>>>Get(){
            //return await  _mediator.Send(new Consulta.ListaCursos());
            return (ActionResult<List<Curso>>)await  _mediator.Send(new Consulta.ListaCursos());
        }
    }
}