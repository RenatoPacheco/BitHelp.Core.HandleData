using Xunit;

namespace BitHelp.Core.HandleData.Test.TextHandleTest
{
   public  class ToUriTest
    {
        [Fact]
        public void Remove_lower_case()
        {
            string value = "1, 2, 3, expreção, história, física, pêssego";
            string newValue = "1-2-3-exprecao-historia-fisica-pessego";

            Assert.Equal(newValue, TextHandle.ToUri(value));
        }

        [Fact]
        public void Remove_upper_case()
        {
            string value = "1, 2, 3, EXPREÇÃO, HISTÓRIA, FÍSICA, PÊSSEGO";
            string newValue = "1-2-3-EXPRECAO-HISTORIA-FISICA-PESSEGO";

            Assert.Equal(newValue, TextHandle.ToUri(value));
        }

        [Fact]
        public void Ignore_null()
        {
            string value = null;
            string newValue = null;

            Assert.Equal(newValue, TextHandle.ToUri(value));
        }

        [Fact]
        public void Clean_if_no_contains_a_z_or_number()
        {
            string value = "    ";
            string newValue = string.Empty;

            Assert.Equal(newValue, TextHandle.ToUri(value));
        }

        [Fact]
        public void Remove_lower_case_add_delemiter()
        {
            string value = "1, 2, 3, expreção, história, física, pêssego";
            string newValue = "1_2_3_exprecao_historia_fisica_pessego";

            Assert.Equal(newValue, TextHandle.ToUri(value, "_"));
        }

        [Fact]
        public void Remove_upper_case_add_delemiter()
        {
            string value = "1, 2, 3, EXPREÇÃO, HISTÓRIA, FÍSICA, PÊSSEGO";
            string newValue = "1_2_3_EXPRECAO_HISTORIA_FISICA_PESSEGO";

            Assert.Equal(newValue, TextHandle.ToUri(value, "_"));
        }

        [Fact]
        public void Ignore_null_add_delemiter()
        {
            string value = null;
            string newValue = null;

            Assert.Equal(newValue, TextHandle.ToUri(value, "_"));
        }

        [Fact]
        public void Clean_if_no_contains_a_z_or_number_add_delemiter()
        {
            string value = "    ";
            string newValue = string.Empty;

            Assert.Equal(newValue, TextHandle.ToUri(value, "_"));
        }
    }
}
