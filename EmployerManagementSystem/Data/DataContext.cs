using EmployerManagementSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployerManagementSystem.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options) { }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Address> Address { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {           
            modelBuilder.Entity<Employee>()
            .Property(e => e.EmployeeId)
            .UseIdentityColumn();

            modelBuilder.Entity<Employee>()
           .HasIndex(e => new { e.FirstName, e.LastName, e.EmailAddress })
           .IsUnique();

            modelBuilder.Entity<Employee>()
            .Property(e => e.CreatedAt)
            .HasDefaultValue(DateTime.Now);

            modelBuilder.Entity<Employee>()
           .HasOne(e => e.Address)
           .WithOne()
           .HasForeignKey<Employee>(e => e.AddressId);

            modelBuilder.Entity<Address>().HasData(
           new Address { AddressId = 1, AddressLine1 = "123 Main St", City = "Mumbai", State = "Maharashtra", ZipCode = 12345 },
           new Address { AddressId = 2, AddressLine1 = "456 Oak St", City = "Pune", State = "Maharashtra", ZipCode = 67890 }
            );

            modelBuilder.Entity<Employee>()
            .HasData(
                new Employee
                {
                    EmployeeId = 1,
                    FirstName = "Gaurav",
                    LastName = "Thakur",
                    Age = 30,
                    EmailAddress = "gaurav.thakur@gmail.com",
                    CreatedAt = DateTime.Now,
                    LastModifiedAt = DateTime.Now,
                    CreatedBy = "Seeder",
                    ModifiedBy = "Seeder",
                    AddressId = 1
                },
                new Employee
                {
                    EmployeeId = 2,
                    FirstName = "Amrish",
                    LastName = "Thakur",
                    Age = 25,
                    EmailAddress = "Amrish.Thakur@gmail.com",
                    CreatedAt = DateTime.Now,
                    LastModifiedAt = DateTime.Now,
                    CreatedBy = "Seeder",
                    ModifiedBy = "Seeder",
                    AddressId = 2
                }            
            );



            base.OnModelCreating(modelBuilder);
        }
    }
}
