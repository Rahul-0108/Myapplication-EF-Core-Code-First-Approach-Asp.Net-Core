using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Myapplication.Models
    {
    public class MyDBContextClass : DbContext
        {

        // The DbContextOptions instance carries configuration information such as the connection string, database provider to use etc.
        public MyDBContextClass (DbContextOptions<MyDBContextClass> options) : base(options)
            {

            }

        // The DbContext class includes a DbSet<TEntity> property for each entity in the model.
        // We will use this DbSet property Employees to query and save instances of the Employee class.
        // The LINQ queries against the DbSet<TEntity> will be translated into queries against the underlying database.
        public DbSet<EmployeeClass> Employees
            {
            get;
            set;
            }

        protected override void OnModelCreating (ModelBuilder modelBuilder)
            {
            modelBuilder.Entity<EmployeeClass>().HasData(
               new EmployeeClass
                   {
                   SerialNo= 1,
                   EmployeeId = 2,
                   EmployeeName = "Abhishek",
                   EmployeeSalary = 100000
                   },
                new EmployeeClass
                    {
                    SerialNo=2,
                    EmployeeId = 4,
                    EmployeeName = "John",
                    EmployeeSalary = 100000
                    }



            );
            }
        }
    }
