using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    public class Matematica
    {
        public double Dividir(int pDividendo, int pDivisor)
        {
            if (pDivisor == 0)
              throw new DivisionPorCeroException("Error: división por cero"); 
            return pDividendo / Convert.ToDouble(pDivisor);
        }
    }
}
