using Xunit;

namespace BitHelp.Core.HandleData.Test.TextHandleTest
{
    public class RemoveAccentsTest
    {
        [Theory]
        [InlineData(null , null)]
        [InlineData("", "")]
        [InlineData("   ", "   ")]
        [InlineData("ÁÀÄÂÃ áàäâã", "AAAAA aaaaa")]
        [InlineData("ÉÈËÊ éèëê", "EEEE eeee")]
        [InlineData("ÍÌÏÎ íìïî", "IIII iiii")]
        [InlineData("ÓÒÖÔÕ óòöôõ", "OOOOO ooooo")]
        [InlineData("ÚÙÜÛ úùüû", "UUUU uuuu")]
        [InlineData("Çç Ññ", "Cc Nn")]
        [InlineData("Aa Ee Ii Oo Uu Cc Nn", "Aa Ee Ii Oo Uu Cc Nn")]
        public void Remove_accents(string value, string result)
        {
            Assert.Equal(result, TextHandle.RemoveAccents(value));
        }
    }
}
