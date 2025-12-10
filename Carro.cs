using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAntonioRocha
{
    class Carro
    {
        public double valor(double preco)
        {
            double distribuidora = (preco / 100) * 28;
            double impostos = (preco / 100) * 45;

            double valorFinal = preco - distribuidora - impostos;
            
            return valorFinal;
        }
    }
}
