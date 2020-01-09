using Xunit;

namespace BitHelp.Core.HandleData.Test.NumberHandleTest
{
    public class FactorialTest
    {
        [Fact]
        public void Test_value_0_result_1()
        {
            int value = 0;
            int valueResult = 1;
            Assert.Equal(valueResult, NumberHandle.Factorial(value));
        }

        [Fact]
        public void Test_value_1_result_1()
        {
            int value = 1;
            int valueResult = 1;
            Assert.Equal(valueResult, NumberHandle.Factorial(value));
        }

        [Fact]
        public void Test_value_1_negative_result_1()
        {
            int value = -1;
            int valueResult = 1;
            Assert.Equal(valueResult, NumberHandle.Factorial(value));
        }

        [Fact]
        public void Test_value_6_result_720()
        {
            int value = 6;
            int valueResult = 720;
            Assert.Equal(valueResult, NumberHandle.Factorial(value));
        }
    }
}
