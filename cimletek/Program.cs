using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cimletek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            cimletekoop c1 = new cimletekoop();
            Console.WriteLine("Irjon be egy szamot: ");
            int pnz = Convert.ToInt32(Console.ReadLine());
            c1.setcimlet(pnz);
            Console.ReadLine();
        }
    }
}
