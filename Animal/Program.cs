using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    internal class Program
    {enum animal { Cat = 2, Dog = 5, Tiger, Wolf};
        static void Main(string[] args)
        {
            animal b = animal.Tiger;
            animal a = animal.Cat;
            if (b != a ) 
            {
                Console.WriteLine("Macska indexe {0}",(int)animal.Cat);
                Console.WriteLine("kutya indexe {0}", (int)animal.Dog);
                Console.WriteLine("farkas indexe {0}",(int)animal.Wolf);
            }
            Console.ReadKey(); 
        } 
    }
}

