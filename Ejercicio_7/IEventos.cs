using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_7
{
    interface IEventos
    {
        void AgregarEvento(Evento pEvento);
        void ModificarEvento(Evento pEvento);
        void EliminarEvento(string pCodigoEvento);
        IList<Evento> ObtenerTodosEventos();
        Evento ObtenerEventoPorCodigo(string pEvento);
        IList<Evento> ObtenerEventosOrdenadoPor(IComparer<Evento> pComparador);
        IList<Evento> ObtenerEventosSegunCriterio(IComparer<Evento> pComparadorEvento);

    }
}
