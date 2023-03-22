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

namespace FourWheel.Domain.Data
{
    public class FourWheelsDBContext : DbContext
    {

        public DbSet<Customer> Customers { get; set; }
        public IConfiguration Configuration { get; private set; }
        public FourWheelsDBContext()
        {
            Configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .Build();

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
  

            //TODO: get da connection string
            optionsBuilder.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"))
                .EnableSensitiveDataLogging(true)
                .UseLoggerFactory(new ServiceCollection()
                .AddLogging(builder => builder.AddConsole()
                    .AddFilter(DbLoggerCategory.Database.Command.Name, LogLevel.Information))
                    .BuildServiceProvider().GetService<ILoggerFactory>());
        }

    }
}
