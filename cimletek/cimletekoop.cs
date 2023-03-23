using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cimletek
{
    internal class cimletekoop
    {
        private int cimlet;
        static int[] penz = { 5, 10, 20, 50, 100, 200, 500, 1000, 2000, 5000, 10000, 20000 };
        
        public cimletekoop(){ }

        public cimletekoop(int cimlet)
        {
            this.cimlet = cimlet;
        } 
        public int getcimlet()
        {
            return this.getcimlet();
        }

        public void setcimlet(int cimlet)
        {
            this.cimlet = cimlet;
            int val = 0;
            for (int i = penz.Length-1; i >= 0; i--)
            {
                while (cimlet >= penz[i])
                {
                    cimlet -= penz[i];
                    val++;
                }
            }        Console.WriteLine(val);
        }
    }

}
