using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // C:\Csharp\Buscado.txt

            FachadaStream iFachada = new FachadaStream();

            Console.WriteLine("Ingrese ruta de archivo:");
            string mRuta = Console.ReadLine();

            try
            {
                Console.WriteLine(iFachada.BuscarArchivo(mRuta));
            }
            catch (ArgumentNullException E)//el path es null
            {
                Console.WriteLine("Error al abrir archivo");
                Console.WriteLine("Detalle: "+E.Message);
            }

            catch (ArgumentException E)//el path es cadena vacia
            {
                Console.WriteLine("Error al abrir archivo");
                Console.WriteLine("Detalle: " + E.Message);
            }

            catch (UnauthorizedAccessException E)//al querer abrir una carpeta y que liste sus elementos
            {
                //ejemplo: C:\Csharp
                Console.WriteLine("Error al abrir archivo");
                Console.WriteLine("Detalle: " + E.Message);

            }

            catch (FileNotFoundException E) //no se pude encontrar el archivo
            {
                Console.WriteLine("Error al abrir archivo");
                Console.WriteLine("Detalle: " + E.Message);
            }

            catch (DirectoryNotFoundException E)//La ruta de acceso especificada no es válida, por ejemplo, está en una unidad no asignada.
            {
                Console.WriteLine("Error al abrir archivo");
                Console.WriteLine("Detalle: " + E.Message);
            }

            Console.WriteLine("----------FIN-----------");       
            Console.ReadKey();
        }
    }
}