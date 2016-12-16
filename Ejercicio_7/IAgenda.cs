using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_7
{
    interface IAgenda
    {
        void AgregarCalendario(Calendario pCalendario);
        void ModificarCalendario(Calendario pCalendario);
        void EliminarCalendario(string pCodigoCalendario);
        IList<Calendario> ObtenerTodosCalendarios();
        Calendario ObtenerCalendarioPorCodigo(DateTime pCalendario);
        IList<Calendario> ObtenerCalendariosOrdenadoPor(IComparer<Calendario> pComparador);
        IList<Evento> ObtenerEventosDeUnCalendario(Calendario pCalendario,IComparer<Evento> pComparador);
    }
}
