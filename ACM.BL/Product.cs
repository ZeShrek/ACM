using Acme.common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class Product : EntityBase, ILoggable
    {
        public Product()
        {

        }

        public Product(int productId)
        {
            ProductId = productId;
        }

        public int ProductId { get; private set; }
        public string ProductName
        {
            get
            {
                return ProductName.InsertSpaces();
            }
            set
            {
                ProductName = value;
            }
        }
        public string Description { get; set; }
        public decimal? CurrentPrice { get; set; }

        public string Log() =>
    $"{ProductId}: {ProductName} Detail: {Description} Status: {EntityState.ToString()}";

        public override string ToString() => ProductName;

        //Responsable for validates the Product data.
        //Return true if all data are valid, false if something fail
        public override bool Validation()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (string.IsNullOrWhiteSpace(Description)) isValid = false;
            if (CurrentPrice == null) isValid = false;

            return isValid;
        }
    }
}
