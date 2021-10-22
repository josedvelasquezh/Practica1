using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculosLibraryTest
{
    public class NumeroMayorTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void NumeroMayor_Numeros32_PrimeroMayor()
        {
            //Arrange
            int a = 3;
            int b = 2;

            //Atc
            string resultado = CalculosLibrary.NumeroMayor.GetNumero(a, b);

            //Assert
            Assert.AreEqual("El Primero es Mayor", resultado);
        }

        [Test]
        public void NumeroMayor_Numeros23_SegundoMayor()
        {
            //Arrange
            int a = 2;
            int b = 3;

            //Atc
            string resultado = CalculosLibrary.NumeroMayor.GetNumero(a, b);

            //Assert
            Assert.AreEqual("El Segundo es Mayor", resultado);
        }

        [Test]
        public void NumeroMayor_Numeros21_Iguales()
        {
            //Arrange
            int a = 2;
            int b = 2;

            //Atc
            string resultado = CalculosLibrary.NumeroMayor.GetNumero(a, b);

            //Assert
            Assert.AreEqual("Los numeros son iguales", resultado);
        }
    }
}
