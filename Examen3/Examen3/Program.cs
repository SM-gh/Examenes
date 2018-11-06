using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Areas
{
    class Program
    {

        static void Main(string[] args)
        {
            //Instancias u objetos
            Figura square = new Cuadrado();
            Figura circle = new Circulo();
            Figura triangle = new Triangulo();
            char salida = 'N';

            do {
                Menu();
            } while (salida != 'Y');


            void Menu()
            {
                Console.Clear();
                Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ÁREAS~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
                Console.WriteLine("Menú\n\n  Figuras disponibles: Cuadrado(Square), Triángulo(Triangle), Círculo(Circle)\n ");
                Console.WriteLine(" A: Calcular Área(Area)\n S: Calcular y sumar áreas(Sum)\n E: Salir(Exit)\n");
                string eleccion1 = Console.ReadLine();

                if (eleccion1 == "A" || eleccion1 == "a")
                {
                    MenuAreas();
                }
                else if (eleccion1 == "S" || eleccion1 == "s")
                {
                    SumaAreas();
                }
                else if (eleccion1 == "E" || eleccion1 == "e" || salida == 'Y')
                {
                    Console.Clear();
                    Console.WriteLine("¡Adios!");
                    Console.ReadKey();
                    salida = 'Y';
                }
                else
                {
                    Menu();
                }
            }

            void MenuAreas()
            {
                Console.Clear();
                Console.WriteLine("Selecciona la Figura:\n 1)Cuadrado(Square)\n 2)Triangulo(Triangle)\n 3)CirculO(Circle)\n R)Regresar al menú principal\n E:Salir(Exit)\n "); 
                string eleccion2 = Console.ReadLine();
                if (eleccion2 == "E" || eleccion2 == "e")
                {
                    Console.Clear();
                    Console.WriteLine("¡Adios!");
                    Console.ReadKey();
                    salida = 'Y';
                } else if(eleccion2 == "R" || eleccion2 == "r")
                {
                    Menu();
                }
                else
                {
                    Console.Clear();
                    switch (eleccion2)
                    {
                        case "1":
                            Console.WriteLine("Escogiste Cuadrado\n");
                            Console.WriteLine("\nEl área del cuadrado es: " + square.CalcularArea());
                            Console.ReadKey();
                            break;
                        case "2":
                            Console.WriteLine("Escogiste Triangulo\n");
                            Console.WriteLine("\nEl área del triangulo es: " + triangle.CalcularArea());
                            Console.ReadKey();
                            break;
                        case "3":
                            Console.WriteLine("Escogiste Circulo\n");
                            Console.WriteLine("\nEl área del Circulo es: " + circle.CalcularArea());
                            Console.ReadKey();
                            break;
                        default:
                            MenuAreas();
                            break;
                    }
                }
            }
            void SumaAreas()
            {
                Console.Clear();
                Console.WriteLine("¿Qué figuras quieres sumar?:\n *Sólo dos:\n  S: Cuadrado, T:Triángulo, C:Círculo. ");
                Console.WriteLine("\nInstrucciones:\n Separa con un + (y sin espacio) las dos figuras. Ejemplo:C+C\n R)Regrear\n E)Salir\n");
                string eleccion3;
                eleccion3 = Console.ReadLine();
                if (eleccion3 == "E" || eleccion3 == "e")
                {
                    Console.Clear();
                    Console.WriteLine("¡Adios!");
                    Console.ReadKey();
                    salida = 'Y';
                }
                else if (eleccion3 == "R" || eleccion3 == "r")
                {
                    Menu();
                }else if (eleccion3 == "s+s" || eleccion3 == "S+S") //Empieza el uso de la sobrecarga del operador
                {
                    Console.WriteLine("\nEl Area Total es: {0}", square + square);
                    Console.ReadKey();
                }
                else if (eleccion3 == "t+t" || eleccion3 == "T+T")
                {
                    Console.WriteLine("\nEl Area Total es: {0}", triangle + triangle);
                    Console.ReadKey();
                }
                else if (eleccion3 == "c+c" || eleccion3 == "C+C")
                {
                    Console.WriteLine("\nEl Area Total es: {0}", circle + circle);
                    Console.ReadKey();
                }
                else if (eleccion3 == "s+t" || eleccion3 == "S+T" || eleccion3 == "s+T" || eleccion3 == "S+t")
                {
                    Console.WriteLine("\nEl Area Total es: {0}", square + triangle);
                    Console.ReadKey();
                }
                else if (eleccion3 == "s+c" || eleccion3 == "S+C" || eleccion3 == "s+C" || eleccion3 == "S+c")
                {
                    Console.WriteLine("\nEl Area Total es: {0}", square + circle);
                    Console.ReadKey();
                }
                else if (eleccion3 == "t+c" || eleccion3 == "T+C" || eleccion3 == "t+C" || eleccion3 == "T+c")
                {
                    Console.WriteLine("\nEl Area Total es: {0}", triangle + circle);
                    Console.ReadKey();
                }
                else
                {
                    SumaAreas();
                }
            }
        }
    }
}