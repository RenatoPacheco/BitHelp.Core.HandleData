using Xunit;

namespace BitHelp.Core.HandleData.Test.TextHandleTest
{
    public class BreakTextTest
    {
        [Fact]
        public void No_break_for_not_reach_length()
        {
            string value = "A text anywhere";
            Assert.Equal(value, TextHandle.BreakText(value, 100));
        }

        [Fact]
        public void Break_for_reach_length()
        {
            string value = "A text anywhere";
            Assert.Equal($"{value.Substring(0, 5)}...", TextHandle.BreakText(value, 5));
        }

        [Fact]
        public void No_break_null()
        {
            string value = null;
            Assert.Equal(value, TextHandle.BreakText(value, 100));
        }

        [Fact]
        public void No_break_empty()
        {
            string value = string.Empty;
            Assert.Equal(value, TextHandle.BreakText(value, 100));
        }
    }
}
