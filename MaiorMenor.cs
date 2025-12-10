using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAntonioRocha
{
    internal class MaiorMenor
    {



        public void Maior()
        {
            int [] numeros = [22,55,9];

            int max = numeros[0];

            foreach (int numero in numeros)
            {

                if (numero > max){
                    max = numero;
                }
            }
            Console.WriteLine(max);
            //Console.Read();
        }

        public void Menor()
        {
            int [] numeros = [22,55,9];

            int min = numeros[0];

            foreach (int numero in numeros)
            {
                if (numero < min)
                {
                    min = numero;
                }
            }

            Console.WriteLine(min);
            //Console.Read();

        }
    }
}
