using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraPrima
{
    
    internal class ClasePrimo
    {
        private int num = -1;

        public void setNum(int newNum)
        {
            this.num = newNum;
        }
        public int getNum() { 
            return num; 
        }

        public bool DimeSiesPrimo()
        {
            Boolean resultado = false;
            int numdivisores = -1;
            numdivisores = CuantosDivisores();

            if (numdivisores == 0)
            {
                resultado = true;
            }
            return resultado;
        }

        private int CuantosDivisores()
        {
            int resultado = 0;

            for (int i = 2; i < this.num; i++)
            {
                if (this.num % i == 0) resultado += 1;
            }

            return resultado;
        }

        /*public int PideNumero()
        {
            int resultado;
            Console.WriteLine("Dime un numero: ");
            resultado = Convert.ToInt32(Console.ReadLine());
            return resultado;
        }*/
        public void PideNumero2()
        {
            Console.WriteLine("Dime un numero: ");
            num = Convert.ToInt32(Console.ReadLine());
        }
        public void SalDespacio()
        {
            Console.WriteLine("Pulsa Enter para salir.");
            Console.ReadLine();
        }
    }
}
