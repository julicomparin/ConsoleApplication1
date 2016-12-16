using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    class CapaAplicacion
    {
        public void Ejecutar()
        {
            try
            {
                CapaDominio mCDomininio = new CapaDominio();
                mCDomininio.Ejecutar();
            }
            catch(ErrorPuntualException E)
            {
                throw new CapaAplicationException(E);
            }
            
        }
    }
}
