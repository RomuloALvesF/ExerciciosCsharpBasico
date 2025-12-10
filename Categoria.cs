using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAntonioRocha
{
    internal class Categoria
    {
        /*
        public static void Main()
        {
            Categoria categoria = new Categoria();

            Console.WriteLine("Digite uma idade: ");
            string? entrada = Console.ReadLine();

            if (!int.TryParse(entrada, out int idade))
            {
                Console.WriteLine("Digite um número");
            }


            //terminar os switch case
            switch (categoria.idade(idade))
            {
                case Categoria.Faixas.InfantilA:
                    Console.WriteLine("infantil A = 5 - 7 anos");
                    break;
                case Categoria.Faixas.InfantilB:
                    Console.WriteLine("infantil B = 8 - 10 anos");
                    break;
                case Categoria.Faixas.JuvenilA:
                    Console.WriteLine("juvenil A = 11-13 anos \r\n");
                    break;
                case Categoria.Faixas.JuvenilB:
                    Console.WriteLine("juvenil B = 14-17 anos \r\n");
                    break;
                default:
                    Console.WriteLine("adulto = maiores de 18 anos \r\n");
                    break;
            }

            Console.ReadLine();

        }
        */

        public enum Faixas
        {    
            InfantilA,
            InfantilB,
            JuvenilA,
            JuvenilB,
            Adulto

        }
        public Faixas idade(int age)
        {
            if (age <= 0)
            {
                Console.WriteLine("Selecione uma idade valida");

            }

            if(age >= 5 && age <= 7)  return Faixas.InfantilA;
            if(age >= 8 && age <= 10) return Faixas.InfantilB; 
            if(age >= 11 && age <= 13) return Faixas.JuvenilA;
            if (age >= 14 && age <= 17) return Faixas.JuvenilB;


            return Faixas.Adulto;
        }
    }
}
