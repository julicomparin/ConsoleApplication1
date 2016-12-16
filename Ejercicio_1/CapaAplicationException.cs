using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    class CapaAplicationException : ApplicationException
    {
        public CapaAplicationException(ErrorPuntualException pE) : base("Error de Servidor" + " Fecha: " + pE.FechaHora.Date +" Hora: "+pE.FechaHora.TimeOfDay,pE)
        {
             
        }
    }
}
