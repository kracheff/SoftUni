using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleArea
{
    class CircleArea
    {
        static void Main(string[] args)
        {
            Console.Write("Write in r: ");
            double radius = double.Parse(Console.ReadLine());

            double perimeter;

            perimeter = (2 * Math.PI) * radius;

            double area;

            area = Math.PI * Math.Pow(radius, 2);

            Console.WriteLine("Radius: {0} \nPerimeter: {1:#.##} \nArea: {2:#.##}",
                radius,
                perimeter,
                area);
        }
    }
}
