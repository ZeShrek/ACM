using System;
using Xunit;
using ACM.BL;

namespace ACM.BLTest
{
    public class CustomerTests
    {

        [Fact]
        public void FirstNameTest()
        {
            //Arrange
            var client = new Customer();
            client.FirstName = "Jonh";

            //Act
            string result = "Jonh";

            //Assert
            Assert.Equal(result, client.FirstName);

        }

        [Fact]
        public void LastNameTest()
        {
            //Arrange
            var client = new Customer();
            client.LastName = "Bail";

            //Act
            string result = "Bail";

            //Assert
            Assert.Equal(result, client.LastName);

        }

        [Fact]
        public void FullNameTest()
        {
            //Arrange
            var client = new Customer();
            client.FirstName = "Jonh";
            client.LastName = "Bail";

            //Act
            string result = "Jonh Bail";

            //Assert
            Assert.Equal(result, client.FullName);

        }

        [Fact]
        public void FullNameLastNameEmpty()
        {
            //Arrange
            var client = new Customer();
            client.FirstName = "Jonh";

            //Act
            string result = "Jonh";

            //Assert
            Assert.Equal(result, client.FullName);

        }

        [Fact]
        public void FullNameFirstNameEmpty()
        {
            //Arrange
            var client = new Customer();
            client.LastName = "Bail";

            //Act
            string result = "Bail";

            //Assert
            Assert.Equal(result, client.FullName);

        }

        [Fact]
        public void StaticTest()
        {
            //Arrange
            var clientOne = new Customer();
            clientOne.FirstName = "Jonh";
            Customer.InstanceCount += 1;

            var clientTwo = new Customer();
            clientTwo.FirstName = "Jack";
            Customer.InstanceCount += 1;

            var clientThree = new Customer();
            clientThree.FirstName = "Jenie";
            Customer.InstanceCount += 1;

            //Act

            //Assert
            Assert.Equal(3, Customer.InstanceCount);
        }
    }
}
