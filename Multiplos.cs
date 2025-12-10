using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAntonioRocha;

public class Multiplos
{
    /*public static void Main(String[] args)
    {
                    
        Multiplos multiplos = new Multiplos();
       
            
        for (int i = 1; i <=100; i++)
        {
            switch (multiplos.EhMultiplo(i))
            {
                case Tipos.PixTed:
                    Console.WriteLine("PixTed");
                    break;
                case Tipos.Pix:
                    Console.WriteLine("Pix");
                    break;
                case Tipos.Ted:
                    Console.WriteLine("Ted");
                    break;
                case Tipos.Normal:
                    Console.WriteLine(i);
                    break;
            }          
        }
    }*/

    public enum Tipos
    {
        PixTed,
        Pix,
        Ted,
        Normal
    }

    public Tipos ehMultiplo(int numero){
       
       if (numero % 3 == 0 && numero % 5 == 0) return Tipos.PixTed;  
       if (numero % 5 == 0) return Tipos.Pix;
       if (numero % 3 == 0) return Tipos.Ted;

       return Tipos.Normal; 
    }
}

