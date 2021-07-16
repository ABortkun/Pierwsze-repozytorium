using System;
using System.Globalization;
using System.Threading.Channels;

namespace Kurs_z_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new[] {3.5, 4.3, 8.5, 9.5};
            double result = 0;

            foreach (var number in numbers)
            {
                result += number;
            }

            Console.WriteLine(result);


        }
    }
}
