using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class ProductRepository
    {
        //Responsable for retrive a Product.
        //Return the specific Product
        public Product Retrive(int productId)
        {
            var product = new Product(productId);

            if(productId == 2)
            {
                product.ProductName = "Apple";
                product.Description = "Green apple's";
                product.CurrentPrice = 1.99M;
            }

            return product;
        }

        //Responsable for retrive a list of Products.
        //Return a list of Products
        public List<Product> Retrive()
        {

            return new List<Product>();
        }

        //Responsable for save the current Product.
        //Return true if everything, false if something fail
        public bool Save(Product product)
        {
            var success = true;

            if (product.HasChanges)
            {
                if (product.IsValid)
                {
                    if (product.IsNew)
                    {
                        //call a insert procedore
                    } else
                    {
                        //cal update
                    }
                } else
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
