using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class AddressRepository
    {
        public Address Retrive(int addressId)
        {
            var address = new Address(addressId);
            if (addressId == 1)
            {
                address.AddressType = 1;
                address.StreetLine1 = "Rua Dona Inês";
                address.City = "Porto";
                address.Country = "Portugal";
                address.PostalCode = "4000-151";
            }

            return address;
        }

        public IEnumerable<Address> RetriveByCustomerId(int CustomerId)
        {
            var addressList = new List<Address>();
            var address = new Address(1)
            {
                AddressType = 1,
                StreetLine1 = "Rua Dona Inês",
                City = "Porto",
                Country = "Portugal",
                PostalCode = "4000-151"
            };
            addressList.Add(address);

            address = new Address(2)
            {
                AddressType = 2,
                StreetLine1 = "Rua Teixeira de Pascoaes",
                City = "Amarante",
                Country = "Portugal",
                PostalCode = "4600-367"
            };
            addressList.Add(address);

            return addressList;
        }

        public bool Save(Address address)
        {
            var success = true;

            if (address.HasChanges)
            {
                if (address.IsValid)
                {
                    if (address.IsNew)
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
