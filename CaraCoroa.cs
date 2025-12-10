using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAntonioRocha
{
    internal class CaraCoroa
    {
        public void CaraOuCoroa() {

            int num = new Random().Next(1,100);

            string resultado = num <= 50 ? "cara" : "coroa";

            Console.WriteLine($"Numero: {num} - Resultado: {resultado}");
        }
    }
}
