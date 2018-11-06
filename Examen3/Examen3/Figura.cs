using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Areas
{
    public class Figura
    {
        protected double x;
        protected double y;
        protected double area;

        public double X { get => x; set => x = value; }
        public double Y { get => y; set => y = value; }
        public double Area { get => area; set => area = value; }

        public virtual double CalcularArea()
        {
           return Area;
        }
        public static double operator + (Figura F1, Figura F2)//Sobrecarga del operador "+" entre dos tipos "Figura" de las cuales obtiene el área, y que regresan un double (el área resultante de su suma)
        {
            return F1.CalcularArea() + F2.CalcularArea();
        }
    }
}