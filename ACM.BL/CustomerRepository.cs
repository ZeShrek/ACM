using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ACM.BL
{
    public class CustomerRepository
    {
        public CustomerRepository()
        {
            addressRepository = new AddressRepository();
        }
        private AddressRepository addressRepository { get; set; }

        public Customer Retrive(int customerId)
        {
            var customer = new Customer(customerId);

            //Just for porpose of trainning
            if (customerId == 1)
            {
                customer.Email = "jonh.bail@xxxx.com";
                customer.FirstName = "Jonh";
                customer.LastName = "Bail";
                customer.AddressList = addressRepository.RetriveByCustomerId(customerId).ToList();
            }

            return customer;
        }

        //Responsable for retrive a list of customers.
        //Return a list of customers
        public List<Customer> Retrive()
        {

            return new List<Customer>();
        }

        //Responsable for save the current costumer.
        //Return true if everything, false if something fail
        public bool Save(Customer customer)
        {
            var success = true;

            if (customer.HasChanges)
            {
                if (customer.IsValid)
                {
                    if (customer.IsNew)
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
