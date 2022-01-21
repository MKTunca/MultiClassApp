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
            int a = Convert.ToInt32(b);

            if (a == 3 || a == 5)
            {
                Console.Write("Choose a limit = ");
                string M = Console.ReadLine();
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
            Console.ReadLine();
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
