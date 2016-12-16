using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    class ErrorPuntualException:ApplicationException
    {
        private DateTime iFechaHora ;

        public ErrorPuntualException():base("Error conexion IP: 192.168.1.1")
        {
            this.iFechaHora = DateTime.Now;
        }

        public DateTime FechaHora
        {
            get { return this.iFechaHora; }
        }
    }
}
