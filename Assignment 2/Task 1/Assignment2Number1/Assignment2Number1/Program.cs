using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2Number1
{
    class Program
    {
        static void User_input()
        {
            int num;
            string name;
            Console.WriteLine("Insert the name :");
            name = Console.ReadLine();

            Console.WriteLine("Insert the number :");
            num = Convert.ToInt32(Console.ReadLine());

            Out_Put(name, num);
        }

        static void Out_Put(string name, int num) 
        {

            Console.WriteLine("Repete Name");
            for(int j=0; j<num; j++)
            {
                Console.WriteLine(name+"\n");
            }
        }
        static void Main(string[] args)
        {
            User_input();
            Console.ReadLine();
        }
    }
}
