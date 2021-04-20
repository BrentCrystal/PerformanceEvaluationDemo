using PerformanceEvaluationLibrary;
using PerformanceEvaluationLibrary.Logic;
using System;
using System.Text;

/*Test performance difference concatenating strings vs. using StringBuilder.Append the same string in each case. 
  Test at 500, 5,000, and 50,000 iterations.*/

namespace PerformanceEvaluationUI
{
    class Program
    {
        static void Main(string[] args)
        {
            TestString testString = new TestString();
            TimerModel timer = new TimerModel();
            StringBuilder myString = new StringBuilder();
            
            int[] testIteration = { 500, 5000, 50000 };
            
            foreach (int iteration in testIteration )
            {
                string concatTime = timer.GetPerformanceTime(testString.AppendStrings, iteration);
                $"The Concatenated time for iteration {iteration} is: ".PrintToConsole(concatTime);

                string stringBuilderTime = timer.GetPerformanceTime(testString.AppendStrings, iteration, myString);
                $"The StringBuilder time for iteration {iteration} is: ".PrintToConsole(stringBuilderTime);

                Console.WriteLine();
            }

            Console.ReadLine();
        }

    }
}
