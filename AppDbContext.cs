using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using apiControls.Models;
using System.Data.Entity;

namespace apiControls
{
    public class AppDbContext:DbContext
    {
        public DbSet<Customer> Customers {get;set;}
        public DbSet<Movie> Movies {get;set;}
        public DbSet<Rental> Rental { get; set; }

        public AppDbContext()
           : base("name=defaultconnection")
        { }

    }
}