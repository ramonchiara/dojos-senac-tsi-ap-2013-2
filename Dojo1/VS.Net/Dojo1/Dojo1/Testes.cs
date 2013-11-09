using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Dojo1
{
    [TestClass]
    public class Testes
    {
        [TestMethod]
        public void TestContagemAeroportos0()
        {
            char[,] mapa = new char[,] {
            };

            int resultado = Simulacao.ContarAeroportos(mapa);

            Assert.AreEqual(0, resultado);
        }

        [TestMethod]
        public void TestContagemAeroportos1()
        {
            char[,] mapa = new char[,] {
                {' ', ' ', ' '},
                {' ', 'A', ' '},
                {' ', ' ', ' '}
            };

            int resultado = Simulacao.ContarAeroportos(mapa);

            Assert.AreEqual(1, resultado);
        }

        [TestMethod]
        public void TestContagemAeroportos2()
        {
            char[,] mapa = new char[,] {
                {' ', ' ', ' '},
                {' ', 'A', 'A'},
                {' ', ' ', ' '}
            };

            int resultado = Simulacao.ContarAeroportos(mapa);

            Assert.AreEqual(2, resultado);
        }

        [TestMethod]
        public void TestContagemAeroportos3()
        {
            char[,] mapa = new char[,] {
                {' ', ' ', 'A'},
                {' ', 'A', 'A'},
                {' ', ' ', ' '}
            };

            int resultado = Simulacao.ContarAeroportos(mapa);

            Assert.AreEqual(3, resultado);
        }

        [TestMethod]
        public void TestContagemAeroportos4()
        {
            char[,] mapa = new char[,] {
                {'A', 'A', 'A'},
                {'A', 'A', 'A'},
                {'A', 'A', 'A'}
            };

            int resultado = Simulacao.ContarAeroportos(mapa);

            Assert.AreEqual(9, resultado);
        }

        [TestMethod]
        public void TestExpansao0()
        {
            char[,] mapa = new char[,] {
                {' ', ' ', ' '},
                {' ', ' ', ' '},
                {' ', ' ', ' '}
            };

            char[,] esperado = new char[,] {
                {' ', ' ', ' '},
                {' ', ' ', ' '},
                {' ', ' ', ' '}
            };

            char[,] resultado = Simulacao.Expandir(mapa);

            CollectionAssert.AreEqual(esperado, resultado);
        }

        [TestMethod]
        public void TestExpansaoA()
        {
            char[,] mapa = new char[,] {
                {' ', ' ', ' '},
                {' ', 'A', ' '},
                {' ', ' ', ' '}
            };

            char[,] esperado = new char[,] {
                {' ', ' ', ' '},
                {' ', 'A', ' '},
                {' ', ' ', ' '}
            };

            char[,] resultado = Simulacao.Expandir(mapa);

            CollectionAssert.AreEqual(esperado, resultado);
        }

        [TestMethod]
        public void TestExpansao1()
        {
            char[,] mapa = new char[,] {
                {' ', ' ', ' '},
                {' ', '*', ' '},
                {' ', ' ', ' '}
            };

            char[,] esperado = new char[,] {
                {' ', '*', ' '},
                {'*', '*', '*'},
                {' ', '*', ' '}
            };

            char[,] resultado = Simulacao.Expandir(mapa);

            CollectionAssert.AreEqual(esperado, resultado);
        }
    }
}
