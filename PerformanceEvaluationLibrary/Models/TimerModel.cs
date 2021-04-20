using System;
using System.Diagnostics;
using System.Text;

namespace PerformanceEvaluationLibrary
{
    public class TimerModel
    {
        public static Stopwatch timer { get; set; } = Stopwatch.StartNew();

        /// <summary>
        /// Returns the elapsed performance time of the Action method.
        /// </summary>
        /// <param name="appendStrings"></param>
        /// <param name="iteration"></param>
        /// <returns>string</returns>
        public string GetPerformanceTime(Action<int> appendStrings, int iteration)
        {
            timer.Start();

            appendStrings(iteration);

            timer.Stop();

            string output = timer.Elapsed.ToString();

            return output;
        }
        /// <summary>
        /// Returns the elapsed performance time of the Action method.
        /// </summary>
        /// <param name="appendStrings"></param>
        /// <param name="iteration"></param>
        /// <param name="builder"></param>
        /// <returns>string</returns>
        public string GetPerformanceTime(Action<int, StringBuilder> appendStrings, int iteration, StringBuilder builder)
        {
            timer.Start();

            appendStrings(iteration, builder);

            timer.Stop();

            string output = timer.Elapsed.ToString();

            return output;
        }
    }
}
