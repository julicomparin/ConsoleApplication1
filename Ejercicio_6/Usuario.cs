using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6
{
    public class Usuario : IComparable<Usuario>, IEquatable<Usuario>
    {
        private string iCodigo;
        private string iNombreCompleto;
        private string iCorreoElectronico;

        public Usuario(string pCodigo, string pNombre, string pCorreo)
        {
            this.iCodigo = pCodigo;
            this.iNombreCompleto = pNombre;
            this.iCorreoElectronico = pCorreo;
        }

        public int CompareTo(Usuario pUsuario)
        {
            return this.iCodigo.CompareTo(pUsuario.iCodigo);
        }

        public bool Equals (Usuario pUsuario)
        {
            return this.GetHashCode() == pUsuario.GetHashCode();
        }

        public override int GetHashCode()
        {
            return this.iCodigo.GetHashCode();
        }

        public string Codigo
        {
            get { return this.iCodigo; }
        }

        public string Nombre
        {
            get { return this.iNombreCompleto; }
        }

        public string Correo
        {
            get { return this.iCorreoElectronico; }
        }
    }
}
