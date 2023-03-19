using System.Data;

namespace ConsoleApp18
{
    internal class Program
    {
        static void Main(string[] args)
        {


            patterns printTables = new patterns();
            // printTables.MultiplicationTable();
            printTables.Printfectoriyals();


            int numbers, i, counter, num1, num2;

            
            Console.WriteLine("Finding the prime numbers ------------------------------");
          
            Console.WriteLine("Input The First Number: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input The Last Number : ");
            num2 = Convert.ToInt32(Console.ReadLine());
           

            for (numbers = num1; numbers <= num2; numbers++)
            {
                counter = 0;

                for (i = 2; i <= numbers / 2; i++)
                {
                    if (numbers % i == 0)
                    {
                        counter++;
                        
                    }
                }

                if (counter == 0 )
                {
                    Console.WriteLine("Prime number is  " + numbers); 
                }
            }




        }
    }
}