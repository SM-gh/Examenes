using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Areas
{
    class Triangulo : Figura
    {
        public override double CalcularArea()//Sobrecarga del Método "CalcularArea()"
        {
            Console.WriteLine("\nÁREA DEL TRIÍNGULO\n");
            Console.WriteLine("Ingresa la base:");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingresa la altura:");
            y = Convert.ToDouble(Console.ReadLine());
            return  Area = x * y / 2;
        }
    }
}