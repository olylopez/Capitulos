using System;

namespace Capitulos
{
    class Program
    {
        static void Main(string[] args)
        { 
            int menu = 0;
            do
            {
                Console.WriteLine("1 - Programa 1 ");
                Console.WriteLine("2 - Programa 5 ");
                Console.WriteLine("3 - Salir ");
                Console.Write(" Dijite una opcion: ");

                menu = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (menu)
                {
                    case 1:
                        Console.WriteLine(" Oly López \n  ");
                        break;
                    case 2:
                        Console.WriteLine(" Oly López \n ");
                        Console.WriteLine(" Hoy es por mi mañana por ti \n ");
                        Console.WriteLine(" El mundo no gira entorno tuyo \n ");
                        Console.WriteLine(" Si te caes, levantate más fuerte \n ");
                        Console.WriteLine(" Lo que un día fue no será \n \n ");
                        break;

                    case 3:
                        break;

                    default:
                        Console.WriteLine(" Opcion Invalidad ");
                        break;
                }

            } while (menu != 3);
            Console.ReadLine();
        }
    }
}

