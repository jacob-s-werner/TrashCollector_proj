using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TrashCollector_proj.Models;

namespace TrashCollector_proj.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<TempPickUpSuspension> TempPickUpSuspensions { get; set; }
        public DbSet<ChargeToCustomer> ChargesToCustomers { get; set; }
        public DbSet<OneTimePickup> OneTimePickups { get; set; }
        public DbSet<DayOfTheWeek> DaysOfTheWeek { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<IdentityRole>()
            .HasData(
            new IdentityRole
            {
                Name = "Customer",
                NormalizedName = "CUSTOMER"
            }, new IdentityRole
            {
                Name = "Employee",
                NormalizedName = "EMPLOYEE"
            }
            );

            builder.Entity<DayOfTheWeek>()
                .HasData(
            new DayOfTheWeek
            {
                Id = 1,
                Day = "Sunday"
            },
            new DayOfTheWeek
            {
                Id = 2,
                Day = "Monday"
            },
            new DayOfTheWeek
            {
                Id = 3,
                Day = "Tuesday"
            },
            new DayOfTheWeek
            {
                Id = 4,
                Day = "Wednesday"
            },
            new DayOfTheWeek
            {
                Id = 5,
                Day = "Thursday"
            },
            new DayOfTheWeek
            {
                Id = 6,
                Day = "Friday"
            },
            new DayOfTheWeek
            {
                Id = 7,
                Day = "Saturday"
            });
        }
    }
}
