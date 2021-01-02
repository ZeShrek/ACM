using ACM.BL;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ACM.BLTest
{
    public class CustomerValidateTests
    {
        [Fact]
        public void ValidateValid()
        {
            //Arrange
            var client = new Customer();
            client.FirstName = "Jonh";
            client.LastName = "Bail";
            client.Email = "jonh-bail@xxxxx.com";

            var expected = true;

            //Act
            var actual = client.Validation();
            
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ValidateMissingFirstName()
        {
            //Arrange
            var client = new Customer();
            client.LastName = "Bail";
            client.Email = "jonh-bail@xxxxx.com";

            var expected = false;

            //Act
            var actual = client.Validation();

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ValidateMissingLastName()
        {
            //Arrange
            var client = new Customer();
            client.FirstName = "Jonh";
            client.Email = "jonh-bail@xxxxx.com";

            var expected = false;

            //Act
            var actual = client.Validation();

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ValidateMissingEmail()
        {
            //Arrange
            var client = new Customer();
            client.FirstName = "Jonh";
            client.LastName = "Bail";

            var expected = false;

            //Act
            var actual = client.Validation();

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
