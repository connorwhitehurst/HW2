using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class FizBuzz
    {
        static void Main(string[] args)
        {


            string input;

            int num;

            bool isValidInput;



            do
            {

                Console.WriteLine("Enter Lucky Number: ");

                input = Console.ReadLine();

                isValidInput = int.TryParse(input, out num);

                if (!isValidInput)

                    Console.WriteLine("Your input is not a valid number");

            } while (!isValidInput);

            string result = "";

            if (num % 15 == 0) result = num + "  FizzBuzz";

            else if (num % 3 == 0) result = num + " Fizz";

            else if (num % 5 == 0) result = num + " Buzz";

            else result = "" + num;

            Console.WriteLine(result);

            Console.WriteLine("Press enter to exit.");

            Console.ReadLine();



        }
    }
}
