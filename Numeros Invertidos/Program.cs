using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numeros_Invertidos
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Crearemos 4 variables del tipo entero,donde guardaremos ;
            1.- Numero
            2.-Axuliar(donde guardaremos nuestro numero invertido)
            3.-Decenas donde guardaremos las decenas
            4.- Unidades donde se guardaran las unidades*/
            int numero,auxiliar,decenas,unidades;
            //Pedimos que ingrese el Numero
             Console.WriteLine("INGRESE NÚMERO DE DOS CIFRAS :");
            //Lo guardamos en nuestra variable "numero"
            //Hacemos uso del "Convert.toin32" ya que por defecto nuestro entrada es del tipo string y nosotros necesitamos un entero.
             numero = Convert.ToInt32(Console.ReadLine());
            //Guardamos las decenas
             decenas = numero / 10;
            //Guardamos las unidades
             unidades = numero % 10;
            //Las almacenamos en nuestra variable auxiliar
             auxiliar = (unidades * 10) + decenas;
            //Mostramos nuestro auxiliar
            Console.WriteLine("NÚMERO INVERTIDO ES: " +auxiliar);
            Console .WriteLine("Pulse una Tecla:" );
            Console .ReadKey();
        }
    }
}
