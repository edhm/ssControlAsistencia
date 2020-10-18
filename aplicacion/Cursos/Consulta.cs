using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Dominio;
using Microsoft.EntityFrameworkCore;
using Persistencia;
using MediatR;

namespace aplicacion.Cursos
{
    public class Consulta
    {
        public class ListaCursos : IRequest<List<Curso>> { }
        public class Manejador : IRequestHandler<ListaCursos, List<Curso>>
        {
            private readonly CursosOnlinecontext _context;
            public Manejador(CursosOnlinecontext context)
            {
                _context = context;
            }
            public async Task<List<Curso>> Handle(ListaCursos request, CancellationToken cancellationToken)
            {
                //throw new System.NotImplementedException();
                var cursos = await _context.Curso.ToListAsync();
                return cursos;
            }


        }

    }

    public interface IRequest<T>
    {
    }

    public interface IRequestHandler<T1, T2>
    {
    }
}