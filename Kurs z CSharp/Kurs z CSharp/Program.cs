using System;
using System.Threading.Channels;

namespace Kurs_z_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 34.1;
            double a = x + 2.1;
            double b = x - 2.1;
            double c = x * 2.1;
            double d = x / 2.1;
            Console.WriteLine("x = 34.1");
            Console.WriteLine("wynik dodania 2.1 do x: " + a);
            Console.WriteLine("wynik odjęcia 2.1 od x: " + b);
            Console.WriteLine("wynik przemnozenia 2.1 przez x: " + c);
            Console.WriteLine("wynik podzielenia x przez 2.1: " + d);

        }
    }
}
