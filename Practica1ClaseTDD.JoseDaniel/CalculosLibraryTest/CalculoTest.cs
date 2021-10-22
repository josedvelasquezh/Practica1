using NUnit.Framework;

namespace CalculosLibraryTest
{
    public class CalculoTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Suma_NumerosValidos23_Resultado5()
        {
            //Arrange
            int a = 2;
            int b = 3;

            //Act
            int resultado = CalculosLibrary.Calculo.Sumar(a, b);

            Assert.AreEqual(5, resultado);
        }

        [Test]
        public void Restar_NumerosValidos32_Resultado1()
        {
            //Arrange
            int a = 3;
            int b = 2;

            //Act
            int resultado = CalculosLibrary.Calculo.Restar(a, b);

            //Assert
            Assert.AreEqual(1, resultado);
        }

        [Test]
        public void Multiplicar_NumerosValidos32_Resultado6()
        {
            //Arrange
            int a = 3;
            int b = 2;

            //Act
            int resultado = CalculosLibrary.Calculo.Multiplicar(a, b);

            //Assert
            Assert.AreEqual(6, resultado);
        }
    }
}