using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1FibonacciSequence
{
    class Program
    {
        static int Fib(int n)
        {
            int a = 0, b = 1, c = 0;

            // To return the first Fibonacci number  
            if (n == 0) return a;

            for (int i = 2; i <= n; i++)
            {
                c = a + b;
                a = b;
                b = c;
            }

            return b;
        }

        // Driver function 
        public static void Main(string[] args)
        {

            Console.WriteLine("Insert Number : ");
            int n= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nThe fibonacci sequence number is :");
            Console.Write("{0} ", Fib(n)); //calling fib() mathod
            Console.ReadLine();
        }
    }
}

