using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ComparacionesLinguisticas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Entero negativo (Primera cadena < segunda cadena)
            //Cero (Primera cadena ** segunda cadena)
            //Entero positivo (Primera cadena > segunda cadena)

            string cadena1 = "z";
            string cadena2 = "o";

            int ordenar;

            ordenar = String.Compare(cadena1, cadena2, new CultureInfo("de-DE"),CompareOptions.None);

            switch (ordenar)
            {
                case -1:
                    Console.WriteLine("({0}) es menor que ({1}) segu el criterio de ordenacion", cadena1, cadena2);
                    break;

                case 0:
                    Console.WriteLine("({0}) y ({1}) son iguales segun el criterio de ordenacion", cadena1, cadena2);
                    break;

                case 1:
                    Console.WriteLine("({0}) es mayor que ({1}) segun el criterio de ordenacion", cadena1, cadena2);
                    break;
            }



            //Console.WriteLine(String.Compare(cadena1,cadena2));

        }
    }
}
