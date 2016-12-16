using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6
{
    public class OrdenamientoUsuarioPorCodigo : IComparer<Usuario>
    {

        public int Compare(Usuario x, Usuario y)
        {
            return x.Nombre.CompareTo(y.Nombre);
        }
    }
}
