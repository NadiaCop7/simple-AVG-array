using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleGradeAVGArray
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {

                Console.WriteLine("Please enter your test and final scores to obtain your class average:");
                int total = 0;
                int testNum = 3;
                int[] testScore = new int[testNum];
                for (int i = 0; i < testNum; i++)
                {
                    testScore[i] = Convert.ToInt32(Console.ReadLine());
                }

                for (int i = 0; i < testNum; i++)
                {
                    total += testScore[i];
                }

                Console.WriteLine("Your class average is: " + total / testNum);
                Console.WriteLine("To enter more scores, press ENTER or if finished, type QUIT");

                if (Console.ReadLine() == "quit")
                {
                    break;
                }
            }
        }
    }
}