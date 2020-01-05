using HW9.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HW9.DataAccess
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Item> Items { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Item>()
                .HasData(
                new Item
                {
                    Name = "Item1",
                    Description = "This is item number one"
                },
                new Item
                {
                    Name = "Item2",
                    Description = "This is item number two"
                });
        }
    }
}
