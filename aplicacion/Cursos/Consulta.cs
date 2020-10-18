using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Dominio;
using MediatR;

namespace aplicacion.Cursos
{
    public class Consulta
    {
        public class ListaCursos : IRequest<List<Curso>> { }
        public class Manejador : IRequestHandler<ListaCursos, List<Curso>>
        {
            private readonly Curso

        }

    }

}