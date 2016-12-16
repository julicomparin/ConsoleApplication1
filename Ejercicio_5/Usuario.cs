using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5
{
    public class Usuario:IComparable<Usuario>
    {
        private string iCodigo; 
        private string iNombreCompleto;
        private string iCorreoElectronico;

        public Usuario(string pCodigo,string pNombre,string pCorreo)
        {
            this.iCodigo = pCodigo;
            this.iNombreCompleto = pNombre;
            this.iCorreoElectronico = pCorreo;
        }

        public int CompareTo(Usuario pUsuario)
        {
            return this.iCodigo.CompareTo(pUsuario.Codigo);
        }

        public string Codigo
        {
            get { return this.iCodigo; }
        }

        public string Nombre
        {
            get { return this.iNombreCompleto; }
        }

        public string CorreoElectronico
        {
            get { return this.iCorreoElectronico; }
        }

    }
}
