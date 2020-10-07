using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static Random r = new Random();
        static int[] tomb = new int[100];

        static void Main(string[] args)
        {
            feltolt();
            kiir();
            for (int i = 0; i < 100; i++)
            {
                RandomHelyreIr();
            }

            Console.ReadKey();
        }
        static void feltolt()
        {
            

            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = r.Next(10, 100);
            }
        }
        static void kiir()
        {

            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write($"{tomb[i]} ");
                if ((i + 1) % 10 == 0) Console.Write("\n");   
            }
        }
        static void RandomHelyreIr()
        {
            
            Console.SetCursorPosition(
                 r.Next(Console.WindowWidth) , r.Next(Console.WindowHeight)
                );
            Console.Write("*");
        }

    }
}
