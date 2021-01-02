using ACM.BL;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ACM.BLTest
{
    public class ProductRepositoryTests
    {
        [Fact]
        public void RetriveTest()
        {
            //Arrange
            var productRepository = new ProductRepository();
            var expected = new Product(2)
            {
            ProductName = "Apple",
            Description = "Green apple's",
            CurrentPrice = 1.99M
        };
            //Act
            var actual = productRepository.Retrive(2);

            //Assert
            Assert.Equal(expected.CurrentPrice, actual.CurrentPrice);
            Assert.Equal(expected.Description, actual.Description);
            Assert.Equal(expected.ProductName, actual.ProductName);

        }

        [Fact]
        public void SaveTestValid()
        {
            //Arrange
            var productRepository = new ProductRepository();
            var updateProduct = new Product(2)
            {
                ProductName = "Apple",
                Description = "Green apple's",
                CurrentPrice = 1.99M,
                HasChanges = true
            };
            //Act
            var actual = productRepository.Save(updateProduct);

            //Assert
            Assert.True(actual);
        }

        [Fact]
        public void SaveTestMissingPrice()
        {
            //Arrange
            var productRepository = new ProductRepository();
            var updateProduct = new Product(2)
            {
                ProductName = "Apple",
                Description = "Green apple's",
                CurrentPrice = null,
                HasChanges = true
            };
            //Act
            var actual = productRepository.Save(updateProduct);

            //Assert
            Assert.False(actual);
        }
    }
}
