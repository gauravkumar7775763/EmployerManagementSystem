using EmployerManagementSystem.Data.IRepository;
using EmployerManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployerManagementSystem.Test.MockData
{
    public class MockAddressRepository : IAddressRepository
    {
        public bool AddAddress(Address address)
        {
            throw new NotImplementedException();
        }

        public bool DeleteAddress(int addressId)
        {
            throw new NotImplementedException();
        }

        public Address GetAddressById(int addressId)
        {
            return new Address { AddressId = 2, AddressLine1 = "456 Oak St", City = "Pune", State = "Maharashtra", ZipCode = 67890 };
        }
    }
}
