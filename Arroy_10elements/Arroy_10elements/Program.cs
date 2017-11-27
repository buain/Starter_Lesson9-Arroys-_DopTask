using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arroy_10elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tenarroy = new int[] {0,1,9,7,4,5,5,7,8,9};

            for (int i = tenarroy.Length-1; i >= 0; i--)
            {
                Console.Write(tenarroy[i] + " ");
                
            }
            Console.WriteLine("");
            //delay
            Console.ReadKey();
        }
        
    }
}
