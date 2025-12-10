using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAntonioRocha
{
    internal class Equacao
    {
        public String equacaoLinear(int a, int b, int c, int d, int e, int f)
        {
            int xNumerador = (c * e) - (b * f);
            int xDenominador = (a * e) - (b * d);

            int yNumerador = (a * f) - (c *d);
            int yDenominador = (a * e) - (b * d);

            String x = $"Resultado: X = {xNumerador} / {xDenominador} e Y = {yNumerador} / {yDenominador}";

            return x;
        }
    }
}
