using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    class FachadaMatematica
    {
        private Matematica mMatematica;

        public Matematica CrearDivision()
        {
            return mMatematica = new Matematica();
        }

        public double Division(int pDividendo, int pDivisor)
        {
            return mMatematica.Dividir(pDividendo, pDivisor);
        }
    }
}
