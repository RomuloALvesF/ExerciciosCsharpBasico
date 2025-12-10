using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleAntonioRocha
{
    internal class AcheErro
    {

        public void Erro()
        {
            int[] numbers = { 4, 8, 15, 16, 23, 42 };
            int total = 0;
            bool found = true;

            foreach (int number in numbers)
            {
                total += number;

                if (number == 42)
                {
                    found = true;

                }

            }

            if (found)
            {
                Console.WriteLine("Set contains 42");

            }

            Console.WriteLine($"Total: {total}");
        }
    }
}
