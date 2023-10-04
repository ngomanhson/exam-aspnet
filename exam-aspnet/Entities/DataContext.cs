using System;
using Microsoft.EntityFrameworkCore;
using exam_aspnet.Entities;

namespace exam_aspnet.Entities
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}