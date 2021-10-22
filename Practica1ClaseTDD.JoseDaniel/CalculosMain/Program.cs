using System;

namespace CalculosMain
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            int NumeroA = 2;
            int NumeroB = 3;

            //Suma

           int suma = CalculosLibrary.Calculo.Sumar(NumeroA, NumeroB);
            Console.WriteLine($"Suma de {NumeroA} y {NumeroB} es {suma}");

            //Resta
            int resta = CalculosLibrary.Calculo.Restar(NumeroA, NumeroB);
            Console.WriteLine($"Resta de {NumeroA} y {NumeroB} es {resta}");

            //Multiplicacion
            int multiplicacion = CalculosLibrary.Calculo.Multiplicar(NumeroA, NumeroB);
            Console.WriteLine($"Multiplicacion de {NumeroA} y {NumeroB} es {multiplicacion}");

            //Orden
            string mayor =CalculosLibrary.NumeroMayor.GetNumero(NumeroA, NumeroB);
            Console.WriteLine($"Orden de {mayor}");


            
        }
    }
}
