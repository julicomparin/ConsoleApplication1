using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        { FachadaMatematica iFachada = new FachadaMatematica();
            byte iOpcionMenu;
            do
            {
                Console.Clear();
                Console.WriteLine("DIVISIONES MATEMATICAS");
                Console.WriteLine("1- Nueva División");
                Console.WriteLine("2- Salir");
                iOpcionMenu = Convert.ToByte(Console.ReadLine());
                if (iOpcionMenu == 1)
                {
                        Console.Clear();
                        Console.WriteLine("DATOS DE LA DIVISION");
                        Console.Write("Dividendo: ");
                        int mDividendo = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Divisor: ");
                        int mDivisor = Convert.ToInt32(Console.ReadLine());
                        iFachada.CrearDivision();
                        try
                        {
                            Console.WriteLine("El valor de la división es: " + iFachada.Division(mDividendo,mDivisor));
                        }
                        catch(DivisionPorCeroException unaExcepcion)
                        {
                            Console.WriteLine("Se ha intentado dividir por cero, el divisor debe ser diferente a cero");
                            Console.WriteLine(unaExcepcion.Message);
                            Console.WriteLine(unaExcepcion.StackTrace);
                        }
                    Console.ReadKey();
                }
            } while (iOpcionMenu != 2);
            
          }
    }
}    