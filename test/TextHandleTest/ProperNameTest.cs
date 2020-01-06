using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace BitHelp.Core.HandleData.Test.TextHandleTest
{
    public class ProperNameTest
    {
        [Fact]
        public void Using_in_names_with_all_letters_in_upercase()
        {
            string name = "RENATO BEVILACQUA PACHECO";
            Assert.Equal("Renato Bevilacqua Pacheco", TextHandle.ProperName(name));            
        }

        [Fact]
        public void Using_in_names_with_all_letters_in_lowercase()
        {
            string name = "renato bevilacqua pacheco";
            Assert.Equal("Renato Bevilacqua Pacheco", TextHandle.ProperName(name));
        }

        [Fact]
        public void Using_in_names_with_special_characters_and_all_letters_in_lowercase()
        {
            string name = "andré magalhães gonçalves";
            Assert.Equal("André Magalhães Gonçalves", TextHandle.ProperName(name));
        }
    }
}
