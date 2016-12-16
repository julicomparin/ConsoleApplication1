using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5
{
    public class RepositorioUsuariosDictionary :IRepositoriosUsuarios 
    {
        IDictionary<String, Usuario> iRepoUsuarios = new SortedDictionary<String, Usuario>(); 

        //constructor
        public RepositorioUsuariosDictionary()
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
            if (this.iRepoUsuarios.ContainsKey(pUsuario.Codigo)) //si se produce la excepción, corta el flujo de ejecución
            {
                throw new NullReferenceException("El Usuario Ya Existe");
            }
            this.iRepoUsuarios.Add(pUsuario.Codigo, pUsuario);
        }

        public void Actualizar(Usuario pUsuario)
        {
            if (!iRepoUsuarios.ContainsKey(pUsuario.Codigo))
            {
                throw new NullReferenceException("El usuario No Existe");
            }
            this.iRepoUsuarios.Add(pUsuario.Codigo, pUsuario);
        }

        public void Eliminar(string pCodigo)
        {
            if (!this.iRepoUsuarios.ContainsKey(pCodigo)) 
            {
                throw new NullReferenceException("El usuario No Existe");
            }

            this.iRepoUsuarios.Remove(pCodigo);
        }

        public IList<Usuario> ObtenerTodos()
        {
            List<Usuario> mLista = new List<Usuario>(this.iRepoUsuarios.Values);

            return mLista;
        }

        public Usuario ObtenerPorCodigo(string pCodigo)
        {
            if (!this.iRepoUsuarios.ContainsKey(pCodigo)) 
            {
                throw new NullReferenceException();            
            }

            return this.iRepoUsuarios[pCodigo];
        }

        public IList<Usuario> ObtenerOrdenadoPor(IComparer<Usuario> pComparador)
        {
            List<Usuario> mLista = new List<Usuario>(this.iRepoUsuarios.Values);

            mLista.Sort(pComparador);

            return mLista;
        }
    }
}
