using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What is your Accounting grade?");
            double accgrade = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is your Economics grade?");
            double econgrade = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is your MIS grade?");
            double misgrade = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is your Marketing grade?");
            double markgrade = Convert.ToDouble(Console.ReadLine());


            double A = 90;
            double B = 80;
            double C = 70;
            double D = 60;

            Console.WriteLine("You have earned the following letter grades:");

            if (accgrade >= A && accgrade <= 100)
            {
                Console.WriteLine("Accounting: A");
            }

            else if (accgrade >= B && accgrade < A)
            {
                Console.WriteLine("Accounting: B");
            }

            else if (accgrade >= C && accgrade < B)
            {
                Console.WriteLine("Accounting: C");
            }

            else if (accgrade >= D && accgrade < C)
            {
                Console.WriteLine("Accounting: D");
            }

            else if (accgrade < D)
            {
                Console.WriteLine("Accounting: F");
            }




            if (econgrade >= A && econgrade <= 100)
            {
                Console.WriteLine("Economics: A");
            }

            else if (econgrade >= B && econgrade < A)
            {
                Console.WriteLine("Economics: B");
            }

            else if (econgrade >= C && econgrade < B)
            {
                Console.WriteLine("Economics: C");
            }

            else if (econgrade >= D && econgrade < C)
            {
                Console.WriteLine("Economics: D");
            }

            else if (econgrade < D)
            {
                Console.WriteLine("Economics: F");
            }

           


            if (misgrade >= A && misgrade <= 100)
            {
                Console.WriteLine("MIS: A");
            }

            else if (misgrade >= B && misgrade < A)
            {
                Console.WriteLine("MIS: B");
            }

            else if (misgrade >= C && misgrade < B)
            {
                Console.WriteLine("MIS: C");
            }

            else if (misgrade >= D && misgrade < C)
            {
                Console.WriteLine("MIS: D");
            }

            else if (misgrade < D)
            {
                Console.WriteLine("MIS: F");
            }


            if (markgrade >= A && markgrade <= 100)
            {
                Console.WriteLine("Marketing: A");
            }

            else if (markgrade >= B && markgrade < A)
            {
                Console.WriteLine("Marketing: B");
            }

            else if (markgrade >= C && markgrade < B)
            {
                Console.WriteLine("Marketing: C");
            }

            else if (markgrade >= D && markgrade < C)
            {
                Console.WriteLine("Marketing: D");
            }

            else if (markgrade < D)
            {
                Console.WriteLine("Marketing: F");
            }


            Console.WriteLine("Press enter to exit.");
            Console.ReadKey();



        }
    }
}
