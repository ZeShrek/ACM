using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class Address : EntityBase
    {
        public Address()
        {

        }

        public Address(int addressId)
        {
            AddressId = addressId;
        }

        public int AddressId { get; private set; }
        public int AddressType { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public string State { get; set; }
        public string StreetLine1 { get; set; }
        public string StreetLine2 { get; set; }

        public override bool Validation()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(City)) isValid = false;
            if (string.IsNullOrWhiteSpace(Country)) isValid = false;
            if (string.IsNullOrWhiteSpace(PostalCode)) isValid = false;
            if (string.IsNullOrWhiteSpace(StreetLine1)) isValid = false;

            return isValid;
        }

    }
}
