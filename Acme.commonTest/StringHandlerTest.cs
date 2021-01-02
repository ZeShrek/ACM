using Acme.common;
using System;
using Xunit;

namespace Acme.commonTest
{
    public class StringHandlerTest
    {
        [Fact]
        public void InsertSpacesTestValid()
        {
            //Arrange
            var source = "SonicScrewdriver";
            var expected = "Sonic Screwdriver";

            //Act
            var actual = source.InsertSpaces();

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void InsertSpacesTestWithExistingSpaces()
        {
            //Arrange
            var source = "Sonic Screwdriver";
            var expected = "Sonic Screwdriver";

            //Act
            var actual = source.InsertSpaces();

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
