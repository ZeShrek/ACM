using ACM.BL;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ACM.BLTest
{
    public class CustomerRepositoryTests
    {
        [Fact]
        public void RetriveValidTest()
        {
            //Arrange
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                Email = "jonh.bail@xxxx.com",
                FirstName = "Jonh",
                LastName = "Bail"
            };

            //Act
            var actual = customerRepository.Retrive(1);

            //Assert
            Assert.Equal(expected.FirstName, actual.FirstName);
            Assert.Equal(expected.LastName, actual.LastName);
            Assert.Equal(expected.Email, actual.Email);
            Assert.Equal(expected.CustomerId, actual.CustomerId);
        }


        [Fact]
        public void RetriveExistingWithAddress()
        {
            //Arrange
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                Email = "jonh.bail@xxxx.com",
                FirstName = "Jonh",
                LastName = "Bail",
                AddressList = new List<Address>()
                {
                    new Address()
                    {
                        AddressType = 1,
                        StreetLine1 = "Rua Dona Inês",
                        City = "Porto",
                        Country = "Portugal",
                        PostalCode = "4000-151"
                    },
                    new Address()
                    {
                        AddressType = 2,
                        StreetLine1 = "Rua Teixeira de Pascoaes",
                        City = "Amarante",
                        Country = "Portugal",
                        PostalCode = "4600-367"
                    }
                }
            };

            //Act
            var actual = customerRepository.Retrive(1);

            //Assert
            Assert.Equal(expected.FirstName, actual.FirstName);
            Assert.Equal(expected.LastName, actual.LastName);
            Assert.Equal(expected.Email, actual.Email);
            Assert.Equal(expected.CustomerId, actual.CustomerId);

            for (int i = 0; i < 1; i++)
            {
                Assert.Equal(expected.AddressList[i].AddressType, actual.AddressList[i].AddressType);
                Assert.Equal(expected.AddressList[i].StreetLine1, actual.AddressList[i].StreetLine1);
                Assert.Equal(expected.AddressList[i].City, actual.AddressList[i].City);
                Assert.Equal(expected.AddressList[i].PostalCode, actual.AddressList[i].PostalCode);
                Assert.Equal(expected.AddressList[i].Country, actual.AddressList[i].Country);
            }
        }

        [Fact]
        public void SaveTestValid()
        {
            //Arrange
            var customerRepository = new CustomerRepository();
            var updateCustomer = new Customer(1)
            {
                Email = "jonh.bail@xxxx.com",
                FirstName = "Jonh",
                LastName = "Bail",
                HasChanges = true
            };
            //Act
            var actual = customerRepository.Save(updateCustomer);

            //Assert
            Assert.True(actual);
        }


        [Fact]
        public void SaveTestMissingLastName()
        {
            //Arrange
            var customerRepository = new CustomerRepository();
            var updateCustomer = new Customer(1)
            {
                Email = "jonh.bail@xxxx.com",
                FirstName = "Jonh",
                HasChanges = true
            };
            //Act
            var actual = customerRepository.Save(updateCustomer);

            //Assert
            Assert.False(actual);
        }
    }
}
