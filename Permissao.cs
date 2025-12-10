using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAntonioRocha
{
    internal class Permissao
    {

       /* public static void Main()
        {
            Permissao permissao = new Permissao();

            //A logica que vai pegar a entrada do usuario fazer a regra para aceitar apenas num positivos dentro da regra

            switch (permissao.Resultado(3))
            {
                case Tipo.administrador55:
                    Console.WriteLine("Welcome, Super Admin user.");
                    break;
                case Tipo.administrador20:
                    Console.WriteLine("Welcome, Admin user.");
                    break;
                case Tipo.gerente20:
                    Console.WriteLine("Contact an Admin for access.");
                    break;
                case Tipo.normal:
                    Console.WriteLine("regular user");
                    break;
                default:
                    Console.WriteLine("You do not have sufficient privileges.");
                    break;
            }
        }*/


        public enum Tipo
        {
            administrador55,
            administrador20,
            gerente20,
            normal,
            invalido,
            Erro,
        }

        public Tipo Resultado(int opcao)
        {
            
            if (opcao == 1) return Tipo.administrador55;
            if (opcao == 2) return Tipo.administrador20;
            if (opcao == 3) return Tipo.gerente20;
            if (opcao == 4) return Tipo.normal;
            if (opcao >= 5) return Tipo.invalido;

            return 0;
        }      
    }
}
