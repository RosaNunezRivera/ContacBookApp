using ContacBookApp.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContacBookApp.Context
{
    public class ContactContext : DbContext
    {
        public ContactContext() : base()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.;Database=ContactDB1;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        public DbSet<Contact> Contacts { get; set; }
    }
}
