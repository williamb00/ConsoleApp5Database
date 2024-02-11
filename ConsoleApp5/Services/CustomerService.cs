using ConsoleApp5.Entities;
using ConsoleApp5.Repositories;
using ConsoleApp5.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Services
{
    internal class CustomerService
    {
        private readonly CustomerRepository _customerRepository;
        private readonly AddressService _adressService;

        public CustomerService(CustomerRepository customerRepository, AddressService addressService)
        {
            _customerRepository = customerRepository;
            _adressService = addressService;
        }

        public CustomerEntity CreateCustomer(string firstName, string lastName, string phoneNumber, string socialSecurityNumber, int addressId)
        {
            
            var customerEntity = new CustomerEntity
            {
                FirstName = firstName,
                LastName = lastName,
                PhoneNumber = phoneNumber,
                SocialSecurityNumber = socialSecurityNumber,
                AddressId = addressId
            };

            
            customerEntity = _customerRepository.Create(customerEntity);

            return customerEntity;
        }

        public CustomerEntity GetCustomerById(int id)
        {
            
            var customerEntity = _customerRepository.GetById(id);
            return customerEntity;
        }

        public IEnumerable<CustomerEntity> GetAllCustomers()
        {
            
            var customers = _customerRepository.GetAll();
            return customers;
        }

        public CustomerEntity UpdateCustomer(CustomerEntity customerEntity)
        {
            
            var updatedCustomerEntity = _customerRepository.Update(customerEntity);
            return updatedCustomerEntity;
        }

        public void DeleteCustomer(int id) =>
            
            _customerRepository.Delete(id);
    }
}