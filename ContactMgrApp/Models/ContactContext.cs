//CSC 237
//Aliaksandra Hrechka
//02/16/2020
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactMgrApp.Models
{
    public class ContactContext: DbContext
    {
        public ContactContext(DbContextOptions<ContactContext> options)
            :base(options)
        { }

        public DbSet<Category> Categories { get; set; }// give table a name
        public DbSet<Contact> Contacts { get; set; }// give table a name

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, Name = "Family" },
                new Category { CategoryId = 2, Name = "Friend" },
                new Category { CategoryId = 3, Name = "Work" },
                new Category { CategoryId = 4, Name = "Other" }

                );
            modelBuilder.Entity<Contact>().HasData(
                new Contact
                {
                    ContactId = 1,
                    FirstName = "Mary Ellen",
                    LastName = "Walton",
                    Phone = "720-555-5555",
                    Email = "maryellenwalton@gmail.com",
                    CategoryId = 1,
                    DateAdded = DateTime.Now
                },
                new Contact
                {
                    ContactId = 2,
                    FirstName = "Sara",
                    LastName = "Vimes",
                    Phone = "720-898-9999",
                    Email = "saravimes1@gmail.com",
                    CategoryId = 3,
                    DateAdded = DateTime.Now
                }
                );
        }
    }
}
