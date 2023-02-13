using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace h_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, e, f, g, h, vég;
            Console.WriteLine("Add meg az órát: ");
            a= int.Parse(Console.ReadLine());
            Console.WriteLine("Add meg a percet: ");
            b= int.Parse(Console.ReadLine());
            Console.WriteLine("Add meg a masodpercet: ");
            c= int.Parse(Console.ReadLine());
            d = a * 3600 + b * 60 + c;
            Console.WriteLine("Add meg az orat megint: ");
            e= int.Parse(Console.ReadLine());
            Console.WriteLine("Add meg a pecret megint:");
            f= int.Parse(Console.ReadLine());
            Console.WriteLine("Add meg a masodpercet megint: ");
            g= int.Parse(Console.ReadLine());
            h = e * 3600 + f * 60 + g;
            if (d>h)
            {
                vég = d - h;
                Console.WriteLine(vég);
            }
            else 
            {
                vég = h - d;
                Console.WriteLine(vég);
            }
            Console.ReadKey();
        }
    }
}
