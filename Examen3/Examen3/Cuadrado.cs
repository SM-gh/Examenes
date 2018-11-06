using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Areas
{
    class Cuadrado : Figura
    {
        public override double CalcularArea()//Sobrecarga del Método "CalcularArea()"
        {
            Console.WriteLine("\nÁREA DEL CUADRADO\n");
            Console.WriteLine("Ingresa el lado:");
            x = Convert.ToDouble(Console.ReadLine());
            return Area = x * x;
        }
    }
}