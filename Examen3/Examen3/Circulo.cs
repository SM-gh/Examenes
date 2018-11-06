using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Areas
{
    class Circulo : Figura

    {
        public override double CalcularArea()//Sobrecarga del Método "CalcularArea()"
        {
            Console.WriteLine("\nÁREA DEL CÍRCULO\n");
            Console.WriteLine("Ingresa el radio:");
            x = Convert.ToDouble(Console.ReadLine());
            return Area = 3.1416 * x * x;
        }
    }
}