using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    class CapaVista
    {
        public void Ejecutar()
        {
            try
            {
                CapaControlador mCControlador = new CapaControlador();
                mCControlador.Ejecutar();
            }

            catch (CapaAplicationException mAE)
            {
                Console.WriteLine("Mensaje de ClaseAplicacion: "+ mAE.Message);
                Console.WriteLine("Mensaje de ClaseErrorPuntual" + mAE.InnerException.Message);
                Console.WriteLine("CALLSTACK");
                Console.WriteLine(mAE.StackTrace);
                Console.WriteLine(mAE.InnerException);
 
            }

        }

    }
}
