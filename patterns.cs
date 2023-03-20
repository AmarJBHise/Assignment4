using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    internal class patterns
    {
       public void MultiplicationTable()
        {
            
                Console.WriteLine("Please enter the value for columns");
                int A = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter the value for rows");
                int B = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("please enter row and columns");

                for (int i = 1; i <= B; i = i + 1)
                {

                    for (int j = 2; j <= A; j = j + 1)
                    {
                        Console.Write(i * j + "  |");

                    }
                    Console.WriteLine();
                }

            

        }
        

    }
}
