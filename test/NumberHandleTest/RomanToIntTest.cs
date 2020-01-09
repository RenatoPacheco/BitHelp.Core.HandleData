using System;
using Xunit;

namespace BitHelp.Core.HandleData.Test.NumberHandleTest
{
    public class RomanToIntTest
    {
        [Fact]
        public void Check_MMXX_to_2020()
        {
            string value = "MMXX";
            int valueResult = 2020;
            Assert.Equal(valueResult, NumberHandle.RomanToInt(value));
        }

        [Fact]
        public void Check_MMCCCXCIX_to_2399()
        {
            string value = "MMCCCXCIX";
            int valueResult = 2399;
            Assert.Equal(valueResult, NumberHandle.RomanToInt(value));
        }

        [Fact]
        public void Check_MMMCMXCIX_to_3999()
        {
            string value = "MMMCMXCIX";
            int valueResult = 3999;
            Assert.Equal(valueResult, NumberHandle.RomanToInt(value));
        }

        [Fact]
        public void Check_MMDXLI_to_2541()
        {
            string value = "MMDXLI";
            int valueResult = 2541;
            Assert.Equal(valueResult, NumberHandle.RomanToInt(value));
        }

        [Fact]
        public void Check_N_to_0()
        {
            string value = "N";
            int valueResult = 0;
            Assert.Equal(valueResult, NumberHandle.RomanToInt(value));
        }

        [Fact]
        public void Check_MMMM_exception()
        {
            string value = "MMMM";
            Assert.Throws<ArgumentException>(() => NumberHandle.RomanToInt(value));
        }

        [Fact]
        public void Check_empt_exception()
        {
            string value = string.Empty;
            Assert.Throws<ArgumentException>(() => NumberHandle.RomanToInt(value));
        }

        [Fact]
        public void Check_LOHTII_exception_for_lere_invalid()
        {
            string value = "LOHTII";
            Assert.Throws<ArgumentException>(() => NumberHandle.RomanToInt(value));
        }
    }
}
