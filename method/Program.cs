using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method
{
    class Math 
    {
         public int add(int a, int b)
        {
            int sum = a + b;
            return sum;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Math math = new Math();
            int s = math.add(10,20);
            Console.WriteLine(s);
            
           
        }
    }
}
