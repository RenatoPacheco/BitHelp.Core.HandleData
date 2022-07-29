using System;
using Xunit;

namespace BitHelp.Core.HandleData.Test.TextHandleTest
{
   public  class ToUriTest
    {
        [Theory]
        [InlineData(null, null)]
        [InlineData("        ", "")]
        [InlineData("1, 2, 3, expreção, história, física, pêssego", "1-2-3-exprecao-historia-fisica-pessego")]
        [InlineData("1, 2, 3, EXPREÇÃO, HISTÓRIA, FÍSICA, PÊSSEGO", "1-2-3-EXPRECAO-HISTORIA-FISICA-PESSEGO")]
        public void To_uri_test(string input, string expected)
        {
            Assert.Equal(expected, TextHandle.ToUri(input));
        }

        [Theory]
        [InlineData(null, "_", null)]
        [InlineData("        ", "_", "")]
        [InlineData("1, 2, 3, expreção, história, física, pêssego", "_", "1_2_3_exprecao_historia_fisica_pessego")]
        [InlineData("1, 2, 3, EXPREÇÃO, HISTÓRIA, FÍSICA, PÊSSEGO", "_", "1_2_3_EXPRECAO_HISTORIA_FISICA_PESSEGO")]
        public void To_uri__set_delemiter_test(string input, string delemiter, string expected)
        {
            Assert.Equal(expected, TextHandle.ToUri(input, delemiter));
        }

        [Theory]
        [InlineData(null, null)]
        [InlineData("        ", null)]
        [InlineData("1, 2, 3, expreção, história, física, pêssego", null)]
        [InlineData("1, 2, 3, EXPREÇÃO, HISTÓRIA, FÍSICA, PÊSSEGO", null)]
        public void To_uri__set_delemiter_test_exception(string input, string delemiter)
        {
            Assert.Throws<ArgumentNullException>(() => TextHandle.ToUri(input, delemiter));
        }
    }
}
