using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5
{
    public interface IRepositoriosUsuarios
    {
        void AgregarUsuario(Usuario pUsuario);
        void Actualizar(Usuario pUsuario);
        void Eliminar(string pCodigo);
        IList<Usuario> ObtenerTodos();
        Usuario ObtenerPorCodigo(string pCodigo);
        IList<Usuario> ObtenerOrdenadoPor(IComparer<Usuario> pComparador); 
    }
}
