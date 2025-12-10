using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAntonioRocha
{
    internal class MediaComun
    {
        public String media(double nota01, double note02, double nota03)
        {
            double notaFinal = (nota01 + note02 + nota03) * 3;
            String resulFinal = "";

            if (notaFinal >= 6)
            {   
                resulFinal = "Aprovado";              
            }
            else
            {
                resulFinal = "Reprovado";
            }
            return resulFinal;
        }
    }
}
