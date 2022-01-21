using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Runner
    {
        static void Main(string[] args)
        {
            Runner2 run = new Runner2();
            run.Run();
        }
        
    }
    class Runner2
    {
        public void Run()
        {
            SequenceAnalysis sequenceAnalysis = new SequenceAnalysis();
            SumOfMultiple sumOfMultiple = new SumOfMultiple();


            Console.Write("Choose a solution = ");
            string runner = Console.ReadLine();
            if (runner == "SequenceAnalysis")
            {
                sequenceAnalysis.Sequenceanalysis();
            }
            else if (runner == "SumOfMultiple")
            {
                sumOfMultiple.SumofMultiple();
            }
            else
            {
                Console.WriteLine("You can only choose SequenceAnalysis or SumOfMultiple");
                Run();
            }
            Console.ReadLine();
        }
    }
}
