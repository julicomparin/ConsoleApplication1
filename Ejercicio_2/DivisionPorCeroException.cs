using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    class DivisionPorCeroException:Exception
    {
        public DivisionPorCeroException(String pMensaje) : base(pMensaje) { }
    }
}
