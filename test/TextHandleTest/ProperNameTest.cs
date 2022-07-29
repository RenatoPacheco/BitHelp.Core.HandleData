using Xunit;

namespace BitHelp.Core.HandleData.Test.TextHandleTest
{
    public class ProperNameTest
    {
        [Theory]
        [InlineData(null, null)]
        [InlineData("        ", "")]
        [InlineData("RENATO BEVILACQUA PACHECO", "Renato Bevilacqua Pacheco")]
        [InlineData("renato bevilacqua pacheco", "Renato Bevilacqua Pacheco")]
        [InlineData("Jony DE éder", "Jony de Éder")]
        public void Proper_name_test(string input, string expected)
        {
            string result = TextHandle.ProperName(input);
            Assert.Equal(expected, result);
        }
    }
}
