using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraPrima
{
    internal class Program
    {
        static int num = -1;
        static void Main(string[] args)
        {
            //1. Instanciar
            ClasePrimo calculadora = new ClasePrimo();
 
            //2. Pedir numero
            calculadora.PideNumero2();
            //3. Llamar a DimeSiesPrimo
            Boolean esPrimo = calculadora.DimeSiesPrimo();
            //4. Mensaje con resultado
            if (esPrimo) Console.WriteLine(calculadora.getNum() + " SÍ QUE ES PRIMO.");
            else Console.WriteLine(calculadora.getNum() + " VA A SER QUE NO.");

            calculadora.SalDespacio();
        }
        

    }
}