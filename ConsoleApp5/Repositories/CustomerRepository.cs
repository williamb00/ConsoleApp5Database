using ConsoleApp5.Contexts;
using ConsoleApp5.Entities;
using ConsoleApp5.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Repositories
{
    internal class CustomerRepository : Repo<CustomerEntity>
    {
        public CustomerRepository(DataContext context) : base(context)
        {
        }

        internal void Delete(int id)
        {
            throw new NotImplementedException();
        }

        internal CustomerEntity GetById(int id)
        {
            throw new NotImplementedException();
        }

        internal CustomerEntity Update(CustomerEntity customerEntity)
        {
            throw new NotImplementedException();
        }
    }
}