using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollatzConjecture
{


    class Program

    {

        static int GetInteger(string prompt)
        {

            //Message for user
            Console.WriteLine(prompt);
            while (true)
            {
                try
                {
                    string userInput = Console.ReadLine();
                    int x = int.Parse(userInput);
                    if (x > 1)
                    {
                        return x;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("A valid number is needed.");
                }

            }
        }



        static void Main(string[] args)
        {


            int max = 0;
            int counter = 0;
            int maxCounter = 0;
            int userNumber= GetInteger("Please enter a number that is greater than 1.");
            int x = userNumber;
            
            while (x > 1)
            {


                if (x % 2 == 0)
                {
                    x = x / 2;
                }
                
                else
                {
                    x = (3 * x) + 1; 
                }
                
                counter++;
                

                if (x > max)
                {
                    max = x;
                    maxCounter = counter;
                }
            }

            Console.WriteLine("======");
            Console.WriteLine("It takes " + counter + " steps to reach 1 from " + userNumber + ".");
            Console.WriteLine("======");
            Console.WriteLine("The value reached its peak of " + max + " at step " + maxCounter);
            Console.ReadLine();


        }
      }
}

