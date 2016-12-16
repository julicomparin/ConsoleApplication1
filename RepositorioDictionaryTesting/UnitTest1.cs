using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ejercicio_5;

namespace RepositorioDictionaryTesting
{
    [TestClass]
    public class UnitTest1
    {
        

        [TestMethod]
        public void TestOrdenamientoPorCodigo()
        {
            RepositorioUsuariosDictionary Repositorio = new RepositorioUsuariosDictionary();
            RepositorioUsuariosDictionary RepositorioNombre = new RepositorioUsuariosDictionary();
            OrdenamientoUsuarioPorNombre OrdenamientoPorNombre = new OrdenamientoUsuarioPorNombre();

            Usuario Usuario1 = new Usuario("21654", "Mauri", "hotmail");
            Usuario Usuario2 = new Usuario("12384", "Lore", "gmail");
            Usuario Usuario3 = new Usuario("21884", "Juan", "gmail");
            Usuario Usuario4 = new Usuario("95614", "Milton", "yahoo");
            Usuario Usuario5 = new Usuario("00051", "Juli", "");

            //ordenamiento al agregar
            RepositorioNombre.AgregarUsuario(Usuario5);
            RepositorioNombre.AgregarUsuario(Usuario3);
            RepositorioNombre.AgregarUsuario(Usuario2);
            RepositorioNombre.AgregarUsuario(Usuario1);
            RepositorioNombre.AgregarUsuario(Usuario4);


            Repositorio.ObtenerOrdenadoPor(OrdenamientoPorNombre);

            Assert.AreEqual(Repositorio, RepositorioNombre);

        }

        [TestMethod]
        public void TestObtenerTodos()
        {
            RepositorioUsuariosDictionary Repositorio = new RepositorioUsuariosDictionary();
            RepositorioUsuariosDictionary RepositorioTodos= new RepositorioUsuariosDictionary();

            Usuario Usuario1 = new Usuario("21654", "Mauri", "hotmail");
            Usuario Usuario2 = new Usuario("12384", "Lore", "gmail");
            Usuario Usuario3 = new Usuario("21884", "Juan", "gmail");
            Usuario Usuario4 = new Usuario("95614", "Milton", "yahoo");
            Usuario Usuario5 = new Usuario("00051", "Juli", "");

            //ordenamiento al agregar

            RepositorioTodos.AgregarUsuario(Usuario1);
            RepositorioTodos.AgregarUsuario(Usuario2);
            RepositorioTodos.AgregarUsuario(Usuario3);
            RepositorioTodos.AgregarUsuario(Usuario4);
            RepositorioTodos.AgregarUsuario(Usuario5);
        }
    }
}
