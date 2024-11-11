using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Рисуем_треугольники_в_консоли
{
    internal class Program
    {
        static void Main(string[] args)
        {   /*
            int a = 1;

            for (int i = 1; i < 5; i++)
            {
                Console.WriteLine();
                                
                for (int g = 0; g < 1; g++)
                {

                    for (int j = 0; j < i; j++)

                    {
                        Console.Write("*");
                    }
                }
                */

            /*
            for (int i = 10; i > 0; i--)
            {

                Console.WriteLine();

                for (int j = 0; j < 1; j++)
                {

                    for (int k = 0; k < i; k++)
                    {
                        Console.Write("*");
                    }
                }
                
            }
            */
            int a = 1;

            for (int i = 10; i > 0; i--)
            {

                Console.WriteLine();

                for (int j = 0; j < 1; j++)
                {

                    for (int k = 0; k < i; k++)
                    {
                        Console.Write(" ");
                    }
                    for (int l = 0; l < a; l++)
                    {
                        Console.Write("*");
                    }

                    a++;

                }

            }
        }
    }
}
