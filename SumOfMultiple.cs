using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class SumOfMultiple
    {
        public void SumofMultiple()
        {
            Runner2 run = new Runner2();
            Console.Write("Choose a number = ");
            string b = Console.ReadLine();
            if (b == "3" || b == "5")
            {
                int a = Convert.ToInt32(b);
                int number;
                Console.Write("Choose a limit = ");
                string M = Console.ReadLine();
                while (!int.TryParse(M, out number))
                {
                    Console.Write("This is not valid input. Please enter an integer value: ");
                    SumofMultiple();
                }
                int N = Convert.ToInt32(M);
                Console.WriteLine("Sum of multiples of " + a +
                 " up to " + N + " = " + Calculate_sum(a, N));
            }
            else
            {
                Console.WriteLine("Please enter 3 or 5 !");
            }
            while (true)
            {
                string answer;
                Consol();
                answer = Console.ReadLine();
                if (answer == "Y")
                {
                    run.Run();
                }
                else if (answer == "N")
                {
                    SumofMultiple();
                }
                else
                {
                    Consol();
                }
            }
        }
        static int Calculate_sum(int a, int N)
        {

            // Number of multiples
            int m = N / a;

            // sum of first m natural numbers
            int sum = m * (m + 1) / 2;

            // sum of multiples
            int ans = a * sum;

            return ans;
        }
        public void Consol()
        {
            Console.Write("Do you want to return back to home...? Y/N");
        }
    }
}
