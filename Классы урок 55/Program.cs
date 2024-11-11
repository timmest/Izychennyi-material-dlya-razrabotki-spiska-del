using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Классы_урок_55
{
    class Point
    {
        public int X;
        public int Y;
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            Point p = new Point();

            p.X = 4;
            p.Y = 2;

            Point p2 = new Point();
            p2.X = 2;
            p2.Y = 6;

            Console.WriteLine($"X: {p.X} Y: {p.Y}");
        }
    }
}
