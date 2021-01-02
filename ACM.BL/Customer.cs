using System;
using System.Collections.Generic;

namespace ACM.BL
{
    public class Customer : EntityBase
    {
        public Customer() : this(0)
        {

        }

        public Customer(int customerId)
        {
            CustomerId = customerId;
            AddressList = new List<Address>();
        }

        public int CustomerId { get; private set; }
        public int CustomerType { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get
            {
                string fullName = FirstName;
                if (!string.IsNullOrWhiteSpace(LastName))
                {
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += " ";
                    }
                    fullName += LastName;
                }
                return fullName;
            }
        }
        public string Email { get; set; }
        public List<Address> AddressList { get; set; }
        public static int InstanceCount { get; set; }

        public override string ToString() => FullName;

        //Responsable for validates the costumer data.
        //Return true if all data are valid, false if something fail
        public override bool Validation()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(FirstName)) isValid = false;
            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(Email)) isValid = false;

            return isValid;
        }

    }
}
