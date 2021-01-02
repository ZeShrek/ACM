using ACM.BL;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ACM.BLTest
{
    public class OrderRepositoryTests
    {
        [Fact]
        public void RetriveTest()
        {
            //Arrange
            var orderRepository = new OrderRepository();
            var expected = new Order(10);
            expected.OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00, 00, new TimeSpan(7, 0, 0));

            //Act
            var actual = orderRepository.Retrive(10);

            //Assert
            Assert.Equal(expected.OrderDate, actual.OrderDate);
        }

        [Fact]
        public void SaveTestValid()
        {
            //Arrange
            var orderRepository = new OrderRepository();
            var updateOrder = new Order(10);
            updateOrder.OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00, 00, new TimeSpan(7, 0, 0));
            updateOrder.HasChanges = true;
            //Act
            var actual = orderRepository.Save(updateOrder);
            //Assert
            Assert.True(actual);
        }


        [Fact]
        public void SaveTestMissingLastName()
        {
            //Arrange
            var orderRepository = new OrderRepository();
            var updateOrder = new Order(10);
            updateOrder.HasChanges = true;
            //Act
            var actual = orderRepository.Save(updateOrder);
            //Assert
            Assert.False(actual);
        }
    }
}
