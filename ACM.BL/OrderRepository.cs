using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class OrderRepository
    {
        //Responsable for retrive a Product.
        //Return the specific Product
        public Order Retrive(int orderId)
        {
            var order = new Order(orderId);

            if (orderId == 10)
            {
                order.OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00, 00, new TimeSpan(7, 0, 0));
            }
            return order;
        }

        //Responsable for retrive a list of Products.
        //Return a list of Products
        public List<Order> Retrive()
        {

            return new List<Order>();
        }

        //Responsable for save the current Product.
        //Return true if everything, false if something fail
        public bool Save(Order order)
        {
            var success = true;

            if (order.HasChanges)
            {
                if (order.IsValid)
                {
                    if (order.IsNew)
                    {
                        //call a insert procedore
                    }
                    else
                    {
                        //cal update
                    }
                }
                else
                {
                    success = false;
                }
            }
            else
            {
                success = false;
            }

            return success;
        }
    }
}
