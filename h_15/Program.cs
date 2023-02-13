using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace h_15
{
    internal class Program
    {
        static double Szam(int osz)
        {
            Console.WriteLine(osz);
            
            return 0.0;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Add meg hany oldal:");
            double ere=Szam(int.Parse(Console.ReadLine()));
            
            Console.ReadKey();
        }
    }
}
