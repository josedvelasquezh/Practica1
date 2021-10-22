using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculosLibrary
{
    public class NumeroMayor
    {
        public static string GetNumero(int NumeroA, int NumeroB)
        {
            if (NumeroA > NumeroB)
            {
                return "El Primero es Mayor";
            }
            else if (NumeroB > NumeroA)
            {
                return "El Segundo es Mayor";
            }
            else
            {
                return "Los numeros son iguales";
            }
        }
    }
}
