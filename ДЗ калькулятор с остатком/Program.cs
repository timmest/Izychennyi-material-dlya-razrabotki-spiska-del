using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ДЗ_калькулятор_с_остатком
{
    internal class Program
    {
        static int a1, b1;
        static void Main(string[] args)
        {
            bool result = true;
            string a, b;

            while (result)
            {
                try
                {
                    a = Console.ReadLine();
                    a1 = int.Parse(a);
                    Console.WriteLine("Число распарсено");
                    result = false;
                }

                catch (Exception)
                {
                    Console.WriteLine("Некорректное число");
                }

            }

            result = true;

            while (result)
            {
                try
                {
                    b = Console.ReadLine();
                    b1 = int.Parse(b);
                    Console.WriteLine("Число распарсено");
                    result = false;
                }

                catch (Exception)
                {
                    Console.WriteLine("Некорректное число");
                }
            }

            Console.WriteLine("Остаток при делении введеных чисел " + a1 % b1);

        }
    }
}