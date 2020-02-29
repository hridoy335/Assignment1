using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2Number2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,er=0;
            Console.WriteLine("Enter array size :");
            n=Convert.ToInt32( Console.ReadLine());
            string[] name = new string[n];

            // insert name
            Console.WriteLine("Insert name :");
            for(int i=0; i<n; i++)
            {
                name[i] = Console.ReadLine();          
            }

            //check duplicate name
            for(int j=0; j < n; j++)
            {
                for(int k=j+1; k < n; k++)
                {
                    if (name[j] == name[k])
                    {
                        er++;
                    } 
                }
            }

            if (er > 0)
            {
                Console.WriteLine("\nHere is duplicate name");
            }
            else
            {
                Console.WriteLine("\nHere is no duplicate name");
            }

            Console.ReadLine();
        }
    }
}
