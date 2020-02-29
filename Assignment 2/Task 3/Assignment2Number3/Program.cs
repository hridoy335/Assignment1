using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2Number3
{
    class Program
    {
        

        static void Main(string[] args)
        {
            int n,r, binary=0;
            Console.WriteLine("Enter the number :");
            n = Convert.ToInt32(Console.ReadLine());
            int m = n;
            // Binary Calculation 
            int temp = 1;
            while (n != 0)
            {
                r = n % 2;
                n = n / 2;
                binary = binary + r * temp;
                temp = temp * 10;
            }
            
            Console.WriteLine("Binary number is : {0}",binary);

            // Hex Calculation
           

            char[] hexaDeciNum = new char[100];

            // counter for hexadecimal number array 
            int i = 0;
            while (m != 0)
            {
                // temporary variable to  
                // store remainder 
                int temp2 = 0;     

                // storing remainder in temp 
                // variable. 
                temp2 = m % 16;

                // check if temp < 10 
                if (temp2 < 10)
                {
                    hexaDeciNum[i] = (char)(temp2 + 48);
                    i++;
                }
                else
                {
                    hexaDeciNum[i] = (char)(temp2 + 55);
                    i++;
                }

                m = m / 16;
            }

            // printing hexadecimal number  
            // array in reverse order 
            for (int j = i - 1; j >= 0; j--)
            {
                Console.Write("Hex number is :{0}",hexaDeciNum[j]);
            }

            Console.ReadLine();
        }
    }
}
