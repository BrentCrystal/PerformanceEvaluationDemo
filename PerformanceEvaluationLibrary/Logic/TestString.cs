using System.Text;

namespace PerformanceEvaluationLibrary.Logic
{
    public class TestString
    {
        /// <summary>
        /// Appends strings using concatenating by augmented assignment operator.
        /// </summary>
        /// <param name="testIteration"></param>
        public void AppendStrings(int testIteration)
        {
            string testString = "";

            for (int counter = 1; counter <= testIteration; counter++)
            {
                testString += "--" + counter;
            }
        }
        /// <summary>
        /// Appends strings using StringBuilder.Append method.
        /// </summary>
        /// <param name="testIteration"></param>
        /// <param name="stringBuilder"></param>
        public void AppendStrings(int testIteration, StringBuilder stringBuilder)
        {
            for (int counter = 1; counter <= testIteration; counter++)
            {
                stringBuilder.Append("--");
                stringBuilder.Append(counter);
            }
        }
    }
}
