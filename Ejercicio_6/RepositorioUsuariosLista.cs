using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6
{
    class RepositorioUsuariosLista : IRepositoriosUsuarios 
    {
        IList<Usuario> iRepoUsuarios =  new List<Usuario>();
        

        //constructor
        public RepositorioUsuariosLista()
        {
            Usuario Usuario1 = new Usuario("21654", "Mauri", "hotmail");
            Usuario Usuario2 = new Usuario("12384", "Lore", "gmail");
            Usuario Usuario3 = new Usuario("21884", "Juan", "gmail");
            Usuario Usuario4 = new Usuario("95614", "Milton", "yahoo");
            Usuario Usuario5 = new Usuario("00051", "Juli", "");
            this.AgregarUsuario(Usuario1);
            this.AgregarUsuario(Usuario2);
            this.AgregarUsuario(Usuario3);
            this.AgregarUsuario(Usuario4);
            this.AgregarUsuario(Usuario5);
        }

        public void AgregarUsuario(Usuario pUsuario)
        {
            if (this.iRepoUsuarios.Contains(pUsuario))
            {
                throw new NullReferenceException("El Usuario Ya Existe");//si se produce la excepción, corta el flujo de ejecución
            }
            this.iRepoUsuarios.Add(pUsuario);
        }

        public void Actualizar(Usuario pUsuario)
        {
            if (!iRepoUsuarios.Contains(pUsuario)) 
            {
                throw new NullReferenceException("El usuario No Existe");
            }
            this.iRepoUsuarios.Add(pUsuario);
        }

        public void Eliminar(string pCodigo)
        {
            if (ObtenerPorCodigo(pCodigo)==null)
            {
                throw new NullReferenceException("El usuario No Existe");
            }

            this.iRepoUsuarios.Remove(ObtenerPorCodigo(pCodigo));
        }

        public Usuario ObtenerPorCodigo(string pCodigo)
        {
            IEnumerator<Usuario> mEnum = this.iRepoUsuarios.GetEnumerator();

            while (mEnum.MoveNext())
            {
                if (mEnum.Current.Codigo == pCodigo) return mEnum.Current;
            }

            throw new NullReferenceException();          
        }

        public IList<Usuario> ObtenerTodos()
        {
            return this.iRepoUsuarios;
        }

        public IList<Usuario> ObtenerOrdenadoPor(IComparer<Usuario> pComparador)
        {
            List<Usuario> mLista = new List<Usuario>(this.iRepoUsuarios);

            mLista.Sort(pComparador);

            return mLista;
        }

    }
}
