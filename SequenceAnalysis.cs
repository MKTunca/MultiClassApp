using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class SequenceAnalysis
    {
        public void Sequenceanalysis()
        {
            Runner2 run = new Runner2();
            string word;
            int i;
            Console.Write("Enter a word = ");
            word = Console.ReadLine();
            Regex regex = new Regex("[^A-Z]");
            string output = regex.Replace(word, "");
            int length = output.Length;
            char[] array = new char[length];
            for (i = 0; i < length; i++)
            {
                array[i] = output[i];
            }
            Array.Sort(array);
            Console.WriteLine("---------------------------------");
            Console.Write("ALPHABETIC VERSİON :");
            for (i = 0; i < length; i++)
            {
                Console.Write(array[i]);
            }
            Console.WriteLine("");
            while (true)
            {
                string answer;
                Console.Write("Do you want to return back to home...? Y/N");
                answer = Console.ReadLine();
                if (answer== "Y")
                {
                    run.Run();
                }
               else if(answer=="N")
                {
                    Sequenceanalysis();
                }
                else
                {
                    break;
                }
            }
            Console.ReadLine();
        
        }
    }
}
