
using System.Threading;
using System.Threading.Tasks;
using Dominio;
using Persistencia;
using MediatR;

namespace aplicacion.Cursos
{
    public class ConsultaId
    {
        public class CursoUnico : IRequest<Curso>
        {
            public int Id { get; set; }
        }

        public class Manejador : IRequestHandler<CursoUnico, Curso>
        {
            private readonly CursosOnlinecontext _context;
            public Manejador(CursosOnlinecontext context)
            {
                _context= context;
             }
            public async Task<Curso> Handle(CursoUnico request, CancellationToken cancellationToken)
            {
                var curso= await _context.Curso.FindAsync(request.Id);
                return curso;
            }
        }
    }
}