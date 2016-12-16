using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ejercicio_2;

namespace UnitTestEjercicio_2
{
    [TestClass]
    public class MatematicaTest
    {
        [TestMethod]
        public void DividirTest()
        {
            int mDividendo = 40;
            int mDivisor = 10;
            double mResultadoEsperado = 4;
            double mResultado;
            Matematica unaMatematica = new Matematica();
            mResultado = unaMatematica.Dividir(mDividendo, mDivisor);
            Assert.AreEqual(mResultadoEsperado, mResultado);
        }
        [TestMethod]
        public void DividirTest2()
        {
            int mDividendo = 25;
            int mDivisor = 2;
            double mResultadoEsperado = 12.5;
            double mResultado;
            Matematica unaMatematica = new Matematica();
            mResultado = unaMatematica.Dividir(mDividendo, mDivisor);
            Assert.AreEqual(mResultadoEsperado, mResultado);
        }
        [TestMethod]
        public void DividirTest3()
        {
            int mDividendo = 0;
            int mDivisor = 2;
            double mResultadoEsperado = 0;
            double mResultado;
            Matematica unaMatematica = new Matematica();
            mResultado = unaMatematica.Dividir(mDividendo, mDivisor);
            Assert.AreEqual(mResultadoEsperado, mResultado);
        }
        [TestMethod]
        public void DividirTest4()
        {
            int mDividendo = 10;
            int mDivisor = 0;
            double mResultadoEsperado = 6.5;
            double mResultado;
            Matematica unaMatematica = new Matematica();
            mResultado = unaMatematica.Dividir(mDividendo, mDivisor);
            Assert.AreEqual(mResultadoEsperado, mResultado);
        }

    }

}
