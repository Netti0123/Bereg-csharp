using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teszt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool False = true;
            try 
            { 
            Console.WriteLine("Adj egy szamot");
            int a= int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("ez nem szam");
                False= false;

            }

            

            if (False)
                Console.WriteLine("Igaz volt");
            else
            {
                Console.WriteLine("nem volt igaz");
                Console.WriteLine("es meg rossz is");
            }Console.ReadKey();
        }
    }
}
