using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5
{
    public class OrdenamientoUsuarioPorCodigo : IComparer<Usuario>
    {
        public int Compare(Usuario x, Usuario y)
        {
            return x.Codigo.CompareTo(y.Codigo);
        }
    }
}
