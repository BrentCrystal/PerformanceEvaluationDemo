using System;

namespace PerformanceEvaluationLibrary
{
    public static class ConsoleHelpers
    {
        /// <summary>
        /// Prints string message to console UI.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="time"></param>
        public static void PrintToConsole(this string message, string time)
        {
            Console.WriteLine($"{message} {time }");
        }
    }

}
