using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class OrderItem : EntityBase
    {
        public OrderItem()
        {

        }

        public OrderItem(int orderItemId)
        {
            OrderItemId = orderItemId;
        }

        public int OrderItemId { get; private set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal? PurchasePrice { get; set; }

        //Responsable for retrive a Product.
        //Return the specific Product
        public OrderItem Retrive(int orderItemId)
        {

            return new OrderItem();
        }

        //Responsable for retrive a list of Products.
        //Return a list of Products
        public List<OrderItem> Retrive()
        {

            return new List<OrderItem>();
        }

        //Responsable for save the current Product.
        //Return true if everything, false if something fail
        public bool Save()
        {

            return true;
        }

        //Responsable for validates the Product data.
        //Return true if all data are valid, false if something fail
        public override bool Validation()
        {
            var isValid = true;

            if (Quantity <= 0) isValid = false;
            if (ProductId <= 0) isValid = false;
            if (PurchasePrice == null) isValid = false;

            return isValid;
        }
    }
}
