using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAntonioRocha
{
    internal class FizzBuzz
    {
        public static void Main()
        {
            FizzBuzz fizz = new FizzBuzz();

            for (int i = 1; i <= 100; i++)
            {
                switch (fizz.FizzOuBuzz(i))
                {
                    case Tipo.FizzBuzz:
                        Console.WriteLine($"{i} - FizzBuzz");
                        break;

                    case Tipo.Buzz:
                        Console.WriteLine($"{i} - Buzz");
                        break;
                    case Tipo.Fizz:
                        Console.WriteLine($"{i} - Fizz");
                        break;
                    case Tipo.nume:
                        Console.WriteLine(i);
                        break;
                }
            }
        }

        public enum Tipo
        {
            FizzBuzz,
            Buzz,
            Fizz,
            nume,
        }

        public Tipo FizzOuBuzz(int num)
        {
            if (num % 3 == 0 && num % 5 == 0) return Tipo.FizzBuzz;
            if (num % 3 == 0) return Tipo.Fizz;
            if (num % 5 == 0) return Tipo.Buzz;

            return Tipo.nume;
        }


    }
}
