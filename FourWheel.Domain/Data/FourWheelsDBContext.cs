using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using FourWheel.Domain.Models;
using System.Reflection;
using Microsoft.Extensions.Options;
using System.Reflection.Emit;

namespace FourWheel.Domain.Data
{
    public class FourWheelsDBContext : DbContext
    {

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Case> Services { get; set; }
        public IConfiguration Configuration { get; private set; }

        public FourWheelsDBContext(DbContextOptions<FourWheelsDBContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {


        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Customer>().HasData(
                new Customer
                {
                    CustomerId = 1,
                    CustomerFirstName = "John",
                    CustomerLastName = "Doe",
                    CustomerFullName = "John Doe",
                    Address = "123 Main St",
                    City = "Springfield",
                    ZipCode = 12345,
                    PhoneNumber = "555-1234",
                },
                new Customer
                {
                    CustomerId = 2,
                    CustomerFirstName = "Jane",
                    CustomerLastName = "Doe",
                    CustomerFullName = "Jane Doe",
                    Address = "456 Elm St",
                    City = "Shelbyville",
                    ZipCode = 67890,
                    PhoneNumber = "555-5678",
                }) ;
            // Seed the database with dummy data for the Service class
            modelBuilder.Entity<Case>().HasData(
                new FourWheel.Domain.Models.Case
                {
                    CaseId = 1,
                    Description = "Service 2",
                    Type = "Type B",
                    StartTime = DateTime.Now,
                    EndTime = DateTime.Now.AddDays(2),
                    Status = "Lukket",
                    CustomerId = 2
                },
                new FourWheel.Domain.Models.Case
                {
                    CaseId = 2,
                    Description = "Service 3",
                    Type = "Type C",
                    StartTime = DateTime.Now,
                    EndTime = DateTime.Now.AddDays(3),
                    Status = "ventende",
                    CustomerId = 1
                });


        }
    }
}
