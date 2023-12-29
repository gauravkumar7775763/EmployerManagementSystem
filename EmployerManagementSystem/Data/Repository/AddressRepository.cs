using EmployerManagementSystem.Data.IRepository;
using EmployerManagementSystem.Models;

namespace EmployerManagementSystem.Data.Repository
{
    public class AddressRepository : IAddressRepository
    {
        private readonly DataContext _context;

        public AddressRepository(DataContext context)
        {
            _context = context;
        }
        public bool AddAddress(Address address)
        {
            _context.Add(address);
            var result = _context.SaveChanges();
            if (result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DeleteAddress(int addressId)
        {
            var employee = _context.Address.FirstOrDefault(x => x.AddressId == addressId);
            if (employee != null)
            {
                _context.Remove(employee);
                var result = _context.SaveChanges();
                if (result > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public Address GetAddressById(int addressId)
        {
            return _context.Address.FirstOrDefault(x => x.AddressId == addressId);
        }
    }
}
