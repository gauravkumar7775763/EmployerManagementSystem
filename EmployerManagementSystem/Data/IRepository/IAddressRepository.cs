using EmployerManagementSystem.Models;

namespace EmployerManagementSystem.Data.IRepository
{
    public interface IAddressRepository
    {
        bool AddAddress(Address address);
        bool DeleteAddress(int addressId);
        Address GetAddressById(int addressId);
    }
}
