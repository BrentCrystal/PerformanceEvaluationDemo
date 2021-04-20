using PerformanceEvaluationLibrary.Logic;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

//Arrange, Act, Assert
//expected and actual
//Red, Green, Refactor

namespace PerformanceEvaluationLibrary.Tests
{
    public class TimerModelTests
    {

        [Theory]
        [InlineData("]
        public void GetPerformanceTimeShouldReturnExpectedValue(Action<int> appendStrings,
                                                                 int iteration, 
                                                                 string expected)
        {
            //Arrange
            TimerModel timerModel = new TimerModel(); 
            TestString testString = new TestString();
            
            //Act
            string actual = timerModel.GetPerformanceTime(testString.AppendStrings, iteration);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
