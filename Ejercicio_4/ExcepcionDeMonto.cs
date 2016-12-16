using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    class ExcepcionDeMonto:Exception
    {
        public ExcepcionDeMonto(string pMensaje):base(pMensaje)
        {

        }
    }
}
